using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facture_Project
{
    public class FactureData
    {
        public int id2retour { set; get; }
        public int IdFacture { set; get; }
        public float MontFact { set; get; }
        public string NumFact { set; get; } 
        public string FilePath { set; get; }

        public Fournisseur fournisseur { set; get; }
        public Sosiété Societe { set; get; }
        public Projete projet { set; get; }
        public DeuxRet deuxret { set; get; }
        public Service service { set; get; }


        public DateTime DateFact { set; get; }
        public DateTime DateRecep { set; get; }
        public DateTime DtEnvoiconcerne { set; get; }
        public DateTime DtRetconcerne { set; get; }
        public DateTime DateenvoiCompt { set; get; }


        





       
      

       












        
















    }
}
