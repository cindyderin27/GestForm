using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Devart.Common;
using Devart.Data;
using Devart.Data.PostgreSql;



namespace GestForm
{
    public partial class Session : Form
    {

        private static string Host = "cindy.postgres.database.azure.com";
        private static string User = "temetangcindy";
        private static string DBname = "Formation";
        private static string Password = "mj!cintfc127";
        private static string Port = "5432";

        string connString =
               String.Format(
                   "Server={0};Username={1};Database={2};Port={3};Password={4};SSLMode=Prefer",
                   Host,
                   User,
                   DBname,
                   Port,
                   Password);
        public Session()
        {
            InitializeComponent();
        }

        private void Session_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            PgSqlConnection pgSqlConnection = new PgSqlConnection();
           
            this.Hide();
            Cours f = new Cours();
            f.ShowDialog();
        }
    }
}
