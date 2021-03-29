using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using WindowsFormsApp1;

namespace Facture_Project
{
    public partial class FRMGv : XtraForm 
    {
        public FRMGv()
        {
            InitializeComponent();
            FactureDal.getData();
            GCconsultation.DataSource = FactureDal.getData();
            hide();



        }

        public void hide()
        {
            GVconsultation.Columns["FactId"].Visible = false;
            GVconsultation.Columns["IdSte"].Visible = false;
            GVconsultation.Columns["IdSce"].Visible = false;
            GVconsultation.Columns["IdFournisseur"].Visible = false;
            GVconsultation.Columns["IdProjet"].Visible = false;
            GVconsultation.Columns["Filepath"].Visible = false;


            for (int i = 0; i < GVconsultation.DataRowCount; i++)
                //GVconsultation.Columns[i].Visible = false;
            GVconsultation.Columns["NomFour"].VisibleIndex = 3;
            //GVconsultation.Columns["col3"].VisibleIndex = 1;
            //GVconsultation.Columns["col5"].VisibleIndex = 2;
            //GVconsultation.Columns["col7"].VisibleIndex = 3;
            //GVconsultation.Columns["col9"].VisibleIndex = 4;

        }

        private void Btnedit_ItemClick(object sender, ItemClickEventArgs e)
        {
            //DataRow Dv = GVconsultation.GetFocusedDataRow();

            //FRMFacture Fac = new FRMFacture(Dv);
            //Fac.Show();
        }

        private void Btnvisualiser_ItemClick(object sender, ItemClickEventArgs e)
        {
            //DataRow Dv = GVconsultation.GetFocusedDataRow();

            //FRMFacture Fac = new FRMFacture(Dv);
            //Fac.Show();
        }

        private void GVconsultation_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            var rowH = GVconsultation.FocusedRowHandle;
            var FocusRowView = (DataRowView)GVconsultation.GetFocusedRow();
            if (FocusRowView == null || FocusRowView.IsNew) return;
            if (rowH > 0)
            {
                popupMenu1.ShowPopup(barManager1, new Point(MousePosition.X, MousePosition.Y));

            }
            else
                popupMenu1.HidePopup();
        }

        private void GCconsultation_DoubleClick(object sender, EventArgs e)
        {

            DataRow Dv = GVconsultation.GetFocusedDataRow();
            DeuxRet der = new DeuxRet();

            FRMFacture Fac = new FRMFacture(Dv,der);
            Fac.Show();


        }

        private void GCconsultation_Click(object sender, EventArgs e)
        {

        }
    }
}