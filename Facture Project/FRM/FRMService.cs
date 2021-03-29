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
    public partial class FRMService : XtraForm
    {
        ServiceDal serv = new ServiceDal();
        Service servData = new Service();
        public FRMService()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            servData.NomService = txtNom.Text;
            servData.Numero = txtNumero.Text;
            servData.Adresse = txtAdresse.Text;

            serv.Save(servData);
            MessageBox.Show("Nouveau service enregistrer", "Enregistrer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
