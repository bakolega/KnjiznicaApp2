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
            // TODO: This line of code loads data into the 'knjiznicaDataSet.GetAllKnjigeForIspis' table. You can move, or remove it, as needed.
            this.getAllKnjigeForIspisTableAdapter.Fill(this.knjiznicaDataSet.GetAllKnjigeForIspis);

            // UrediDataGridView.DataSource = DataAcces.getKnjigeIspis();

            //List<Knjiga> tempkn= DataAcces.getKnjigeIspis();
            // UrediDataGridView.DataSource= tempkn;

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


        }

        private void autorBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void getAutorPrezimeImeBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void getAutorPrezimeImeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UrediDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

            
        }

        private void DodajKnjiguButton_Click(object sender, EventArgs e)
        {
            if (UrediNazivTxtBox.Text == "")
            {
                MessageBox.Show("Unesite naziv");
                return;
            }

            int? tempIzdavacID;//Ako je izabrano postojece salje se ID izavaca,ako nije -1 sta se pretvara u NULL u funkciji
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

            
        }

        private void UrediDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
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

              
               
                int i = 0;
                foreach (UlogaAutoriv2 item in DataAcces.GetAutorUlogeForKnjigav2(tempID))
                {
                    AutoriUlogeListView.Groups.Add(item.UlogaNaziv, item.UlogaNaziv).Tag= item.UlogaID;
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

              
            }
        }

        private void TraziButton_Click(object sender, EventArgs e)
        {
            this.getWhereNazivKnjigeTableAdapter.Fill(this.knjiznicaDataSet.GetWhereNazivKnjige,TraziTxtBox.Text);
            UrediDataGridView.DataSource = getWhereNazivKnjigeBindingSource;
        }

        private void DeleteKnjiga_Click(object sender, EventArgs e)
        {
            
            //DataAcces.DeleteKnjiga(int.Parse(IDUrediTxtBox.Text));

            if (UrediDataGridView.SelectedRows.Count > 0)
            {
                
                List<ID> idsToDelete = new List<ID>();
                foreach (DataGridViewRow row in UrediDataGridView.SelectedRows)
                {
                    idsToDelete.Add(new ID { forID = (int)row.Cells[0].Value });
                }
                DataAcces.DeleteKnjige(idsToDelete);
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AutoriUlogeListView.Items.Clear();
            AutoriUlogeListView.Groups.Clear();

            DataAcces.DeleteKnjigaAutorUloga(new ID { forID = int.Parse(IDUrediTxtBox.Text) });
        }
    }
}
