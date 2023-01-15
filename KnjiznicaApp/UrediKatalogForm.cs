using Dapper;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KnjiznicaApp
{
    public partial class UrediKatalogForm : Form
    {
        public UrediKatalogForm()
        {
            InitializeComponent();
        }

        private void UrediKatalogForm_Load(object sender, EventArgs e)
        {
         

            UrediDataGridView.DataSource = DataAcces.GetAllKnjige();
            UrediDataGridView.ClearSelection();

            AutoriCombobox.DataSource = DataAcces.GetAutorPrezimeIme();
            AutoriCombobox.DisplayMember = "AutorPrezimeIme";
            AutoriCombobox.ValueMember = "AutorID";
            AutoriCombobox.SelectedItem = null;

            UlogaComboBox.DataSource=DataAcces.GetUloge();
            UlogaComboBox.DisplayMember = "UlogaNaziv";
            UlogaComboBox.ValueMember = "UloagaID";
            UlogaComboBox.SelectedItem = null;

            UrediIzdavaciCombiBoc.DataSource = DataAcces.GetIzdavaci();
            UrediIzdavaciCombiBoc.DisplayMember = "Naziv";
            UrediIzdavaciCombiBoc.ValueMember = "IzdavacID";
            UrediIzdavaciCombiBoc.SelectedItem = null;

            JezikComboBox.DataSource = DataAcces.GetJezike();
            JezikComboBox.DisplayMember = "Naziv";
            JezikComboBox.ValueMember = "JezikID";
            JezikComboBox.SelectedItem = null;

            MjestoIzdavanjaComboBox.DataSource = DataAcces.GetMjesta();

            MjestoIzdavanjaComboBox.DisplayMember = "Naziv";
            MjestoIzdavanjaComboBox.ValueMember = "MjestoID";
            MjestoIzdavanjaComboBox.SelectedItem = null;

            //"name" stupaca dodaje u comobox koji filtrira search
            searchIzborComboBox.DataSource = DodatneMetode.GetListColumnNames(UrediDataGridView);


        }

        private void DodajKnjiguButton_Click(object sender, EventArgs e)
        {
            if (UrediNazivTxtBox.Text == "")
            {
                MessageBox.Show("Unesite naziv");
                return;
            }

            int? tempIzdavacID;//Ako je izabrano postojece salje se ID izavaca int? je nullabilni int
            if (UrediIzdavaciCombiBoc.SelectedIndex > -1)
            {
                tempIzdavacID = (int)UrediIzdavaciCombiBoc.SelectedValue;
            }
            else
            {
                tempIzdavacID = null;
            }

            int? tempJezikID;
            if (JezikComboBox.SelectedIndex > -1)
            {
                tempJezikID = (int)JezikComboBox.SelectedValue;
            }
            else
            {
                tempJezikID = null;
            }

            int? tempMjestoID;
            if (MjestoIzdavanjaComboBox.SelectedIndex > -1)
            {
                tempMjestoID = (int)MjestoIzdavanjaComboBox.SelectedValue;
            }
            else
            {
                tempMjestoID = null;
            }
            
            DataAcces.InsertKnjiga(UrediNazivTxtBox.Text, tempIzdavacID, (int)GodinaUpDown.Value, tempMjestoID, tempJezikID);

            UrediDataGridView.DataSource = DataAcces.GetAllKnjige();

        }

        private void DeleteKnjiga_Click(object sender, EventArgs e)
        {

            if (UrediDataGridView.SelectedRows.Count > 0)
            {
                
                List<ID> idsToDelete = new List<ID>();
                foreach (DataGridViewRow row in UrediDataGridView.SelectedRows)
                {
                    idsToDelete.Add(new ID { knjigaID = (int)row.Cells["KnjigaID"].Value });
                }
                DataAcces.DeleteKnjige(idsToDelete);


                UrediDataGridView.DataSource = DataAcces.GetAllKnjige();
                UrediDataGridView.ClearSelection();
            }

        }

        private void AutoreToLvButton_Click(object sender, EventArgs e)
        {
            ListViewItem tempLVItem = new ListViewItem();

            tempLVItem.Text = AutoriCombobox.SelectedItem.ToString(); ;
            tempLVItem.Tag = AutoriCombobox.SelectedValue;

            AutoriUlogeListView.Items.Add(tempLVItem);
            int i = 0;
            foreach (ListViewGroup grupa in AutoriUlogeListView.Groups)
            {
                if ((int)grupa.Tag==(int)UlogaComboBox.SelectedValue)
                {
                    grupa.Items.Add(tempLVItem);
                    return;
                }
                i++;
            }
            AutoriUlogeListView.Groups.Add(UlogaComboBox.SelectedItem.ToString(), UlogaComboBox.SelectedItem.ToString()).Tag = UlogaComboBox.SelectedValue;
            AutoriUlogeListView.Groups[i].Items.Add(tempLVItem);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Dodaje autore sa LV u bazu
            List<UlogaAutoriInsertHelper> autoriInsertList = new List<UlogaAutoriInsertHelper>();

            foreach (ListViewGroup grupa in AutoriUlogeListView.Groups)
            {
                foreach (ListViewItem item in grupa.Items)
                {
                    autoriInsertList.Add(
                    new UlogaAutoriInsertHelper { KnjigaID = int.Parse(IDUrediTxtBox.Text), AutorID=(int)item.Tag, Uloga=(int)grupa.Tag }
                    );
                }
            }

            
            DataAcces.InsertKnjigaAutorUloga(autoriInsertList);
            UrediDataGridView.DataSource = DataAcces.GetAllKnjige();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(IDUrediTxtBox.Text)) { 
            AutoriUlogeListView.Items.Clear();
            AutoriUlogeListView.Groups.Clear();

            DataAcces.DeleteKnjigaAutorUloga(new ID { knjigaID = int.Parse(IDUrediTxtBox.Text) });
            }
        }

        private void TraziTxtBox_TextChanged(object sender, EventArgs e)
        {
            //Pretraga
            (UrediDataGridView.DataSource as DataTable).DefaultView.RowFilter = DodatneMetode.FilterStringMaker(searchIzborComboBox.Text, TraziTxtBox.Text);
     
        }

        private void UrediDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int tempID = (int)UrediDataGridView[0, e.RowIndex].Value;

                IDUrediTxtBox.Text = tempID.ToString();//Ispisi izabrani ID

                Informacije tempInfo = DataAcces.GetInformacije(tempID);//Sve infomracije osim autora

                UrediNazivTxtBox.Text = tempInfo.Naziv;
                UrediIzdavaciCombiBoc.Text = tempInfo.Izdavac;
                JezikComboBox.Text = tempInfo.Jezik;
                MjestoIzdavanjaComboBox.Text = tempInfo.Mjesto;



                //Ispisuje uloge autora na listviewu

                AutoriUlogeListView.Items.Clear();
                AutoriUlogeListView.Groups.Clear();

                DodatneMetode.ispisiAutoreLV(DataAcces.GetAutorUlogeForKnjigav2(tempID), AutoriUlogeListView);


            }
        }

        //Botuni za dodavanje novih autora, uloga, izdavac itd

        private void AddAutor_Click(object sender, EventArgs e)
        {
            AddKatalogAtribute posudbaDialog = new AddKatalogAtribute("Unos novog autora");

            if (posudbaDialog.ShowDialog(this) == DialogResult.OK && !string.IsNullOrEmpty(posudbaDialog.unos))
            {
                if (posudbaDialog.unos.Contains(","))
                {
                    string[] temp = posudbaDialog.unos.Split(new[] { ',' },2); //ako je vise od jednog zareza ovo ce i dalje splitat na samo 2 dila
                    DataAcces.InsertAutor(temp[0].Trim(), temp[1].Trim());
                }
                else if(posudbaDialog.unos.Trim().Contains(" "))
                {
                    string[] temp = posudbaDialog.unos.Split(new[] { ' ' }, 2);//Ako ima razmak onda se uzima da je prva riječ ime ostalo prezime
                    DataAcces.InsertAutor(temp[0].Trim(), temp[1].Trim());     //
                }
                else                                                           
                {
                    DataAcces.InsertAutor(posudbaDialog.unos,"");  //Ako nema razmaka ni zareza onda je samo ime
                }
                AutoriCombobox.DataSource = DataAcces.GetAutorPrezimeIme();

            }

            posudbaDialog.Dispose();
        }

        private void AddUloga_Click(object sender, EventArgs e)
        {
            AddKatalogAtribute posudbaDialog = new AddKatalogAtribute("Unos nove uloge");

            if (posudbaDialog.ShowDialog(this) == DialogResult.OK && !string.IsNullOrEmpty(posudbaDialog.unos))
            {
                

                DataAcces.InsertUloga(posudbaDialog.unos.Trim());
                UlogaComboBox.DataSource = DataAcces.GetUloge();

            }

            posudbaDialog.Dispose();
        }

        private void AddMjestoIzdavanja_Click(object sender, EventArgs e)
        {
            AddKatalogAtribute posudbaDialog = new AddKatalogAtribute("Unos novog mjesta izdavanja");

            if (posudbaDialog.ShowDialog(this) == DialogResult.OK && !string.IsNullOrEmpty(posudbaDialog.unos))
            {
                DataAcces.InsertMjesto(posudbaDialog.unos.Trim());
                MjestoIzdavanjaComboBox.DataSource = DataAcces.GetMjesta();
            }
            posudbaDialog.Dispose();
        }

        private void AddJezik_Click(object sender, EventArgs e)
        {
            AddKatalogAtribute posudbaDialog = new AddKatalogAtribute("Unos novog jezika");

            if (posudbaDialog.ShowDialog(this) == DialogResult.OK && !string.IsNullOrEmpty(posudbaDialog.unos) )
            {
                DataAcces.InsertJezik(posudbaDialog.unos.Trim());
                JezikComboBox.DataSource = DataAcces.GetJezike();
            }
            posudbaDialog.Dispose();
        }

        private void AddIzdavac_Click(object sender, EventArgs e)
        {
            AddKatalogAtribute posudbaDialog = new AddKatalogAtribute("Unos novog izdavaca");

            if (posudbaDialog.ShowDialog(this) == DialogResult.OK && !string.IsNullOrEmpty(posudbaDialog.unos))
            {
                DataAcces.InsertIzdavac(posudbaDialog.unos.Trim());
                UrediIzdavaciCombiBoc.DataSource = DataAcces.GetIzdavaci();
            }
            posudbaDialog.Dispose();
        }
    }
}
