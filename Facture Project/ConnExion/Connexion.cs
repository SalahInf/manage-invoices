using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facture_Project
{
    public  class Connexion
    {


        private string chaine = @"Data Source=WORKER-PC\SQLEXPRESS;Initial Catalog=FactureDb;Integrated Security=True";
        public static SqlConnection con = null;


        public Connexion()
        {
            con = new SqlConnection(chaine);

        }

        public static SqlConnection GetConexionDb()
        {
            if (con == null)
                new Connexion();

            return con;

        }





    }






}
