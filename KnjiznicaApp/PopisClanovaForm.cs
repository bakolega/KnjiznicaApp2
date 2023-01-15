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
    public partial class PopisClanovaForm : Form
    {
        public PopisClanovaForm()
        {
            InitializeComponent();
        }

        private void PopisClanovaForm_Load(object sender, EventArgs e)
        {
            PopisClanovaDGW.DataSource = DataAcces.GetAllClanovi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!(DodajUsernameTxb.Text=="" || DodajPasswordTxb.Text==""|| DodajImeTxb.Text==""||DodajPrezimeTxb.Text==""))
                DataAcces.InsertClan(DodajUsernameTxb.Text,DodajPasswordTxb.Text,DodajImeTxb.Text,DodajPrezimeTxb.Text);
        }
    }
}
