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

namespace KnjiznicaApp
{
    public partial class ClanPosudenoForm : Form
    {
        int clanID;
        string username;
        public ClanPosudenoForm(int clanID, string user)
        {
            InitializeComponent();
            this.clanID = clanID;
            this.username = user;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            PosudenoDG.DataSource = DataAcces.GetPosudeno(clanID);
            RezerviranoDG.DataSource=DataAcces.GetRezervacije(clanID);
        }

        private void PosudenoDG_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (PosudenoDG.Columns[e.ColumnIndex].Name == "DatumVracanja")
            {
                
                int brProduzenja = (int)PosudenoDG["Br_Produzenja", e.RowIndex].Value+1;
                DateTime rokPovratka = ((DateTime)PosudenoDG["Posudeno", e.RowIndex].Value).AddDays(21 * brProduzenja);
                
                e.Value = rokPovratka.ToShortDateString();

                //Ako je rok prosao pitura se u crveno i mice se botun
                if(DateTime.Today > rokPovratka.Date)
                {
                    e.CellStyle.ForeColor= Color.Red;

                    DataGridViewTextBoxCell txtcell = new DataGridViewTextBoxCell();
                    PosudenoDG["Produzi", e.RowIndex] = txtcell;
                }
                else if (brProduzenja > 2)
                {
                    DataGridViewTextBoxCell txtcell = new DataGridViewTextBoxCell();
                    PosudenoDG["Produzi", e.RowIndex] = txtcell;
                }
                
            }

        }

        private void RezerviranoDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                DataAcces.DeleteRezervacija((int)RezerviranoDG["RezervacijaID",e.RowIndex].Value);
                RezerviranoDG.DataSource = DataAcces.GetRezervacije(clanID);

            }
        }

        private void PosudenoDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //Provjerava je li kliknut botun i updatea br produzenja, zatim ponovo updatea datagridView

            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
               
                DataAcces.UpdateBrProduzenja((int)PosudenoDG["PosudbaID", e.RowIndex].Value, (int)PosudenoDG["Br_Produzenja", e.RowIndex].Value+1);
                PosudenoDG.DataSource = DataAcces.GetPosudeno(clanID);

            }

        }

        private void RezerviranoDG_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (RezerviranoDG.Columns[e.ColumnIndex].Name == "Dostupno")
            {

                // int brProduzenja = (int)RezerviranoDG["Br_Produzenja_Rez", e.RowIndex].Value + 1;
                //DateTime rokPovratka = ((DateTime)RezerviranoDG["Datum_Posudbe_Rez", e.RowIndex].Value).AddDays(21 * brProduzenja);

                int brIspred = (int)RezerviranoDG["BrRezervacijaIspred", e.RowIndex].Value;
                if (RezerviranoDG["Dat_Vracanja", e.RowIndex].Value.ToString()=="")
                {
                    e.Value = (brIspred+1).ToString()+". u redu";
                    e.CellStyle.ForeColor = Color.Black;
                }
                else
                {
                    if ((int)RezerviranoDG["BrRezervacijaIspred", e.RowIndex].Value == 0)
                    {
                        e.Value = "Dostupno";
                        e.CellStyle.ForeColor = Color.Green;
                    }
                    else
                    {
                        e.Value = (brIspred + 1).ToString() + ". u redu";
                        e.CellStyle.ForeColor = Color.Black;
                    }
                }

            }
            }
}
}
