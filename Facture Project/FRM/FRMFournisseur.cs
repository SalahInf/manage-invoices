using DevExpress.XtraEditors;
using Facture_Project.DalClasse;
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
    public partial class FRMFournisseur : XtraForm
    {

        Fournisseur fournisseur = new Fournisseur();
        FournisseurDal fournisseurDal = new FournisseurDal();

        public FRMFournisseur()
        {
            InitializeComponent();
        }

        private void save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fournisseur.NomFour = txtNom.Text;
            fournisseur.NumFour = txtNumero.Text;
            fournisseur.AdresseFournisseur = txtAdresse.Text;

            fournisseurDal.Save(fournisseur);
            MessageBox.Show("Nouveau fournisseur enregistrer", "Enregistrer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
