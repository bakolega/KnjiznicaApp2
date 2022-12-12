using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnjiznicaApp
{
    public partial class Form1 : Form
    {
        List<Knjiga> knjigaList = new List<Knjiga>();
        //private void UpdateBind()
        //{
        //    KnjigeListView1.
        //    KnjigeListView1.DisplayMember = "Display";//Germinal - Zola - 1885
        //}

        public Form1()
        {
            InitializeComponent();

            //UpdateBind();
        }

        private void ShowKnjigeButton_Click(object sender, EventArgs e)
        {
            //DataAcces baza = new DataAcces();
            //knjigaList  = baza.getKnjige();
            ////UpdateBind();
            //LinkedList<ListViewItem> LVIlista = new LinkedList<ListViewItem>();

            //foreach (Knjiga item in knjigaList)
            //{
            //    ListViewItem tempLVItem = new ListViewItem(item.Naziv.ToString());
            //    tempLVItem.SubItems.Add(item.Autor);
            //    tempLVItem.SubItems.Add(item.Godina.ToString());
            //    tempLVItem.SubItems.Add(item.id.ToString());
            //    LVIlista.AddLast(tempLVItem);
            //}

            //KnjigeListView1.Items.AddRange(LVIlista.ToArray());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void OpenClFormButton_Click(object sender, EventArgs e)
        {
            ClanForm ClForm = new ClanForm();
            this.Hide();
            ClForm.ShowDialog();
            //this.Close();
        }

        private void OpenKnjFormButton_Click(object sender, EventArgs e)
        {
            KnjiznicarForm KnjizForm = new KnjiznicarForm();
            this.Hide();
            KnjizForm.ShowDialog();
            //this.Close();
        }
    }
}
