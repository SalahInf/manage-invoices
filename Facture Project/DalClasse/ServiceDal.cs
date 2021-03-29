
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facture_Project
{
    public class ServiceDal
    {
        static SqlConnection con = Connexion.GetConexionDb();
        

        public static DataTable getData()
        {
            SqlCommand cmd = new SqlCommand("select * from Service", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;

        }


        //Get the Id from Database
        internal static Service getServiceById(int idService)
        {
            SqlCommand cmd = new SqlCommand("select * from Service where IdSce=" + idService + "", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            
            Service service = new Service();

            if (dt.Rows.Count > 0)
            {
                service.IdService = idService;
                service.NomService = dt.Rows[0]["sce"].ToString();
            }
            con.Close();
            return service ;
        }
        public void Save(Service ser)
        {
            con.Close();



            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Service (sce,Numero,Adresse) " +
                "VALUES (@sce,@Numero,@Adresse)";


            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@sce", ser.NomService);
            cmd.Parameters.AddWithValue("@Numero", ser.Numero);
            cmd.Parameters.AddWithValue("@Adresse", ser.Adresse);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
