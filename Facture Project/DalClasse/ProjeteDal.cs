using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facture_Project.DalClasse
{
    public class ProjeteDal
    {
        static SqlConnection con = Connexion.GetConexionDb();

        public static DataTable getData()
        {
            SqlCommand cmd = new SqlCommand("select * from Project", con);
            DataTable dt = new DataTable();

            con.Close(); con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;

        }

    }
}
