using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facture_Project
{
    public class SosiétéDal
    {
        static SqlConnection con = Connexion.GetConexionDb();
       
        public static DataTable getData()
        {
            SqlCommand cmd = new SqlCommand("select  Ste,IdSte from Societe", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;

        }
        internal static Sosiété getSocieteById(int idSociete)
        {
            throw new NotImplementedException();
        }


        public void Save(Sosiété societe)
        {
            con.Close();


           
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Societe (Ste,Numero,Adresse) " +
                "VALUES (@Ste,@Numero,@Adresse)";

            
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@Ste", societe.NomSosiété);
            cmd.Parameters.AddWithValue("@Numero", societe.Numero);
            cmd.Parameters.AddWithValue("@Adresse", societe.Adresse);
        
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }



    }
}
