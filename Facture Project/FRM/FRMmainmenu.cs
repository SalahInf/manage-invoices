using WindowsFormsApp1;
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
using Facture_Project.FRM;

namespace Facture_Project
{
    public partial class FRMmainmenu : XtraForm
    {
        public FRMmainmenu()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            FRMGv FactureGv = Application.OpenForms["FRMGv"] as FRMGv;
            if (FactureGv != null)
            {
                FactureGv.WindowState = FormWindowState.Maximized;
                FactureGv.BringToFront();
                FactureGv.Activate();
            }
            else
            {
                FactureGv = new FRMGv();
                FactureGv.MdiParent = this;
                FactureGv.Show();
            }
        }

        private void Butaddfac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FRMFacture NewFacture = Application.OpenForms["FRMFacture"] as FRMFacture;
            if (NewFacture != null)
            {
                NewFacture.WindowState = FormWindowState.Normal;
                NewFacture.BringToFront();
                NewFacture.Activate();
            }
            else
            {
                NewFacture = new FRMFacture();
                //NewFacture.MdiParent = this;
                NewFacture.Show();
                NewFacture.GRCdeuxRetour.Enabled = false;
                NewFacture.GrFacService.Enabled = false;
                NewFacture.GrFacContabilite.Enabled = false;
            }


           // FRMFacture fac = new FRMFacture();
            //FactureGv.MdiParent = this;            
            //fac.Show();
           
        }

        private void Newserv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FRMService ser = new FRMService();
            ser.Show();
        }

        private void NewComp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FRMSocieté Sce = new FRMSocieté();
            Sce.Show();
        }

        private void NewFour_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FRMFournisseur four = new FRMFournisseur();
            four.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

           //Actualise GV

            FRMGv frmgv = Application.OpenForms["FRMGv"] as FRMGv;
            if (frmgv != null)
            {
                frmgv.GCconsultation.DataSource = FactureDal.getData();
            }

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}