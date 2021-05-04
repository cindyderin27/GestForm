using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesForm.BO
{
    [Serializable]
   public  class Session
    {
        public static int Id { get; }
        public string Email { get; set; }
        public string MotPasse { get; set; }
        public int IdApprenant { get; set; }

        public Session()
        {
        }

        public Session(string email, string motPasse, int idApprenant)
        {
            Email = email;
            MotPasse = motPasse;
            IdApprenant = idApprenant;
        }
    }
}
