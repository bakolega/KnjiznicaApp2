using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnjiznicaApp
{
    internal class DodatneMetode
    {

        const double zakasninsaDanEur = 0.1;//Zakasnina u eurima
        public const int danaJednaPosudba = 21;//Dana koliko traje jedna posudba i produzenje
        public const int dozvoljenoProduzenja = 2;

        public static string ispisIzracunZakansine(DateTime posudba, int brProduzenja)//String koji se koristi za prikaz pri povratu
        {
            int daniZakasnjenja = (DateTime.Today - posudba.AddDays((brProduzenja + 1) * danaJednaPosudba)).Days;

            string poruka;
            if (daniZakasnjenja > 0)
            {
                poruka = $"Zakasnina: {zakasninsaDanEur * daniZakasnjenja}€ ({daniZakasnjenja} dana)";
            }
            else
            {
                poruka = "Nema zakasnine";
            }

            return poruka;
        }

        public static DateTime izracunRoka(DateTime posudba, int brProduzenja)
        {
            DateTime rok = posudba.AddDays((brProduzenja + 1) * danaJednaPosudba);

            return rok;
        }



        //Logiranje
        public static int LoginClan(string username, string password)
        {
            try
            {
                int idLogin = DataAcces.ClanLogin(username, password);
                if (idLogin == -1)
                {
                    MessageBox.Show("Krivo korisnicko ime ili lozinka");
                    return -1;
                }
                else
                {
                    return idLogin;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
                throw;
            }
        }

        public static int LoginKnjiznicar(string username, string password)
        {
            try
            {
                int idLogin = DataAcces.KnjiznicarLogin(username, username);
                if (idLogin == -1)
                {
                    MessageBox.Show("Krivo korisnicko ime ili lozinka");
                    return -1;
                }
                else
                {
                    return idLogin;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
                throw;
            }
        }

        //Dodavanje korisnika
        public static void dodajKorisnika(string username, string password, string ime, string prezime)
        {

            if (string.IsNullOrEmpty(username + password+ ime+prezime))
            {
                MessageBox.Show("Polje ne može biti prazno");
            }
            else if (username.Length>50 || password.Length>50|| ime.Length>50|| prezime.Length>50)
            {
                MessageBox.Show("Polje ne može duže od 50 znakova");
            }
            else
            {
                DataAcces.InsertClan(username, password, ime, prezime);
            }

        }


        //"name" stupaca dodaje u listi
        public static List<string> GetListColumnNames(DataGridView Grid)
        {
            List<string> temp = new List<string>();
            temp.Add("Katalog");
            foreach (DataGridViewColumn item in Grid.Columns)
            {
                temp.Add(item.Name);
            }

            return temp;
        }

        //Ispisuje autore na LV
        public static void ispisiAutoreLV(List<UlogaAutoriv2> uloge, ListView LV)
        {
            int i = 0;
            foreach (UlogaAutoriv2 item in uloge)
            {
                LV.Groups.Add(item.UlogaNaziv, item.UlogaNaziv).Tag = item.UlogaID;
                foreach (Autor atr in item.AutorIList)
                {
                    ListViewItem tempLVItem = new ListViewItem();
                    tempLVItem.Text = atr.AutorPrezimeIme;
                    tempLVItem.Tag = atr.AutorID;

                    LV.Groups[i].Items.Add(tempLVItem);
                    LV.Items.Add(tempLVItem);
                }
                i++;
            }
        }

        //search
        public static string FilterStringMaker(string searchKategorija, string searchTermin)
        {
            if (searchKategorija == "Katalog")
            {
                return string.Format($"Convert(knjigaID, 'System.String') like '%{searchTermin}%' OR [Naziv] like '%{searchTermin}%' OR [Autori] like '%{searchTermin}%' OR Convert([Godina], 'System.String') like '%{searchTermin}%' OR Convert([KnjigaID], 'System.String') like '%{searchTermin}%'");
            }
            else if (searchKategorija == "KnjigaID" || searchKategorija == "Godina")
            {
                return string.Format($"Convert([{searchKategorija}], 'System.String') like '%{searchTermin}%'");
            }
            else
            {
                return string.Format($"[{searchKategorija}] like '%{searchTermin}%'");
            }
        }

       
    }
}

