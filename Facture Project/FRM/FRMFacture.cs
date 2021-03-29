using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Facture_Project.DalClasse;
using Facture_Project;
using DevExpress.XtraEditors.Controls;
using System.IO;
using Facture_Project.FRM;

namespace WindowsFormsApp1
{
    public partial class FRMFacture : XtraForm
    {

        FactureData FData = new FactureData();
        FactureDal Fdal = new FactureDal();
        //Sosiété Sos = new Sosiété();
        //Fournisseur Four = new Fournisseur();
        DeuxRet deuxRet = new DeuxRet();
        DeuxRetDal DeuxretDal = new DeuxRetDal();
        string x = "10";


        public FRMFacture()
        {
            InitializeComponent();
            //GCfactures.Enabled = false;
            //BtADD.Enabled = false;
            //
            GRCdeuxRetour.Enabled = false;
            DTretConce.Enabled = false;
            DtComp.Enabled = false;
            DTenvConce.Enabled = false;

            DTenvserviceDeux.Enabled = false;
            DTrésepServdeux.Enabled = false;
            DTenvCoptadeux.Enabled = false;

  
            DtFacture.Text =  DateTime.Now.ToString ("dd/MM/yyyy");
            DtReseption.Text= DateTime.Now.ToString("dd/MM/yyyy");
            LoadDate();
        }
        public FRMFacture(DataRow Dv,DeuxRet ret)
        {
            InitializeComponent();
            ShowData(Dv);
        }


        //int ID;
        private void ShowData(DataRow Dv)
        {
           
           

            LoadDate();
            FData.IdFacture = Convert.ToInt32(Dv["FactId"]);
            TxtNumFact.Text = Dv["NumFact"].ToString();
            TxtMontan.Text = Dv["MontFact"].ToString();
            LUEService.EditValue = Dv["IdSce"].ToString();
             LUEProjet.EditValue = Dv["IdProjet"].ToString();
            LUESosiété.EditValue = Dv["IdSte"].ToString();
            LUEFournisseur.EditValue = Dv["IdFournisseur"].ToString();
            DtFacture.Text= Dv["DateFact"].ToString();
            DtReseption.Text = Dv["DateRecep"].ToString();
            DtComp.Text = Dv["DateCompt"].ToString();
            DTenvConce.Text = Dv["DateEnvConc"].ToString();
            DTretConce.Text = Dv["DateRetConc"].ToString();
            FData.FilePath = Dv["Filepath"].ToString();
            lbPathTosave.Text= Dv["Filepath"].ToString();

            deuxRet.IsCheked = Convert.ToBoolean(Dv["DeuxRetBool"]);



               if(deuxRet.IsCheked)
               {
                Fdal.Get2RFactureById(deuxRet, FData);
                if(deuxRet.Observation2r != null)
                TxtObservation.Text = deuxRet.Observation2r.ToString();
                
                DTenvserviceDeux.Text = deuxRet.DtEnvService2r.ToString("dd/MM/yyyy");
                DTrésepServdeux.Text = deuxRet.ReceptionServiceDt2r.ToString("dd/MM/yyyy");
                DTenvCoptadeux.Text = deuxRet.EnvoiComptaDt2r.ToString("dd/MM/yyyy");

                CkdeuxiemeRet.Checked = true;
               }else
               {
                CkdeuxiemeRet.Checked = false;
                GRCdeuxRetour.Enabled = false;
                //CkdeuxiemeRet.Checked = false;
               }




            if (!string.IsNullOrEmpty(DtComp.Text))
            {
                CKdtCompDT.Checked = true;
            }

            if (!string.IsNullOrEmpty(DTenvConce.Text))
            {
                CkDtEnvoiConca.Checked = true;
            }

            if (!string.IsNullOrEmpty(DTretConce.Text))
            {
                CKDtretconca.Checked = true;
            }


            //Deuxret
            if(!string.IsNullOrEmpty(DTenvCoptadeux.Text))
            {
                CKenvoiComp.Checked = true;
            }

            if(!string.IsNullOrEmpty(DTenvCoptadeux.Text))
            {
                CKenvoiComp.Checked = true;
            }
            if (!string.IsNullOrEmpty(DTenvserviceDeux.Text))
            {
                CkEnvService.Checked = true;
            }
            if (!string.IsNullOrEmpty(DTrésepServdeux.Text))
            {
                CkResService.Checked = true;
            }

            
        }
        DataTable dt = new DataTable();
        private void LoadDate()
        {

            
            

            // Load data to SERVICE Lookupedit 
            DataTable DtService = ServiceDal.getData();
            LUEService.Properties.DataSource = DtService;

       

            LUEService.Properties.Columns.Add(new LookUpColumnInfo("sce", "Service"));
            //if (LUEService.EditValue != null)
                
             LUEService.Properties.DisplayMember = "sce";
             
            LUEService.Properties.ValueMember = "IdSce";

            // Load data to Société Lookupedit
            DataTable DtSocieté = SosiétéDal.getData();
            LUESosiété.Properties.DataSource = DtSocieté;
            LUESosiété.Properties.Columns.Add(new LookUpColumnInfo("Ste", "Société"));
            LUESosiété.Properties.DisplayMember = "Ste";
            LUESosiété.Properties.ValueMember = "IdSte";

            // Load data to Projet Lookupedit
            DataTable DtProjet = ProjeteDal.getData();
            LUEProjet.Properties.DataSource = DtProjet;
            LUEProjet.Properties.Columns.Add(new LookUpColumnInfo("NomProjet", "Projet"));        
            LUEProjet.Properties.DisplayMember = "NomProjet";
            LUEProjet.Properties.ValueMember = "Idproject";
            // Load data to Fournisseur Lookupedit
            DataTable DtFournisseur = FournisseurDal.getData();
            LUEFournisseur.Properties.DataSource = DtFournisseur;
            LUEFournisseur.Properties.DisplayMember = "NomFour";
            LUEFournisseur.Properties.ValueMember = "IdFour";
            LUEFournisseur.Properties.Columns.Add(new LookUpColumnInfo("NomFour", "Nom Fournisseur"));
            LUEFournisseur.Properties.Columns.Add(new LookUpColumnInfo("NumFour", "Numero fournisseur"));

            
        }

