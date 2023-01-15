using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnjiznicaApp
{
    public partial class KnjiznicarForm : Form

    {
        int IDKnjiznicar;
        string Username;
        public KnjiznicarForm(int IDlogin, string UsernameKnjiznicar)
        {
            IDKnjiznicar = IDlogin;
            Username = UsernameKnjiznicar;

            InitializeComponent();
            this.Text = Username + " (" + IDKnjiznicar + ")";
        }

        private void KnjiznicarForm_Load(object sender, EventArgs e)
        {
            KnjiznicarDataGridView.DataSource = DataAcces.GetAllKnjige();
            KnjiznicarDataGridView.ClearSelection();

            List<string> temp = new List<string>();
            temp.Add("Katalog");
            foreach (DataGridViewColumn item in KnjiznicarDataGridView.Columns)
            {
                temp.Add(item.Name);
            }

            searchIzborComboBox.DataSource = temp;

            chooseLokacijaKopijeCBX.DataSource = DataAcces.GetLokacije();
            chooseLokacijaKopijeCBX.DisplayMember = "Naziv";
            chooseLokacijaKopijeCBX.ValueMember = "LokacijaID";
        }

        private void KnjiznicarForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            InterForm.goback(this);
        }

        private void UrediKatalogButton_Click(object sender, EventArgs e)
        {
            UrediKatalogForm UrediForm = new UrediKatalogForm();
            UrediForm.ShowDialog();
        }

        private void KnjiznicarDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)
            {
                int tempID = (int)KnjiznicarDataGridView["KnjigaID", e.RowIndex].Value;
                IDUrediTxtBox.Text = tempID.ToString();//Ispisi izabrani ID

                Informacije tempInfo = DataAcces.GetInformacije(tempID);// infomracije osim autora

                UrediNazivTxtBox.Text = tempInfo.Naziv;
                IzdavacTxtBox.Text = tempInfo.Izdavac;
                JezikTextBox.Text = tempInfo.Jezik;
                MjestoIzdavanjaTxtBox.Text = tempInfo.Mjesto;


                AutoriUlogeListView.Items.Clear();
                AutoriUlogeListView.Groups.Clear();

                int i = 0;
                foreach (UlogaAutoriv2 item in DataAcces.GetAutorUlogeForKnjigav2(tempID))
                {
                    AutoriUlogeListView.Groups.Add(item.UlogaNaziv, item.UlogaNaziv).Tag = item.UlogaID;
                    foreach (Autor atr in item.AutorIList)
                    {
                        ListViewItem tempLVItem = new ListViewItem();
                        tempLVItem.Text = atr.AutorPrezimeIme;
                        tempLVItem.Tag = atr.AutorID;

                        AutoriUlogeListView.Groups[i].Items.Add(tempLVItem);
                        AutoriUlogeListView.Items.Add(tempLVItem);
                    }
                    i++;
                }


                kopijeDG.Tag = tempID;
                kopijeDG.DataSource = DataAcces.GetKopijeKnjiznicar(tempID);

                this.Refresh();

            }
        }

        private void kopijeDG_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //Formatira stupac dostupno i stupac opcije. 
            //1:Dostupno / 0:Rezervirano ali neposuđeno/ -1:Posuđeno
            if (kopijeDG.Columns[e.ColumnIndex].Name == "Dostupno")
            {
                if (e.Value is -1)
                {
                    e.Value = "Posuđeno";
                    e.CellStyle.ForeColor = Color.Red;
                    kopijeDG["Opcije", e.RowIndex].Value = "Povrat";

                    kopijeDG["PosudbaID", e.RowIndex].Value=DataAcces.GetCurrentPosudbaForKopija((int)kopijeDG["ID", e.RowIndex].Value);
                }
                else if (e.Value is 0)
                {
                    e.Value = "Rezervirano";
                    e.CellStyle.ForeColor = Color.Black;
                    kopijeDG["Opcije", e.RowIndex].Value = "Posudba";
                }
                else if (e.Value is 1)
                {
                    e.Value = "Dostupno";
                    e.CellStyle.ForeColor = Color.Green;
                    kopijeDG["Opcije", e.RowIndex].Value="Posudba";
                }
            }
        }

        private void kopijeDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (senderGrid["Opcije",e.RowIndex].Value is "Posudba")
                {
                    int tempID = 0;
                    int kopijaIDtemp = (int)senderGrid["ID", e.RowIndex].Value;
                    if ((int)senderGrid["Dostupno", e.RowIndex].Value == 0)//formatirano 0 se PRIKAZUJE kao "Rezervirano" ali vrijednost ostaje 0!!!
                        tempID = DataAcces.GetRezerviarniClan(kopijaIDtemp);

                    PosudbaForm posudbaDialog = new PosudbaForm(tempID);

                    if (posudbaDialog.ShowDialog(this) == DialogResult.OK)
                    {

                        DataAcces.InsertPosudba(kopijaIDtemp, posudbaDialog.clanIDPosudba, IDKnjiznicar);

                        kopijeDG.DataSource = DataAcces.GetKopijeKnjiznicar((int)kopijeDG.Tag);

                        if (tempID != 0) 
                        {
                            DataAcces.DeleteRezervacijaForKopija(kopijaIDtemp, posudbaDialog.clanIDPosudba);
                        }
                    }

                    posudbaDialog.Dispose();
                }
                else if (senderGrid["Opcije", e.RowIndex].Value is "Povrat")//povrat, racuna zakasninu i prikazuje messagebox
                {
                    DataTable temp =DataAcces.GetPosudbaZakasnjenje((int)kopijeDG["PosudbaID", e.RowIndex].Value);
                    int br_produzenja= (int)temp.Rows[0]["Br_Produzenja"];
                    DateTime datumPosudbe = Convert.ToDateTime(temp.Rows[0]["Dat_Posudbe"]);
                    int daniZakasnjenja = (DateTime.Today - datumPosudbe.AddDays(21 * br_produzenja)).Days;

                    string poruka;
                    if (daniZakasnjenja >0)
                    {
                        poruka = $"Zakasnina je {0.10*daniZakasnjenja}€ ({daniZakasnjenja} dana)";
                    }
                    else
                    {
                        poruka = "Nema zakasnine";
                    }

                    DialogResult dialogResult = MessageBox.Show(poruka, "Povrat", MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.OK)
                    {
                        DataAcces.UpdatePovratakPosudbe((int)kopijeDG["PosudbaID", e.RowIndex].Value);

                        kopijeDG.DataSource = DataAcces.GetKopijeKnjiznicar((int)kopijeDG.Tag);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }
            }
        }

        private void TraziTxtBox_TextChanged(object sender, EventArgs e)
        {
            string tempSearch = searchIzborComboBox.Text;

            if (tempSearch == "Katalog")
            {
                (KnjiznicarDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format($"Convert(knjigaID, 'System.String') like '%{TraziTxtBox.Text}%' OR [Naziv] like '%{TraziTxtBox.Text}%' OR [Autori] like '%{TraziTxtBox.Text}%' OR Convert([Godina], 'System.String') like '%{TraziTxtBox.Text}%' OR Convert([KnjigaID], 'System.String') like '%{TraziTxtBox.Text}%'");
            }
            else if (tempSearch == "KnjigaID" || tempSearch == "Godina")
            {
                (KnjiznicarDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format($"Convert([{tempSearch}], 'System.String') like '%{TraziTxtBox.Text}%'");
            }
            else
            {
                (KnjiznicarDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format($"[{tempSearch}] like '%{TraziTxtBox.Text}%'");
            }
        }

        private void addKopija_Click(object sender, EventArgs e)
        {
            if (kopijeDG.Tag != null)
            {
                DataAcces.InsertKopija((int)kopijeDG.Tag, (int)chooseLokacijaKopijeCBX.SelectedValue);
                kopijeDG.DataSource = DataAcces.GetKopijeKnjiznicar((int)kopijeDG.Tag);

            }
        }

        private void Clanovi_Click(object sender, EventArgs e)
        {
            PopisClanovaForm ClanoviForm = new PopisClanovaForm();
            ClanoviForm.ShowDialog();
        }
    }
}
