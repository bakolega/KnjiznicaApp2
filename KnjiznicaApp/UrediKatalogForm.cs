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
            

            AutoriCombobox.Items.AddRange(DataAcces.GetAutorPrezimeIme().ToArray());
            AutoriCombobox.DisplayMember = "AutorPrezimeIme";

            UlogaComboBox.Items.AddRange(DataAcces.GetUloge().ToArray());
            UlogaComboBox.DisplayMember = "UlogaNaziv";


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
            int tempID = (int)UrediDataGridView["knjigaIDDataGridViewTextBoxColumn", e.RowIndex].Value;
            IDUrediTxtBox.Text = tempID.ToString();//Ispisi izabrani ID
            UrediNazivTxtBox.Text = UrediDataGridView["nazivDataGridViewTextBoxColumn", e.RowIndex].Value.ToString();//Ispisi izabrani naziv knjige

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

            
        }
    }
}
