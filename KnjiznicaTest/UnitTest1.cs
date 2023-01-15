using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KnjiznicaApp;
using System.Security.Principal;

namespace KnjiznicaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIzracunZakansine1()
        {
            DateTime date= DateTime.Now.AddDays(-21);
            int produzenja = 0;

            string rezultat = DodatneMetode.ispisIzracunZakansine(date, produzenja);

            Assert.AreEqual("Nema zakasnine",rezultat);

            date = DateTime.Now.AddDays(-22);


            rezultat = DodatneMetode.ispisIzracunZakansine(date, produzenja);

            Assert.AreEqual("Nema zakasnine", rezultat);
        }

        [TestMethod]
        public void TestIzracunZakansine2()
        {
            DateTime date = DateTime.Today.AddDays(-22);
            int produzenja = 0;

            string rezultat = DodatneMetode.ispisIzracunZakansine(date, produzenja);

            Assert.AreEqual("Zakasnina: 0.1€ (1 dana)", rezultat);
        }

        [TestMethod]
        public void TestIzracunRoka()
        {
            DateTime date = new DateTime(2000,1,1);
            int produzenja = 0;

            DateTime rezultat = DodatneMetode.izracunRoka(date, produzenja);

            Assert.AreEqual(new DateTime(2000,1,22), rezultat);
        }

        [TestMethod]
        public void TestFilterStringMaker()
        {
            string searchKategorija = "Katalog";
            string searchTermin = "Test";

            string rezultat = DodatneMetode.FilterStringMaker(searchKategorija, searchTermin);

            string ocekivano = "Convert(knjigaID, 'System.String') like '%Test%' OR [Naziv] like '%Test%' OR [Autori] like '%Test%' OR Convert([Godina], 'System.String') like '%Test%' OR Convert([KnjigaID], 'System.String') like '%Test%'";
            Assert.AreEqual(ocekivano, rezultat);


            searchKategorija = "KnjigaID";

            rezultat = DodatneMetode.FilterStringMaker(searchKategorija, searchTermin);

            ocekivano = "Convert([KnjigaID], 'System.String') like '%Test%'";
            Assert.AreEqual(ocekivano, rezultat);


            searchKategorija = "Naziv";

            rezultat = DodatneMetode.FilterStringMaker(searchKategorija, searchTermin);

            ocekivano = "[Naziv] like '%Test%'";
            Assert.AreEqual(ocekivano, rezultat);

        }



    }
}
