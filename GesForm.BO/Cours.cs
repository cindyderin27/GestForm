using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesForm.BO
{
    [Serializable]
    public class Cours
    {
        public static int Id { get; } = 0;
        public string Code { get; set; }
        public string Nom { get; set; }
        public int Credit { get; set; }
        public int Duree { get; set; }
        public int IdFormateur { get; set; }

        public Cours()
        {
        }

        public Cours(string code, string nom, int credit, int duree, int idFormateur)
        {
            Code = code;
            Nom = nom;
            Credit = credit;
            Duree = duree;
            IdFormateur = idFormateur;
        }
    }
}
