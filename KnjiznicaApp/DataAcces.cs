﻿using System;
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
                return connection.Query<Knjiga>("dbo.GetAllKnjigeForIspis").ToList();//
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
        public void insertKnjiga(string naziv, string autor, int godina) 
        {

        }
    }
}
 