        //private void ActivateADD_CheckedChanged(object sender, EventArgs e)
        //{

            //if(ActivateADD.Checked)
            //{
                
                //GCfactures.Enabled = true;
                //BtADD.Enabled = true;
                //MessageBox.Show("true", "true", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
                //GCfactures.Enabled = false;
                //BtADD.Enabled = false;
                //MessageBox.Show("false", "false", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
           

        //}

        private void CkdeuxiemeRet_CheckedChanged(object sender, EventArgs e)
        {

            GRCdeuxRetour.Enabled = CkdeuxiemeRet.Checked;
            deuxRet.IsCheked = CkdeuxiemeRet.Checked;

            if(!CkdeuxiemeRet.Checked)
            {

                DTenvserviceDeux.Text = "";
                DTrésepServdeux.Text = "";
                CKenvoiComp.Text = "";
                deuxRet.IsCheked = false;
            }



        }

        private void EvCompDT_CheckedChanged(object sender, EventArgs e)
        {

            DtComp.Enabled = CKdtCompDT.Checked;

            if (CKdtCompDT.Checked)
            {

                //DtComp.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }
            else
            {
                DtComp.Text = "";
            }
        }

        private void CkDtEnvoiConca_CheckedChanged(object sender, EventArgs e)
        {

            DTenvConce.Enabled = CkDtEnvoiConca.Checked;

            if (CkDtEnvoiConca.Checked)
            {

                //DTenvConce.Text = DateTime.Now.ToString("dd/MM/yyyy");

            }
            else
            {
                DTenvConce.Text = "";
            }
        }

      

        private void CKDtretconca_CheckedChanged(object sender, EventArgs e)
        {


            DTretConce.Enabled = CKDtretconca.Checked;

            if (CKDtretconca.Checked)
            {

                //DTretConce.Text = DateTime.Now.ToString("dd/MM/yyyy");

            }
            else
            {
                DTretConce.Text = "";
            }
        }

        private void CkEnvService_CheckedChanged(object sender, EventArgs e)
        {
            DTenvserviceDeux.Enabled = CkEnvService.Checked;
            if (CkEnvService.Checked)
            {
                //DTenvserviceDeux.Text = DateTime.Now.ToString("dd/MM/yyyy");

            }
            else
            {
                DTenvserviceDeux.Text = "";


            }

        }

        private void CkResService_CheckedChanged(object sender, EventArgs e)
        {
            DTrésepServdeux.Enabled = CkResService.Checked;
            if (CkResService.Checked)
            {

                //DTrésepServdeux.Text = DateTime.Now.ToString("dd/MM/yyyy");

            }
            else
            {
                DTrésepServdeux.Text = "";


            }

        }

        private void CKenvoiComp_CheckedChanged(object sender, EventArgs e)
        {
            DTenvCoptadeux.Enabled = CKenvoiComp.Checked;


            if (CKenvoiComp.Checked)
            {
                //DTenvCoptadeux.Text = DateTime.Now.ToString("dd/MM/yyyy");

            }
            else
            {
                DTenvCoptadeux.Text = "";

            }

        }

        private void BtSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            //check if is all redy to save and not empty

            if (TxtMontan.Text == "")
            {
                TxtMontan.BackColor = Color.Red;
            }
            else
            {
                TxtMontan.BackColor = Color.White;
            }

            if (TxtNumFact.Text == "")
            {
                TxtNumFact.BackColor = Color.Red;
            }
            else
            {
                TxtNumFact.BackColor = Color.White;
            }

            if (DtFacture.DateTime == DateTime.MinValue)
            {
                DtFacture.BackColor = Color.Red;
            }
            else
            {
                DtFacture.BackColor = Color.White;
            }

            if (DtReseption.DateTime == DateTime.MinValue)
            {
                DtReseption.BackColor = Color.Red;
            }
            else
            {
                DtReseption.BackColor = Color.White;
            }

            if (LUEFournisseur.EditValue == null)
            {
                LUEFournisseur.BackColor = Color.Red;
            }
            else
            {
                LUEFournisseur.BackColor = Color.White;
            }

            if (LUESosiété.EditValue == null)
            {
                LUESosiété.BackColor = Color.Red;
            }
            else
            {
                LUESosiété.BackColor = Color.White;
            }

            if (LUEProjet.EditValue == null)
            {
                LUEProjet.BackColor = Color.Red;
            }
            else
            {
                LUEProjet.BackColor = Color.White;
            }

            

            if (TxtMontan.Text == "" || TxtNumFact.Text == "" || DtReseption.Text == "" || DtFacture.Text == ""|| LUESosiété.EditValue == null || LUESosiété.EditValue == null || LUEProjet.EditValue == null)
                return;


            FData.IdFacture = FData.IdFacture;
            FData.NumFact = TxtNumFact.Text;
            //if(DtFacture.Text!= "")           
             FData.DateFact = DateTime.Parse(DtFacture.Text);
            //if (TxtMontan.Text != "")
            FData.MontFact = float.Parse(TxtMontan.Text);
           

            if (DtReseption.DateTime != DateTime .MinValue)
            FData.DateRecep = DateTime.Parse(DtReseption.Text);
             if (DtComp.DateTime!= DateTime .MinValue)           
            FData.DateenvoiCompt = DateTime.Parse(DtComp.Text);



            if (DTretConce.DateTime != DateTime.MinValue)
                FData.DtRetconcerne = DateTime.Parse(DTretConce.Text);
            if (DTenvConce.DateTime != DateTime .MinValue)
            FData.DtEnvoiconcerne = DateTime.Parse(DTenvConce.Text);


            if(TxtMontan.Text == "")
            {
                TxtMontan.BackColor = Color.Red;

            }


           
            deuxRet.IsCheked = CkdeuxiemeRet.Checked;

            if (deuxRet.IsCheked)
            {



                if (DTenvserviceDeux.DateTime != DateTime.MinValue)
                deuxRet.DtEnvService2r = DateTime.Parse(DTenvserviceDeux.Text);
               if (DTrésepServdeux.DateTime != DateTime.MinValue)
                    deuxRet.ReceptionServiceDt2r = DateTime.Parse(DTrésepServdeux.Text);
                if (DTenvCoptadeux.DateTime !=DateTime.MinValue)
                deuxRet.EnvoiComptaDt2r = DateTime.Parse(DTenvCoptadeux.Text);

                deuxRet.Observation2r = TxtObservation.Text;
            }
            
            
           
            //Get the Id from the lockupedit and save it in the oBject Service 
            FData.service = new Service { IdService = Convert.ToInt32(LUEService.EditValue) };


            FData.projet = new Projete { IdProjet = Convert.ToInt32(LUEProjet.EditValue) };

            FData.fournisseur = new Fournisseur { IdFournisseur = Convert.ToInt32(LUEFournisseur.EditValue) };

            FData.Societe = new Sosiété { IdSociete = Convert.ToInt32(LUESosiété.EditValue) };
            
           // Fdal.saveFacture(FData,deuxRet);
            Fdal.CheckId(FData, deuxRet);



            //this cause going to the base ang back , do a lot of work you can do this instad do the same work but dont cause the go and back from the base.
            //>>>>>// FData.service =ServiceDal .getServiceById(Convert.ToInt32(LUEService.EditValue)) ;
            //you can do this instad
            // this way create new empty object and add to it juste the spesific values you want fro the lookupedit. 

           
            

            


        }




