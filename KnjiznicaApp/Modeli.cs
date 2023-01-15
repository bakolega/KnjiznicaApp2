using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnjiznicaApp
{
    internal class Knjiga 
    {
        public int KnjigaID { get; set; }
        public string NazivPar { get; set; }
        public int? IzdavacIDPar { get; set; }
        public string ISBN10Par { get; set; }
        public string ISBN13Par { get; set; }
        public int? GodinaPar { get; set; }
        public int? MjestoIDPar { get; set; }
        public int? JezikIDPar { get; set; }

    }
    internal class KopijaKnjige
    {
        public int KopijaID { get; set; }
        public string Lokacija { get; set; }
    }
    internal class Uloga
    {
        public int UloagaID { get; set; }
        public string UlogaNaziv { get; set; }
        public override string ToString()
        {
            return UlogaNaziv;
        }
    }
    internal class UlogaAutori
    {
        public string UlogaNaziv { get; set; }
        public string Autori { get; set; }
    }
    internal class Informacije
    {
        public string Naziv { get; set; }
        public string Jezik { get; set; }
        public string Izdavac { get; set; }
        public string Mjesto { get; set; }
    }

    internal class Izdavac
    {
        public int IzdavacID { get; set; }
        public string Naziv { get; set; }
    }

    internal class Jezik
    {
        public int JezikID { get; set; }
        public string Naziv { get; set; }
    }
    internal class Mjesto
    {
        public int MjestoID { get; set; }
        public string Naziv { get; set; }
    }

    internal class ID
    {
        public int knjigaID { get; set; }
        
    }

    internal class Autor
    {

        public string AutorPrezimeIme { get; set; }
        public int AutorID { get; set; }

        public override string ToString()
        {
            return AutorPrezimeIme;
        }
    }
    internal class UlogaAutoriInsertHelper
    {
        public int KnjigaID { get; set; }
        public int AutorID { get; set; }
        public int Uloga { get; set; }

    }


    internal class UlogaAutoriv2
    {
        public UlogaAutoriv2(int ulogaID, string ulogaNaziv, string Autori)
        {
            UlogaID = ulogaID;
            UlogaNaziv = ulogaNaziv;
            
            List<Autor> tempAutori= new List<Autor>();

            string[] tempAutorID = Autori.Split(';');
            foreach (string str in tempAutorID)
            {
                string[] tempAutorSplit = str.Split(':');
                tempAutori.Add(new Autor { AutorPrezimeIme = tempAutorSplit[0].Trim(), AutorID = int.Parse(tempAutorSplit[1]) });
            }
            AutorIList = tempAutori;
        }

        public int UlogaID { get; set; }
        public string UlogaNaziv { get; set; }

        public List<Autor> AutorIList { get; set; }
        
    }

    internal class Lokacija
    {
        public int LokacijaID { get; set; }
        public string Naziv { get; set; }
    
    }


}
