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
    public partial class FRMpdfreader : DevExpress.XtraEditors.XtraForm
    {
        public FRMpdfreader()
        {
            //FactureData fdata = new FactureData();
            
            
        }
        public FRMpdfreader(FactureData f)
        {
            InitializeComponent();
            Pdf(f);
        }

        private void PdfViewer_Load(object sender, EventArgs e)
        {

        }

        public void Pdf(FactureData F)
        {
           
            PdfViewer.LoadDocument(F.FilePath);
        }

    }
}