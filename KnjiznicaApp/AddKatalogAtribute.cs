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
    public partial class AddKatalogAtribute : Form
    {

        public string unos;
        public AddKatalogAtribute(string tekst)
        {
            InitializeComponent();
            this.Text= tekst;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                unos = textBox1.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void OdustaniButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
