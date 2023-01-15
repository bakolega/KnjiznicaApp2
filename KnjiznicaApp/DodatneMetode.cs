using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static bool loginClan(string username, string password)
        {

            return false;
        }
    }
}

