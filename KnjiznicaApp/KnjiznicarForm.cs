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

            //List<string> temp = new List<string>();
            //temp.Add("Katalog");
            //foreach (DataGridViewColumn item in KnjiznicarDataGridView.Columns)
            //{
            //    temp.Add(item.Name);
            //}

            searchIzborComboBox.DataSource = DodatneMetode.GetListColumnNames(KnjiznicarDataGridView);

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
            
            if (e.RowIndex > -1)//Izbjegava header
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

                //Ispisuje  na LV
                DodatneMetode.ispisiAutoreLV(DataAcces.GetAutorUlogeForKnjigav2(tempID), AutoriUlogeListView);

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

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)//Ako je botun
            {
                if (senderGrid["Opcije",e.RowIndex].Value is "Posudba")//Ako je posudba
                {
                    int tempID = 0;
                    int kopijaIDtemp = (int)senderGrid["ID", e.RowIndex].Value;
                    if ((int)senderGrid["Dostupno", e.RowIndex].Value == 0)//formatirano 0 se PRIKAZUJE kao "Rezervirano" ali vrijednost ostaje 0!!!
                        tempID = DataAcces.GetRezerviarniClan(kopijaIDtemp);//ako je rezerviarno uzimamo ID clana koji je rezervirao. GetRezerviarniClan vraca prvog u redu

                    PosudbaForm posudbaDialog = new PosudbaForm(tempID); //Ako je rezervirano ID nece biti 0 pa ce se taj clan postaviti kao prvi izbor

                    if (posudbaDialog.ShowDialog(this) == DialogResult.OK)//otvara se dialog, ako je OK inserta se posudba
                    {
                        DataAcces.InsertPosudba(kopijaIDtemp, posudbaDialog.clanIDPosudba, IDKnjiznicar);

                        kopijeDG.DataSource = DataAcces.GetKopijeKnjiznicar((int)kopijeDG.Tag);//updatea se DGV

                        if (tempID != 0) //Ako bilo rezervirano brise se rezervacija
                        {
                            DataAcces.DeleteRezervacijaForKopija(kopijaIDtemp, posudbaDialog.clanIDPosudba);
                        }
                    }

                    posudbaDialog.Dispose();
                }
                else if (senderGrid["Opcije", e.RowIndex].Value is "Povrat")//povrat; racuna se eventualna zakasnina i prikazuje u messageboxu
                {
                    DataTable temp =DataAcces.GetPosudbaZakasnjenje((int)kopijeDG["PosudbaID", e.RowIndex].Value);//Dobija se datumm posdube i br produzenja

                    string poruka = DodatneMetode.ispisIzracunZakansine(Convert.ToDateTime(temp.Rows[0]["Dat_Posudbe"]), (int)temp.Rows[0]["Br_Produzenja"]); //Racuna se i ispisuje u string zakasnina

                    DialogResult dialogResult = MessageBox.Show(poruka, "Povrat", MessageBoxButtons.OKCancel); //Prikazuje se ima li tj kolika je zakasnina

                    if (dialogResult == DialogResult.OK)//Ako je ok u bazi se dodaje datum povratka, ako nije ništa!
                    {
                        DataAcces.UpdatePovratakPosudbe((int)kopijeDG["PosudbaID", e.RowIndex].Value);

                        kopijeDG.DataSource = DataAcces.GetKopijeKnjiznicar((int)kopijeDG.Tag);
                    }
                   
                }
            }
        }

        private void TraziTxtBox_TextChanged(object sender, EventArgs e)
        {
            //search
            (KnjiznicarDataGridView.DataSource as DataTable).DefaultView.RowFilter = DodatneMetode.FilterStringMaker(searchIzborComboBox.Text, TraziTxtBox.Text);
        }

        private void addKopija_Click(object sender, EventArgs e)
        {
            //Dodaje se kopija izabrane knjige, ako nekako nije izabrana lokacija, ništa!
            if (kopijeDG.Tag != null)
            {
                DataAcces.InsertKopija((int)kopijeDG.Tag, (int)chooseLokacijaKopijeCBX.SelectedValue);
                kopijeDG.DataSource = DataAcces.GetKopijeKnjiznicar((int)kopijeDG.Tag);

            }
        }

        private void Clanovi_Click(object sender, EventArgs e)
        {
            //Otvara se popis clanova
            PopisClanovaForm ClanoviForm = new PopisClanovaForm();
            ClanoviForm.ShowDialog();
        }
    }
}
