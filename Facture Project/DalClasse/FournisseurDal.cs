using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facture_Project
{
    public class FournisseurDal
    {

        static SqlConnection con = Connexion.GetConexionDb();
        Fournisseur fournisseur = new Fournisseur();

        public static DataTable getData()
        {
            SqlCommand cmd = new SqlCommand("select * from Fournisseur", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;

        }



        public void Save(Fournisseur fournisseur)
        {
            con.Close();



            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Fournisseur (NomFour,NumFour,AdresseFour) " +
                "VALUES (@NomFour,@NumFour,@AdresseFour)";


            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@NomFour", fournisseur.NomFour);
            cmd.Parameters.AddWithValue("@NumFour", fournisseur.NumFour);
            cmd.Parameters.AddWithValue("@AdresseFour", fournisseur.AdresseFournisseur);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


        }
       
    }
}
