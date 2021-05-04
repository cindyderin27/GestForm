using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesForm.BO
{
    [Serializable]
    public class Module
    {
        public static int Id { get; } = 0;

        public string Nom { get; set; }
        public  int IdCours { get; set; }
        public int IdApprenant { get; set; }

        public Module()
        {
        }

        public Module(string nom, int idCours, int idApprenant)
        {
            Nom = nom;
            IdCours = idCours;
            IdApprenant = idApprenant;
        }
    }
}
