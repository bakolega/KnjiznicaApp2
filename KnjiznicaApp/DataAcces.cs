using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace KnjiznicaApp
{
    internal class DataAcces
    {
        static public List<Knjiga> getKnjigeIspis()
        {
            //Using jer zatvara vezu
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                List<Knjiga> temp = connection.Query<Knjiga>("dbo.GetAllKnjigeForIspis").ToList();//
                return temp;
            }
            
        }

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
            //Using jer zatvara vezu
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                return connection.Query<Uloga>("dbo.GetUloge").ToList();
            }

        }
        static public List<UlogaAutori> GetAutorUlogeForKnjiga(int ID)
        {
            //Using jer zatvara vezu
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                return connection.Query<UlogaAutori>($"dbo.GetAllAutorUlogeForKnjiga @IDfor = {ID}").ToList();
            }

        }
        static public Informacije GetInformacije(int ID)
        {
            //Using jer zatvara vezu
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                return connection.Query<Informacije>($"dbo.GetInformacije @IDfor = {ID}").ToList().First();
            }

        }
        public static void InsertKnjiga(string naziv,int IzdavacIDpar, string autor, int godina) 
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                connection.Query($"dbo.InsertKnjiga @NazivPar='{naziv}',@IzdavacIDpar ={IzdavacIDpar},@GodinaPar={godina}");

                //@NazivPar varchar(255),
	            //@IzdavacIDPar int = null,
                //@ISBN10Par char = null,
                //@ISBN13Par char = null,
                //@GodinaPar int = null,
                //@MjestoIDPar int = null,
                //@JezikIDPar int = null
            }
        }

        static public List<Izdavaci> GetIzdavaci()
        {
            //Using jer zatvara vezu
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                return connection.Query<Izdavaci>("select IzdavacID, Naziv from Izdavac").ToList();
            }

        }
        static public void DeleteKnjiga(int ID)
        {
            //Using jer zatvara vezu
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Knjiznica")))
            {
                 connection.Query<Izdavaci>($"dbo.DeleteKnjiga @forID={ID}");
            }

        }
    }
}
 