        private void LUESosiété_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            // dt.Rows.Add(Sos.NomSosiété);
            //Sos.IdSociete = Convert.ToInt32(LUESosiété.Properties.DisplayMember);
           
            //XtraMessageBox.Show(LUESosiété.EditValue.ToString());
        }

        private void BtClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void BtEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            DeuxretDal.Get2rById(FData.IdFacture);


        }

        private void BtDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {           
            
            
        }

 
      

        private void BtPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void LUEService_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void CkDtEnvoiConca_MouseClick(object sender, MouseEventArgs e)
        {
            DTenvConce.Enabled = CkDtEnvoiConca.Checked;

            if (CkDtEnvoiConca.Checked)
            {

                DTenvConce.Text = DateTime.Now.ToString("dd/MM/yyyy");

            }
            else
            {
                DTenvConce.Text = "";
            }
        }

        private void BtInsert_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            openFileDialog1.Filter = "PDF Files|*.pdf";
            DialogResult result = openFileDialog1.ShowDialog(); //show the dialog

         
            if (result == DialogResult.OK)
            {
                FData.FilePath = openFileDialog1.FileName;
                
                string[] f = FData.FilePath.Split('\\');
                //get the file name
                string fn = f[(f.Length) - 1];
                string dest = @"D:\Projects Winform\Facture Project\Facture Project\FicherFolders\"+fn;


                //copy the file to the destination Folder

                File.Copy(FData.FilePath, dest, true);

                //to save to the database

                lbPathTosave.Text= FData.FilePath.ToString();


            }

              

          
        }

        private void BtnShowPdf_Click(object sender, EventArgs e)
        {
          
            
            if(FData.FilePath != null)
            {
                FRMpdfreader f = new FRMpdfreader(FData);
                f.Show();
            }else
            {
                MessageBox.Show("vous n'avez pas attacher une fichier", "error ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

           

        }
    }
}