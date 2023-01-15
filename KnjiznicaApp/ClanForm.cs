using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KnjiznicaApp
{
    public partial class ClanForm : Form
    {
        int IDClana;
        string Username;
        public ClanForm(int IDlogin, string UsernameClana)
        {
            IDClana = IDlogin;
            Username = UsernameClana;

            InitializeComponent();
            this.Text = Username + " (" + IDClana + ")";
        }
        private void ClanForm_Load(object sender, EventArgs e)
        {
            ClanDataGridView.DataSource = DataAcces.GetAllKnjige();
            ClanDataGridView.ClearSelection();
            
            //"name" stupaca dodaje u comobox koji filtrira search
            searchIzborComboBox.DataSource = DodatneMetode.GetListColumnNames(ClanDataGridView);
        }


        private void OdjavaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClanDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)
            {
                int tempID = (int)ClanDataGridView["KnjigaID", e.RowIndex].Value;
                IDUrediTxtBox.Text = tempID.ToString();//Ispisi izabrani ID

                Informacije tempInfo = DataAcces.GetInformacije(tempID);// infomracije osim autora

                UrediNazivTxtBox.Text = tempInfo.Naziv;
                IzdavacTxtBox.Text = tempInfo.Izdavac;
                JezikTextBox.Text = tempInfo.Jezik;
                MjestoIzdavanjaTxtBox.Text = tempInfo.Mjesto;


                AutoriUlogeListView.Items.Clear();
                AutoriUlogeListView.Groups.Clear();

                //Ispsuje autore na lv
                DodatneMetode.ispisiAutoreLV(DataAcces.GetAutorUlogeForKnjigav2(tempID),AutoriUlogeListView);



                kopijeDG.Tag = tempID;
                kopijeDG.DataSource = DataAcces.GetKopije2(tempID, IDClana);

                this.Refresh();

            }

        }




        private void ClanForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Za vracanje na prijasnju login formu
            InterForm.goback(this);
        }


        private void kopijeDG_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //Formatira stupac "dostupno" i na temelju njega stupac rezervacije; 0 - Nedostupno, -1 ovaj clan vec rezervirao, -2 ovaj clan vec posudio, 1 dostupno
            if (kopijeDG.Columns[e.ColumnIndex].Name == "Dostupno")
            {
                if (e.Value is 0)
                {
                    e.Value = "X";
                    e.CellStyle.ForeColor = Color.Red;
                    kopijeDG["Rezervacije", e.RowIndex].Value = "Rezerviraj";

                }
                else if (e.Value is -1)
                {
                    e.Value = "Rezervirano";
                    e.CellStyle.ForeColor = Color.Black;
                    DataGridViewTextBoxCell txtcell = new DataGridViewTextBoxCell();
                    kopijeDG["Rezervacije", e.RowIndex] = txtcell;
                }
                else if (e.Value is -2)
                {
                    e.Value = "Posuđeno";
                    e.CellStyle.ForeColor = Color.Black;
                    DataGridViewTextBoxCell txtcell = new DataGridViewTextBoxCell();
                    kopijeDG["Rezervacije", e.RowIndex] = txtcell;
                }
                else if (e.Value is 1)
                {
                    e.Value = "✓";
                    e.CellStyle.ForeColor = Color.Green;
                    DataGridViewTextBoxCell txtcell = new DataGridViewTextBoxCell();
                    kopijeDG["Rezervacije", e.RowIndex] = txtcell;
                }
            }
        }

       

        private void kopijeDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Provjerava je li kliknut botun i inserta rezervaciju, zatim ponovo updatea datagridView
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                DataAcces.InsertRezervacija((int)kopijeDG["ID", e.RowIndex].Value, IDClana);

                kopijeDG.DataSource = DataAcces.GetKopije2((int)kopijeDG.Tag, IDClana);
            }
        }

        private void OpenPosudenoButton_Click(object sender, EventArgs e)
        {
            //Otvara formu za pregled posuđenog i rezerviranog
            ClanPosudenoForm clPosudeno = new ClanPosudenoForm(IDClana, Username);
            //this.Hide();
            clPosudeno.ShowDialog();
        }

        private void TraziTxtBox_TextChanged(object sender, EventArgs e)
        {
            (ClanDataGridView.DataSource as DataTable).DefaultView.RowFilter = DodatneMetode.FilterStringMaker(searchIzborComboBox.Text, TraziTxtBox.Text);

        }

        private void ClanDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
