using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facture_Project
{
    public class DeuxRetDal
    {
        static SqlConnection con = Connexion.GetConexionDb();


        public FactureData Get2rById(int id2r)
        {

            con = Connexion.GetConexionDb();
            //ProductsSave pSD = new ProductsSave();
            SqlCommand cmd = new SqlCommand("select * from Facture2Retour where IdFacture='" + id2r + "'", con);
            //con.Close();

            con.Open();

            //DataTable dt = new DataTable();
            FactureData f = new FactureData();
            SqlDataReader sdr = cmd.ExecuteReader();
            //dt.Load(sdr);
            if (sdr.Read())
            {
                f.id2retour = (Convert.ToInt32(sdr["IdFact2r"]));
                // f.service = ServiceDal.getServiceById(f.service.IdService);
                //f.Societe = SosiétéDal.getSocieteById(f.Societe.IdSociete); 
                //p.LastName = (sdr["LasteName"].ToString());
                //p.NumPhone = (Convert.ToInt32(sdr["number"]));

            }
            con.Close();
            return f;
        }


    }
}
