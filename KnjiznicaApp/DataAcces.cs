using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
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
                connection.Execute("dbo.deleteKnjiga_Autor @forID", IDs);
                connection.Execute("dbo.DeleteKnjiga @forID", IDs);
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
                idsToDelete.Add(new ID { forID = item.KnjigaID });
            }

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                connection.Execute("dbo.deleteKnjiga_Autor @forID", idsToDelete);
                connection.Execute("dbo.InsertKnjigaAutor @KnjigaID, @AutorID, @Uloga", input);
            }

        }
    }
}
 