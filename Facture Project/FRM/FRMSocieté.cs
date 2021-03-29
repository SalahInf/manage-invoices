using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facture_Project.FRM
{
    public partial class FRMSocieté : XtraForm
    {

        Sosiété sosiete = new Sosiété();
        SosiétéDal sosietedal = new SosiétéDal(); 

        public FRMSocieté()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sosiete.NomSosiété = txtNom.Text;
            sosiete.Numero = txtNom.Text;
            sosiete.Adresse = txtAdresse.Text;


            sosietedal.Save(sosiete);

            MessageBox.Show("Nouveau societé enregistrer", "Enregistrer", MessageBoxButtons.OK, MessageBoxIcon.Information);





        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
