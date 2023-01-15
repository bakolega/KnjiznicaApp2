using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnjiznicaApp
{
    public class Knjiga 
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
    //internal class KopijaKnjige
    //{
    //    public int KopijaID { get; set; }
    //    public string Lokacija { get; set; }
    //}
    public class Uloga
    {
        public int UloagaID { get; set; }
        public string UlogaNaziv { get; set; }
        public override string ToString()
        {
            return UlogaNaziv;
        }
    }
    public class UlogaAutori
    {
        public string UlogaNaziv { get; set; }
        public string Autori { get; set; }
    }
    public class Informacije
    {
        public string Naziv { get; set; }
        public string Jezik { get; set; }
        public string Izdavac { get; set; }
        public string Mjesto { get; set; }
    }

    public class Izdavac
    {
        public int IzdavacID { get; set; }
        public string Naziv { get; set; }
    }

    public class Jezik
    {
        public int JezikID { get; set; }
        public string Naziv { get; set; }
    }
    public class Mjesto
    {
        public int MjestoID { get; set; }
        public string Naziv { get; set; }
    }

    public class ID
    {
        public int knjigaID { get; set; }
        
    }

    public class Autor
    {

        public string AutorPrezimeIme { get; set; }
        public int AutorID { get; set; }

        public override string ToString()
        {
            return AutorPrezimeIme;
        }
    }

    public class AutortoAdd
    {

        public string ime { get; set; }
        public string prezime { get; set; }

       
    }
    public class UlogaAutoriInsertHelper
    {
        public int KnjigaID { get; set; }
        public int AutorID { get; set; }
        public int Uloga { get; set; }

    }


    public class UlogaAutoriv2
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

    public class Lokacija
    {
        public int LokacijaID { get; set; }
        public string Naziv { get; set; }
    
    }


}
