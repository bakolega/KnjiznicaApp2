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

            AutoriCombobox.Items.AddRange(DataAcces.GetAutorPrezimeIme().ToArray());
            AutoriCombobox.DisplayMember = "AutorPrezimeIme";

            UlogaComboBox.Items.AddRange(DataAcces.GetUloge().ToArray());
            UlogaComboBox.DisplayMember = "UlogaNaziv";

            IzdavciComboboc.Items.AddRange(DataAcces.GetIzdavaci().ToArray());
            IzdavciComboboc.DisplayMember = "Naziv";
            IzdavciComboboc.ValueMember = "IzdavacID";



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
            //int tempID = (int)UrediDataGridView["knjigaIDDataGridViewTextBoxColumn", e.RowIndex].Value;
            //IDUrediTxtBox.Text = tempID.ToString();//Ispisi izabrani ID
            //UrediNazivTxtBox.Text = UrediDataGridView["nazivDataGridViewTextBoxColumn", e.RowIndex].Value.ToString();//Ispisi izabrani naziv knjige

            ////Ispisuje uloge autora na listviewu
            //AutoriUlogeListView.Items.Clear();
            //LinkedList<ListViewItem> LVIlista = new LinkedList<ListViewItem>();
            //foreach (UlogaAutori item in DataAcces.GetAutorUlogeForKnjiga(tempID))
            //{
            //    ListViewItem temp = new ListViewItem();
            //    temp.Text = item.UlogaNaziv;
            //    temp.SubItems.Add(item.Autori);
            //    LVIlista.AddLast(temp);
            //}
            //AutoriUlogeListView.Items.AddRange(LVIlista.ToArray());

            
        }

        private void DodajKnjiguButton_Click(object sender, EventArgs e)
        {
           // var temp= IzdavciComboboc.SelectedValue;

            DataAcces.InsertKnjiga(UrediNazivTxtBox.Text,1, null, int.Parse(UrediGodinaTxtBox.Text));
        }

        private void UrediDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int tempID = (int)UrediDataGridView[0, e.RowIndex].Value;
                
                IDUrediTxtBox.Text = tempID.ToString();//Ispisi izabrani ID
                UrediNazivTxtBox.Text = UrediDataGridView[1, e.RowIndex].Value.ToString();//Ispisi izabrani naziv knjige

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

               // string tempIzdavac = UrediDataGridView[6, e.RowIndex].Value.ToString();
               // IzdavciComboboc.SelectedValue= tempIzdavac;
            }
        }

        private void TraziButton_Click(object sender, EventArgs e)
        {
            this.getWhereNazivKnjigeTableAdapter.Fill(this.knjiznicaDataSet.GetWhereNazivKnjige,TraziTxtBox.Text);
            UrediDataGridView.DataSource = getWhereNazivKnjigeBindingSource;
        }

        private void DeleteKnjiga_Click(object sender, EventArgs e)
        {
            DataAcces.DeleteKnjiga(int.Parse(IDUrediTxtBox.Text));
        }
    }
}
