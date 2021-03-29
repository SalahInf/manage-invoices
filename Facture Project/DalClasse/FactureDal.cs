
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Facture_Project
{
    public   class  FactureDal
    {
        static SqlConnection con = Connexion.GetConexionDb();

        
        FactureData facData = new FactureData();

        public static DataTable getData()
        {
            SqlCommand cmd = new SqlCommand("select SaveFac_Db.*, Fournisseur.NomFour from SaveFac_Db inner join Fournisseur on Fournisseur.IdFour= SaveFac_Db.IdFournisseur ", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
             
        }
        // select Order_Db.*, Client_Db.Name, Product_Db.PName from Order_Db inner join Client_Db on Order_Db.IdClient= Client_Db.IdClient inner join Product_Db on Order_Db.IdProduct= Product_Db.IdProduct
       
        public  FactureData  GetFactureById(string NumFacture)
        {

            con = Connexion.GetConexionDb();
            //ProductsSave pSD = new ProductsSave();
            SqlCommand cmd = new SqlCommand("select * from facture where NumFacture='" + NumFacture + "'", con);
            //con.Close();

            con.Open();

            //DataTable dt = new DataTable();
            FactureData f = new FactureData();
            SqlDataReader sdr = cmd.ExecuteReader();
            //dt.Load(sdr);
            if (sdr.Read())
            {
                f.NumFact= (sdr["NumFacture"].ToString());
               f.service = ServiceDal.getServiceById(f.service.IdService);
                //f.Societe = SosiétéDal.getSocieteById(f.Societe.IdSociete); 
                //p.LastName = (sdr["LasteName"].ToString());
                //p.NumPhone = (Convert.ToInt32(sdr["number"]));

            }
            con.Close();
            return f;
        }

        public void Get2RFactureById(DeuxRet ret,FactureData fdata)
        {

            
            con.Close();

            con = Connexion.GetConexionDb();
            //ProductsSave pSD = new ProductsSave();
            SqlCommand cmd = new SqlCommand("select * from Facture2Retour where IdFacture='" + fdata.IdFacture + "'", con);
            //con.Close();

            con.Open();

            //DataTable dt = new DataTable();
            //DeuxRet ff = new DeuxRet();
            SqlDataReader sdr = cmd.ExecuteReader();
            //dt.Load(sdr);
            if (sdr.Read())
            {

                //Get data From data base For specifie Variable  
                ret.Observation2r = (sdr["Observation"].ToString());
                ret.DtEnvService2r = (DateTime.Parse(sdr["EnvoiServiceDt"].ToString()));
                ret.ReceptionServiceDt2r = (DateTime.Parse(sdr["ReceptionServiceDt"].ToString()));
                ret.EnvoiComptaDt2r = (DateTime.Parse(sdr["EnvoiComptaDt"].ToString()));
               
                

               //f.service = ServiceDal.getServiceById(f.service.IdService);
                //f.Societe = SosiétéDal.getSocieteById(f.Societe.IdSociete); 

                //p.NumPhone = (Convert.ToInt32(sdr["number"]));

            }
            con.Close();
            
        }







        public void updateFacture(FactureData F, DeuxRet deuxRet)
        {

            con.Close();

            if (con.State == ConnectionState.Closed)
                con.Open();
            //SqlCommand cmd = new SqlCommand();
            //SqlTransaction transact = con.BeginTransaction();
            SqlTransaction transaction;

            SqlCommand cmd = con.CreateCommand();
            

            //Start a local transaction.
            transaction = con.BeginTransaction("SampleTransaction");

            // Must assign both transaction object and connection
            // to Command object for a pending local transaction
            cmd.Connection = con;
            cmd.Transaction = transaction;
           
            try
            {
                
                //cmd.CommandText ="INSERT INTO SaveFac_Db VALUES(@NumFact,@IdSte,@IdSce)";

                cmd = new SqlCommand("UPDATE SaveFac_Db SET NumFact = @NumFact, DateFact = @DateFact, MontFact = @MontFact, DateRecep = @DateRecep, " +
                    "IdSte = @IdSte, IdSce = @IdSce, IdProjet = @IdProjet, IdFournisseur = @IdFournisseur, DateEnvConc = @DateEnvConc, DateRetConc = @DateRetConc," +
                    " DateCompt = @DateCompt,Filepath = @Filepath, DeuxRetBool = @DeuxRetBool where FactId=@FactId", con);
             
                cmd.Parameters.AddWithValue("@FactId", F.IdFacture);

                cmd.Parameters.AddWithValue("@NumFact", F.NumFact);
                cmd.Parameters.AddWithValue("@DateFact", F.DateFact);
                cmd.Parameters.AddWithValue("@MontFact", F.MontFact);
                cmd.Parameters.AddWithValue("@DateRecep", F.DateRecep);
                cmd.Parameters.AddWithValue("@IdSte", F.Societe.IdSociete);
                cmd.Parameters.AddWithValue("@IdSce", F.service.IdService);
                cmd.Parameters.AddWithValue("@IdProjet", F.projet.IdProjet);
                cmd.Parameters.AddWithValue("@IdFournisseur", F.fournisseur.IdFournisseur);
                cmd.Parameters.AddWithValue("@DateEnvConc", F.DtEnvoiconcerne);
                cmd.Parameters.AddWithValue("@DateRetConc", F.DtRetconcerne);
                cmd.Parameters.AddWithValue("@DateCompt", F.DateenvoiCompt);
                cmd.Parameters.AddWithValue("@Filepath", F.FilePath);
                cmd.Parameters.AddWithValue("@DeuxRetBool", deuxRet.IsCheked);

                //cmd.ExecuteNonQuery();


                //facData.IdFacture = Convert.ToInt32(cmd.ExecuteScalar());
                if (deuxRet.IsCheked)
                {
                    SqlCommand cmd2 = con.CreateCommand();
                    

                    cmd2 = new SqlCommand("UPDATE  Facture2Retour SET EnvoiServiceDt=@EnvoiServiceDt,ReceptionServiceDt=@ReceptionServiceDt,EnvoiComptaDt=@EnvoiComptaDt,Observation=@Observation WHERE IdFacture=@IdFacture ", con);



                    cmd2.Connection = con;
                    cmd2.Parameters.AddWithValue("@ID", F.IdFacture);
                    cmd2.Parameters.AddWithValue("@IdFacture", F.IdFacture);
                    cmd2.Parameters.AddWithValue("@EnvoiServiceDt", deuxRet.DtEnvService2r);
                    cmd2.Parameters.AddWithValue("@ReceptionServiceDt", deuxRet.ReceptionServiceDt2r);
                    cmd2.Parameters.AddWithValue("@EnvoiComptaDt", deuxRet.EnvoiComptaDt2r);
                    cmd2.Parameters.AddWithValue("@Observation", deuxRet.Observation2r);

                    
                }

                cmd.Transaction = transaction;
                cmd.ExecuteNonQuery();

                transaction.Commit();
               
                MessageBox.Show("Facture Sauvgarder", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show(ex.Message);
            }

            con.Close();
        }




        
       



        public void saveFacture(FactureData F,DeuxRet deuxRet)
        {
            con.Close();

            if (con.State == ConnectionState.Closed)
                con.Open();
            //SqlCommand cmd = new SqlCommand();
            //SqlTransaction transact = con.BeginTransaction();


            SqlCommand cmd = con.CreateCommand();
            SqlTransaction transaction;

            // Start a local transaction.
            transaction = con.BeginTransaction("SampleTransaction");

            // Must assign both transaction object and connection
            // to Command object for a pending local transaction
            cmd.Connection = con;
            cmd.Transaction = transaction;

            try
            {
                
                //cmd.CommandText ="INSERT INTO SaveFac_Db VALUES(@NumFact,@IdSte,@IdSce)";
                
               cmd.CommandText = "INSERT INTO SaveFac_Db (NumFact,DateFact,MontFact,DateRecep,IdSte,IdSce,IdProjet,IdFournisseur,DateEnvConc,DateRetConc,DateCompt,Filepath,DeuxRetBool) " +
                "VALUES (@NumFact,@DateFact,@MontFact,@DateRecep,@IdSte,@IdSce,@IdProjet,@IdFournisseur,@DateEnvConc,@DateRetConc,@DateCompt,@Filepath,@DeuxRetBool)" + "SELECT SCOPE_IDENTITY()";
                // SqlDataAdapter SDA = new SqlDataAdapter(query, con);

                
                //cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@NumFact", F.NumFact);
                cmd.Parameters.AddWithValue("@DateFact",F.DateFact);
                cmd.Parameters.AddWithValue("@MontFact",F.MontFact);
                cmd.Parameters.AddWithValue("@DateRecep",F.DateRecep);         
                cmd.Parameters.AddWithValue("@IdSte", F.Societe.IdSociete);
                cmd.Parameters.AddWithValue("@IdSce", F.service.IdService);
                cmd.Parameters.AddWithValue("@IdProjet", F.projet.IdProjet);
                cmd.Parameters.AddWithValue("@IdFournisseur", F.fournisseur.IdFournisseur);
                //cmd.Parameters.AddWithValue("@DateEnvConc", F.DtEnvoiconcerne);
                // cmd.Parameters.AddWithValue("@DateRetConc", F.DtRetconcerne);
                //cmd.Parameters.AddWithValue("@DateCompt", F.DateenvoiCompt);
                cmd.Parameters.AddWithValue("@Filepath", F.FilePath);
                cmd.Parameters.AddWithValue("@DeuxRetBool", deuxRet.IsCheked);




                if (F.DtEnvoiconcerne == DateTime.MinValue)
                {
                    cmd.Parameters.AddWithValue("@DateEnvConc", DBNull.Value);
                    //cmd.Parameters.AddWithValue("@DateEnvConc", F.DtEnvoiconcerne).Value = null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DateEnvConc", F.DtEnvoiconcerne);
                }

                if (F.DtRetconcerne == DateTime.MinValue)
                {

                    cmd.Parameters.AddWithValue("@DateRetConc", DBNull.Value);
                    // cmd.Parameters.AddWithValue("@DateRetConc", F.DtRetconcerne).Value = null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DateRetConc", F.DtRetconcerne);
                }

                if (F.DateenvoiCompt == DateTime.MinValue)
                {

                    cmd.Parameters.AddWithValue("@DateCompt", DBNull.Value);
                    //cmd.Parameters.AddWithValue("@DateCompt", F.DateenvoiCompt).Value = null;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@DateCompt", F.DateenvoiCompt);
                }

                //Id2Ret




                if (deuxRet.IsCheked)
                {
                    facData.IdFacture = Convert.ToInt32(cmd.ExecuteScalar().ToString());

                    //SqlCommand cmd = con.CreateCommand();

                    cmd.CommandText = "INSERT INTO Facture2Retour (IdFacture,EnvoiServiceDt,ReceptionServiceDt,EnvoiComptaDt,Observation) " +
                        "VALUES (@IdFacture,@EnvoiServiceDt,@ReceptionServiceDt,@EnvoiComptaDt,@Observation)";

                    

                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@IdFacture", facData.IdFacture);
                    cmd.Parameters.AddWithValue("@EnvoiServiceDt", deuxRet.DtEnvService2r);
                    cmd.Parameters.AddWithValue("@ReceptionServiceDt", deuxRet.ReceptionServiceDt2r);
                    cmd.Parameters.AddWithValue("@EnvoiComptaDt", deuxRet.EnvoiComptaDt2r);
                    cmd.Parameters.AddWithValue("@Observation", deuxRet.Observation2r);

                    
                   


                   //cmd.ExecuteNonQuery();

                }
 
                cmd.ExecuteNonQuery();


                
                transaction.Commit();
                MessageBox.Show("Nouveau Client Sauvgarder", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                 MessageBox.Show(ex.ToString());
            }

            con.Close();


        }

        //check if The Id is alredy exist In data Base
        public void CheckId(FactureData F, DeuxRet deuxRet)
        {
            con.Close();
            using (var cmd = new SqlCommand("select 1 from SaveFac_Db where FactId='" + F.IdFacture + "'", con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("@FactId", F.IdFacture);
                using (var dr = cmd.ExecuteReader())
                {

                    if (dr.HasRows)
                    {
                        con.Close();
                         updateFacture(F, deuxRet);
                       
                        //UpdateNew(F, deuxRet);
                        MessageBox.Show("Les Cordoner ", " UPdated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        con.Close();
                        saveFacture(F,deuxRet);
                        MessageBox.Show("Nouveau Facture", "sauvgarder ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
        }
       


       


































        //public void savePersonne(FactureData F)
        //{
        //    con.Open();
        //    string query = "INSERT INTO SaveFac_Db(NumFact,DateFact,MontFact,DateRecep,IdSte,IdSce,DateEnv,DateRet,DateCompt,Factannul,Dateannul,CodeProject,Fact2retour) VALUES " +
        //        "('" + F.NumFact + "','" + F.DateFact + "','" + F.MontFact + "','" + F.DateRecep + "','" + F.Societe.IdSociete + "','" + F.service.IdService + "','" + F.EnvoiComptaDt + "','" + F.DateRet + "','" + F.DateCompt + "','" + F.Factannul + "','" + F.Dateannul + "','" + F.CodeProject + "','" + F.Fact2retour + "')";
        //    SqlDataAdapter SDA = new SqlDataAdapter(query, con);
        //    SDA.SelectCommand.ExecuteNonQuery();
        //    con.Close();
        //}

        //@NumFact,@DateFact,@MontFact,@DateRecep,@IdSte,@IdSce,@DateEnv,@DateRet,@DateCompt,@Factannul,@Dateannul,@CodeProject,@Fact2retour


    }
        
    
}
