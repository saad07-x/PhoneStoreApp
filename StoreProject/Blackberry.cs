using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace StoreProject
{
    public partial class Blackberry : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString; //This line gives the file we created in appconfig to the varable cs.
        public static string Brand;
        public static string Model;
        public static string Ram;
        public static string Storage;
        public static string Os;
        public static string Megepixel;
        public static string Display;
        public static string Price;

        public Blackberry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu m = new MainMenu();
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Products p = new Products();
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Login l = new Login();
            l.Show();
        }

        private void Blackberry_Load(object sender, EventArgs e)
        {

        }
    }
}
