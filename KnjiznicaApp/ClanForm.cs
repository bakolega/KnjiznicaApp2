using System;
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
    public partial class ClanForm : Form
    {
        public ClanForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClanForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'knjiznicaDataSet.GetAllKnjigeForIspis' table. You can move, or remove it, as needed.
            this.getAllKnjigeForIspisTableAdapter.Fill(this.knjiznicaDataSet.GetAllKnjigeForIspis);
            // TODO: This line of code loads data into the 'knjiznicaDataSet.GetAllKnjigeForIspis' table. You can move, or remove it, as needed.
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void OdjavaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClanDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)
            {
                int tempID = (int)ClanDataGridView[0, e.RowIndex].Value;
                IDUrediTxtBox.Text = tempID.ToString();//Ispisi izabrani ID

                Informacije tempInfo = DataAcces.GetInformacije(tempID);// infomracije osim autora

                UrediNazivTxtBox.Text = tempInfo.Naziv;
                MjestoIzdavanjaTxtBox.Text = tempInfo.Izdavac;
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
            }
            
        }

        private void ClanForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            InterForm.goback(this);
        }

        private void ClanDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TraziButton_Click(object sender, EventArgs e)
        {
            this.getWhereNazivKnjigeTableAdapter.Fill(this.knjiznicaDataSet.GetWhereNazivKnjige, TraziTxtBox.Text);
            ClanDataGridView.DataSource = getWhereNazivKnjigeBindingSource;
        }
    }
}
