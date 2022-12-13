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
            this.getAllKnjigeForIspisTableAdapter.Fill(this.knjiznicaDataSet.GetAllKnjigeForIspis);
            // TODO: This line of code loads data into the 'knjiznicaDataSet4.GetAllKnjigeForIspis' table. You can move, or remove it, as needed.
            // this.getAllKnjigeForIspisTableAdapter.Fill(this.knjiznicaDataSet4.GetAllKnjigeForIspis);


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
                int tempID = (int)ClanDataGridView["knjigaIDDataGridViewTextBoxColumn", e.RowIndex].Value;
                IDUrediTxtBox.Text = tempID.ToString();//Ispisi izabrani ID
                UrediNazivTxtBox.Text = ClanDataGridView["nazivDataGridViewTextBoxColumn", e.RowIndex].Value.ToString();//Ispisi izabrani naziv knjige

                //Ispisuje uloge autora na listviewu
                AutoriUlogeListView.Items.Clear();
                LinkedList<ListViewItem> LVIlista = new LinkedList<ListViewItem>();
                foreach (UlogaAutori item in DataAcces.GetAutorUlogeForKnjiga(tempID))
                {
                    ListViewItem temp = new ListViewItem();
                    temp.Text = item.UlogaNaziv;
                    temp.SubItems.Add(item.Autori);
                    LVIlista.AddLast(temp);
                }
                AutoriUlogeListView.Items.AddRange(LVIlista.ToArray());

                Informacije inf = DataAcces.GetInformacije(tempID);
                JezikTextBox.Text = inf.Jezik;
                MjestoIzdavanjaTxtBox.Text = inf.Mjesto;
                IzdavacTxtBox.Text = inf.Izdavac;
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
