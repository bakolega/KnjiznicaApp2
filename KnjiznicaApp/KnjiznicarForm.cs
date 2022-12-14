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
        public KnjiznicarForm()
        {
            InitializeComponent();
        }

        private void KnjiznicarForm_Load(object sender, EventArgs e)
        {
            

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

        private void knjigaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
