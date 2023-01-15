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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void OpenClFormButton_Click(object sender, EventArgs e)
        {
            int idlogin = DodatneMetode.LoginClan(UsernameTxtBox.Text, PasswordTxtBox.Text);
            if(idlogin > 0){
                ClanForm ClForm = new ClanForm(idlogin, UsernameTxtBox.Text);
                this.Hide();
                ClForm.ShowDialog();
            } 
        }

        private void OpenKnjFormButton_Click(object sender, EventArgs e)
        {
            int idlogin = DodatneMetode.LoginKnjiznicar(UsernameTxtBox.Text, PasswordTxtBox.Text);
            if (idlogin > 0)
            {
                KnjiznicarForm KnjizForm = new KnjiznicarForm(idlogin, UsernameTxtBox.Text);
                this.Hide();
                KnjizForm.ShowDialog();
            }

        }
    }
}
