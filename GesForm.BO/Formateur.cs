using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesForm.BO
{
    [Serializable]
    public class Formateur
    {
        public static int Id { get; } = 0;
        public string Matricule { get; set; }
        public string Nom { get; set; }
        public string Email { get; set; }
        public string MotPasse { get; set; }
        public long Tel { get; set; }

        public Formateur()
        {
        }

        public Formateur(string matricule, string nom, string email, string motPasse, long tel)
        {
            Matricule = matricule;
            Nom = nom;
            Email = email;
            MotPasse = motPasse;
            Tel = tel;
        }
    }
}
