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
            PosudenoDG.ClearSelection();
            RezerviranoDG.DataSource=DataAcces.GetRezervacije(clanID);

            this.Text = username + "Posuđeno";
        }

        private void PosudenoDG_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (PosudenoDG.Columns[e.ColumnIndex].Name == "DatumVracanja")
            {
                
                int brProduzenja = (int)PosudenoDG["Br_Produzenja", e.RowIndex].Value;//Iz DGV se cita br produzenja
                DateTime datumPosudbe = (DateTime)PosudenoDG["Posudeno", e.RowIndex].Value;//Iz DGV se cita datum posudbe
                DateTime rokPovratka = DodatneMetode.izracunRoka(datumPosudbe, brProduzenja);
     
                e.Value = rokPovratka.ToShortDateString();

                
                if(DateTime.Today > rokPovratka.Date)
                {
                    //Ako je rok prosao pitura se u crveno 
                    e.CellStyle.ForeColor= Color.Red;

                    //i mice se botun za produzenje
                    DataGridViewTextBoxCell txtcell = new DataGridViewTextBoxCell();
                    PosudenoDG["Produzi", e.RowIndex] = txtcell;
                    
                    //Ispisuje se cijena i koliko dana zakasnine
                    PosudenoDG["Zakasnina", e.RowIndex].Value =DodatneMetode.ispisIzracunZakansine(datumPosudbe, brProduzenja);
                }
                else if (brProduzenja >= DodatneMetode.dozvoljenoProduzenja)
                {
                    //Ako je br produzenja dosegao prag 2, mice se botun
                    DataGridViewTextBoxCell txtcell = new DataGridViewTextBoxCell();
                    PosudenoDG["Produzi", e.RowIndex] = txtcell;
                }
                else
                {
                    //Ako se moze produziti, stavlja se + na botun
                    PosudenoDG["Produzi", e.RowIndex].Value = "+";
                }
                
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
                //Koliko je clanova koji su rezervirali ispred rezivacije 
                int brIspred = (int)RezerviranoDG["BrRezervacijaIspred", e.RowIndex].Value;

                if (RezerviranoDG["Dat_Vracanja", e.RowIndex].Value.ToString()=="")
                {
                    //Ako je posudeno prikazuje prikazuje se koliko je ljudi rezerviralo prije
                    e.Value = (brIspred+1).ToString()+". u redu";
                    e.CellStyle.ForeColor = Color.Black;
                }
                else
                {
                    if ((int)RezerviranoDG["BrRezervacijaIspred", e.RowIndex].Value == 0)
                    {
                        //Ako je nije posudeno i prvi je na redu
                        e.Value = "Dostupno";
                        e.CellStyle.ForeColor = Color.Green;
                    }
                    else
                    {
                        //Ako nije prvi na redu
                        e.Value = (brIspred + 1).ToString() + ". u redu";
                        e.CellStyle.ForeColor = Color.Black;
                    }
                }

            }
        }
        private void RezerviranoDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex == RezerviranoDG.Columns["Otkazi"].Index)
            {
                //ako je kliknut botun Otkazi briše se rezervacija
                DataAcces.DeleteRezervacija((int)RezerviranoDG["RezervacijaID",e.RowIndex].Value);
                RezerviranoDG.DataSource = DataAcces.GetRezervacije(clanID);

            }
        }
    }
}
