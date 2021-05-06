using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestForm
{
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
        }

        private void apprenantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apprenant apprenant = new Apprenant();
            apprenant.Show();
            this.Hide();
        }

        private void coursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cours cours = new Cours();
            cours.Show();
            this.Hide();
        }

        private void formateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formateur formateur = new Formateur();
            formateur.Show();
            this.Hide();
        }

        private void btnapprenant_Click_1(object sender, EventArgs e)
        {
            Apprenant apprenant = new Apprenant();
            apprenant.Show();
            this.Hide();
        }

       

        private void btnformateur_Click_1(object sender, EventArgs e)
        {
            Formateur formateur = new Formateur();
            formateur.Show();
            this.Hide();
        }

        private void gunaButton2_Click_1(object sender, EventArgs e)
        {
            Session session = new Session();
            session.Show();
            this.Hide();
        }

      
    }
}
