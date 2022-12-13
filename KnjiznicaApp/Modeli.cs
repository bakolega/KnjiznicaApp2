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
        public string Naziv { get; set; }
        public string Autori { get; set; }
        public string Prevoditelji { get; set; }
        public int Godina { get; set; }
        public string MjestoIzdavanja { get; set; }
        public string Izdavac { get; set; }
        
        //public string Display
        //{
        //    get
        //    {
        //        return $"{Naziv} aaaa {Autor} {Godina}";
        //    }
        //}
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
    internal class Uloga
    {
        public int UloagaID { get; set; }
        public string UlogaNaziv { get; set; }
      
    }
    internal class UlogaAutori
    {
        public string UlogaNaziv { get; set; }
        public string Autori { get; set; }
    }
    internal class Informacije
    {
        public string Jezik { get; set; }
        public string Izdavac { get; set; }
        public string Mjesto { get; set; }
    }

    internal class Izdavaci
    {
        public string IzdavacID { get; set; }
        public string Naziv { get; set; }
    }

}
