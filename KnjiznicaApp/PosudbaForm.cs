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
    public partial class PosudbaForm : Form
    {
     
        public int clanIDPosudba;
        
        public PosudbaForm(int clanIDTemp = 0)
        {
            InitializeComponent();

            clanIDPosudba = clanIDTemp;
            
        }

        private void PosudbaForm_Load(object sender, EventArgs e)
        {
            ClanComboBox.DataSource = DataAcces.GetAllClan();
            
            ClanComboBox.SelectedValue= clanIDPosudba;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (ClanComboBox.SelectedValue != null)
            {
                clanIDPosudba = (int)ClanComboBox.SelectedValue;
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
