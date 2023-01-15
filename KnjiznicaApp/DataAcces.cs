using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace KnjiznicaApp
{
    internal class DataAcces
    {


        static public List<Autor> GetAutorPrezimeIme()
        {
            //Using jer zatvara vezu
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                return connection.Query<Autor>("dbo.GetAutorPrezimeIme").ToList();
            }

        }
        static public List<Uloga> GetUloge()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                return connection.Query<Uloga>("dbo.GetUloge").ToList();
            }

        }
        static public List<UlogaAutori> GetAutorUlogeForKnjiga(int ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                return connection.Query<UlogaAutori>($"dbo.GetAllAutorUlogeForKnjiga @IDfor = {ID}").ToList();
            }

        }
        static public Informacije GetInformacije(int ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                return connection.Query<Informacije>($"dbo.GetInformacije @IDfor = {ID}").ToList().First();
            }

        }

        static public List<Lokacija> GetLokacije()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                return connection.Query<Lokacija>("Select * from Lokacija").ToList();
            }

        }



        static public int GetRezerviarniClan(int kopijaID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                return connection.Query<int>($"select ClanID from Rezervacija  where Rezervacija.KopijaID = {kopijaID}").ToList().First();
            }

        }

        static public int GetCurrentPosudbaForKopija(int kopijaID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                return connection.Query<int>($"dbo.GetCurrentPosudbaForKopija @kopijaID = {kopijaID}").ToList().First();
            }

        }
        public static void InsertKnjiga(string naziv,int? izdavacID , int? godina,int? mjestoID ,int? JezikID) 
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                Knjiga knjigaToAdd = new Knjiga { NazivPar = naziv, IzdavacIDPar = izdavacID, ISBN10Par=null,ISBN13Par=null, GodinaPar = godina, MjestoIDPar = mjestoID, JezikIDPar = JezikID };
                

                connection.Execute("dbo.InsertKnjiga @NazivPar, @IzdavacIDpar, @ISBN10Par, @ISBN13Par, @GodinaPar, @MjestoIDPar, @JezikIDpar" , knjigaToAdd);
                
                
                //@NazivPar varchar(255),
                //@IzdavacIDPar int = null,
                //@ISBN10Par char = null,
                //@ISBN13Par char = null,
                //@GodinaPar int = null,
                //@MjestoIDPar int = null,
                //@JezikIDPar int = null 

                //connection.Execute("dbo.InsertKnjigaAutor @KnjigaID, @AutorID, @Uloga", );

            }
        }

        static public List<Izdavac> GetIzdavaci()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                return connection.Query<Izdavac>("select IzdavacID, Naziv from Izdavac").ToList();
            }

        }
        static public void DeleteKnjiga(int ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                 connection.Query($"dbo.DeleteKnjiga @forID={ID}");
            }

        }
        static public void DeleteKnjige(List<ID> IDs)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                connection.Execute("dbo.DeleteKopijeForknjiga @knjigaID", IDs);
                connection.Execute("dbo.DeletePosudbeForKnjiga @knjigaID", IDs);
                connection.Execute("dbo.DeleteRezervacijeForKnjiga @knjigaID", IDs);
                connection.Execute("dbo.deleteKnjiga_Autor @knjigaID", IDs);
                connection.Execute("dbo.DeleteKnjiga @knjigaID", IDs);
            }

        }

        static public List<Jezik> GetJezike()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                return connection.Query<Jezik>("select JezikID, Jezik as Naziv from jezik").ToList();
            }
        }
        static public List<Mjesto> GetMjesta()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                return connection.Query<Mjesto>("select * from MjestoIzdavanja").ToList(); //MjestoID, Naziv
            }

        }

        static public List<UlogaAutoriv2> GetAutorUlogeForKnjigav2(int ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                 return connection.Query<UlogaAutoriv2>($"dbo.GetUlogeAutoriForKnjigav2 @IDfor = {ID}").ToList();
          
            }

        }

        static public void InsertKnjigaAutorUloga(List<UlogaAutoriInsertHelper> input)
        {
            List<ID> idsToDelete = new List<ID>();
            foreach (UlogaAutoriInsertHelper item in input)
            {
                idsToDelete.Add(new ID { knjigaID = item.KnjigaID });
            }

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                connection.Execute("dbo.deleteKnjiga_Autor @knjigaID", idsToDelete);
                connection.Execute("dbo.InsertKnjigaAutor @KnjigaID, @AutorID, @Uloga", input);
            }

        }
        static public void DeleteKnjigaAutorUloga(ID idsToDelete)
        {
            
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                connection.Execute("dbo.deleteKnjiga_Autor @knjigaID", idsToDelete);
               
            }

        }
        static public void DeleteRezervacijaForKopija(int kopijaID, int clanID)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                connection.Query($"dbo.DeleteRezervacijaForKopijaClan @kopijaID={kopijaID}, @clanID={clanID}");

            }

        }

        //static public List<KopijaKnjige> GetKopije (int ID)
        //{
            
        //                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Knjiznica")))
        //                {
        //                    return connection.Query<KopijaKnjige>($"dbo.GetKopije @ID = {ID}").ToList();

        //                }
          
        //}

        static public DataTable GetKopije2(int ID, int clanID)
        {
                //Za id vraca sve kopije tog izdanja: ID, Lokacija; 1:Dostupno / 0:Nedostupno/ -1:ovaj clan vec rezervirao / -2: ovaj clan vec posudio
                using (SqlConnection conn = new SqlConnection(Helper.CnnVal("Knjiznica")))
            { 
                SqlDataAdapter adp = new SqlDataAdapter($"dbo.GetKopije @ID = {ID}, @IDclana = {clanID}", conn);
                DataTable data = new DataTable();
                adp.Fill(data);
    
                return data;
            }
        }
        
        static public DataTable GetKopijeKnjiznicar(int ID)
        {
            //Za id vraca sve kopije tog izdanja: ID, Lokacija; 1:Dostupno / 0:Posuđeno/ -1:Rezervirano
            using (SqlConnection conn = new SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                SqlDataAdapter adp = new SqlDataAdapter($"dbo.GetKopijeKnjiznicar @ID = {ID}", conn);
                DataTable data = new DataTable();
                adp.Fill(data);

                return data;
            }
        }

        static public int ClanLogin(string username, string lozinka)
        {
            //Za username i lozinku vraca ID korisnika ili -1 ako ne postoji/krivo

            if (username == "" || lozinka == "")
                return -1;
        

            using (SqlConnection conn = new SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                
                SqlDataAdapter adp = new SqlDataAdapter($"dbo.LoginClan @User={username}, @Loz = {lozinka}", conn);
                DataTable data = new DataTable();

                
                adp.Fill(data);

                if(data.Rows.Count == 0)
                {
                    return -1;
                }
                else
                {
                    return (int)data.Rows[0][0];
                }


            }

        }

        static public int KnjiznicarLogin(string username, string lozinka)
        {
            //Za username i lozinku vraca ID korisnika ili -1 ako ne postoji/krivo

            if (username == "" || lozinka == "")
                return -1;


            using (SqlConnection conn = new SqlConnection(Helper.CnnVal("Knjiznica")))
            {

                SqlDataAdapter adp = new SqlDataAdapter($"dbo.LoginKnji @User={username}, @Loz = {lozinka}", conn);
                DataTable data = new DataTable();

                adp.Fill(data);

                if (data.Rows.Count == 0)
                {
                    return -1;
                }
                else
                {
                    return (int)data.Rows[0][0];
                }


            }

        }

        static public void InsertRezervacija(int kopijaID, int clanID)
        {
           
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                connection.Query($"dbo.InsertRezervacija @kopijaID = {kopijaID}, @clanID ={clanID}");
            }

        }

        static public void InsertPosudba(int kopijaID, int clanID, int knjiznicarID)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                connection.Query($"dbo.InsertPosudba @kopijaID = {kopijaID}, @clanID ={clanID}, @knjiznicarID={knjiznicarID}");
            }

        }
        static public void InsertAutor(string ime,string prezime)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                connection.Query($"dbo.InsertAutor @ime ='{ime}', @prezime ='{prezime}'");
            }

        }
        static public void InsertUloga(string nazivUloge)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                connection.Query($"dbo.InsertUloga @NazivUloge ='{nazivUloge}'");
            }

        }
        static public void InsertMjesto(string mjestoNaziv)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                connection.Query($"dbo.InsertMjesto @MjestoNaziv ='{mjestoNaziv}'");
            }

        }
        static public void InsertJezik(string jezikNaziv)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                connection.Query($"dbo.InsertJezik @jezikNaziv ='{jezikNaziv}'");
            }

        }

        static public void InsertIzdavac(string izdavacNaziv)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                connection.Query($"dbo.InsertIzdavac @izdavacNaziv ='{izdavacNaziv}'");
            }

        }

        static public void InsertKopija(int kopijaID,int lokacijaID)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                connection.Query($"dbo.InsertKopija @knjigaID ='{kopijaID}', @lokacijaID={lokacijaID}");
            }

        }

        static public void InsertClan(string username,string lozinka,string ime,string prezime)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                connection.Query($"dbo.InsertClan @username='{username}', @password='{lozinka}', @ime='{ime}', @prezime='{prezime}'");

            }

        }

        static public void UpdatePovratakPosudbe(int posudbaID)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                connection.Query($"dbo.UpdatePovratakPosudbe @PosudbaID={posudbaID}");
            }

        }



        static public DataTable GetPosudeno(int clanID)
        {

            using(SqlConnection conn = new SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                SqlDataAdapter adp = new SqlDataAdapter($"dbo.GetPosudeno @clanID = {clanID}", conn);
                DataTable data = new DataTable();
                adp.Fill(data);

                return data;
            }

        }
        static public DataTable GetPosudbaZakasnjenje(int posudbaID)
        {

            using (SqlConnection conn = new SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                SqlDataAdapter adp = new SqlDataAdapter($"select Dat_Posudbe, Br_Produzenja from posudba where Posudba.PosudbaID = {posudbaID}", conn);
                DataTable data = new DataTable();
                adp.Fill(data);
                return data;
            }

        }
        static public DataTable GetAllClan()
        {

            using (SqlConnection conn = new SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                SqlDataAdapter adp = new SqlDataAdapter($"dbo.GetAllClan", conn);
                DataTable data = new DataTable();
                adp.Fill(data);

                return data;
            }

        }


        static public void UpdateBrProduzenja(int posudbaID,int brProduzenja)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                connection.Query($"dbo.UpdateBrProduzenja @BrProduzenja = {brProduzenja}, @PosudbaID= {posudbaID}");
            }

        }

        static public DataTable GetRezervacije(int clanID)
        {

            using (SqlConnection conn = new SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                SqlDataAdapter adp = new SqlDataAdapter($"dbo.GetRezervacije @clanID = {clanID}", conn);
                DataTable data = new DataTable();
                adp.Fill(data);

                return data;
            }

        }

        

        static public void DeleteRezervacija(int idRezervacije)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                connection.Query($"dbo.DeleteRezervacija @forID={idRezervacije}");

            }

        }
        static public DataTable GetAllKnjige()
        {

            using (SqlConnection conn = new SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                SqlDataAdapter adp = new SqlDataAdapter("dbo.GetAllKnjigeForIspis", conn);
                DataTable data = new DataTable();
                adp.Fill(data);

                return data;
            }

        }

        static public DataTable GetAllClanovi()
        {

            using (SqlConnection conn = new SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                SqlDataAdapter adp = new SqlDataAdapter("select ClanID,Username,Ime, Prezime from Clan", conn);
                DataTable data = new DataTable();
                adp.Fill(data);

                return data;
            }

        }


    }
}
 