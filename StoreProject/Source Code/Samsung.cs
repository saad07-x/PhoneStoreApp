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
    
    public partial class Samsung : Form
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

        public Samsung()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu m = new MainMenu();
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Buy p = new Buy();
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Login l = new Login();
            l.Show();
        }
        private void S21_Click(object sender, EventArgs e)
        {
            //string S = "GALAXY S21";
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select BRAND, MODEL, RAM, STORAGE, OPERATING_SYSTEM, MEGAPIXELS, DISPLAY, PRICE from SAMSUNG where MODEL = 'GALAXY S21'";
            SqlCommand cmd = new SqlCommand(query, con);
           // cmd.Parameters.AddWithValue("@MODEL",S );
            //cmd.Parameters.AddWithValue("@pass", password.Text);
            
            SqlDataReader drr = cmd.ExecuteReader();
            while (drr.Read())
            {
                Brand = drr.GetString(0).ToString();
                Model = drr.GetString(1).ToString();
                Ram = drr.GetString(2).ToString();
                Storage = drr.GetString(3).ToString();
                Os = drr.GetString(4).ToString();
                Megepixel = drr.GetString(5).ToString();
                Display = drr.GetString(6).ToString();
                Price = drr.GetString(7).ToString();
            }
            
            con.Close();
            this.Close();

            SpecificationSamsung s = new SpecificationSamsung();
            s.Show();
        }

        private void S20_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select BRAND, MODEL, RAM, STORAGE, OPERATING_SYSTEM, MEGAPIXELS, DISPLAY, PRICE from SAMSUNG where MODEL = 'GALAXY S10'";
            SqlCommand cmd = new SqlCommand(query, con);
            // cmd.Parameters.AddWithValue("@MODEL",S );
            //cmd.Parameters.AddWithValue("@pass", password.Text);

            SqlDataReader drr = cmd.ExecuteReader();
            while (drr.Read())
            {
                Brand = drr.GetString(0).ToString();
                Model = drr.GetString(1).ToString();
                Ram = drr.GetString(2).ToString();
                Storage = drr.GetString(3).ToString();
                Os = drr.GetString(4).ToString();
                Megepixel = drr.GetString(5).ToString();
                Display = drr.GetString(6).ToString();
                Price = drr.GetString(7).ToString();
            }

            con.Close();
            this.Close();

            SpecificationSamsung s = new SpecificationSamsung();
            s.Show();
        }

        private void S10_Click(object sender, EventArgs e)
        {

        }

        private void S9_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select BRAND, MODEL, RAM, STORAGE, OPERATING_SYSTEM, MEGAPIXELS, DISPLAY, PRICE from SAMSUNG where MODEL = 'GALAXY S9'";
            SqlCommand cmd = new SqlCommand(query, con);
            // cmd.Parameters.AddWithValue("@MODEL",S );
            //cmd.Parameters.AddWithValue("@pass", password.Text);

            SqlDataReader drr = cmd.ExecuteReader();
            while (drr.Read())
            {
                Brand = drr.GetString(0).ToString();
                Model = drr.GetString(1).ToString();
                Ram = drr.GetString(2).ToString();
                Storage = drr.GetString(3).ToString();
                Os = drr.GetString(4).ToString();
                Megepixel = drr.GetString(5).ToString();
                Display = drr.GetString(6).ToString();
                Price = drr.GetString(7).ToString();
            }

            con.Close();
            this.Close();

            SpecificationSamsung s = new SpecificationSamsung();
            s.Show();
        }

        private void S8_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select BRAND, MODEL, RAM, STORAGE, OPERATING_SYSTEM, MEGAPIXELS, DISPLAY, PRICE from SAMSUNG where MODEL = 'GALAXY S8'";
            SqlCommand cmd = new SqlCommand(query, con);
            // cmd.Parameters.AddWithValue("@MODEL",S );
            //cmd.Parameters.AddWithValue("@pass", password.Text);

            SqlDataReader drr = cmd.ExecuteReader();
            while (drr.Read())
            {
                Brand = drr.GetString(0).ToString();
                Model = drr.GetString(1).ToString();
                Ram = drr.GetString(2).ToString();
                Storage = drr.GetString(3).ToString();
                Os = drr.GetString(4).ToString();
                Megepixel = drr.GetString(5).ToString();
                Display = drr.GetString(6).ToString();
                Price = drr.GetString(7).ToString();
            }

            con.Close();
            this.Close();

            SpecificationSamsung s = new SpecificationSamsung();
            s.Show();
        }

        private void S7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select BRAND, MODEL, RAM, STORAGE, OPERATING_SYSTEM, MEGAPIXELS, DISPLAY, PRICE from SAMSUNG where MODEL = 'GALAXY S7'";
            SqlCommand cmd = new SqlCommand(query, con);
            // cmd.Parameters.AddWithValue("@MODEL",S );
            //cmd.Parameters.AddWithValue("@pass", password.Text);

            SqlDataReader drr = cmd.ExecuteReader();
            while (drr.Read())
            {
                Brand = drr.GetString(0).ToString();
                Model = drr.GetString(1).ToString();
                Ram = drr.GetString(2).ToString();
                Storage = drr.GetString(3).ToString();
                Os = drr.GetString(4).ToString();
                Megepixel = drr.GetString(5).ToString();
                Display = drr.GetString(6).ToString();
                Price = drr.GetString(7).ToString();
            }

            con.Close();
            this.Close();

            SpecificationSamsung s = new SpecificationSamsung();
            s.Show();
        }

        private void S6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select BRAND, MODEL, RAM, STORAGE, OPERATING_SYSTEM, MEGAPIXELS, DISPLAY, PRICE from SAMSUNG where MODEL = 'GALAXY S6'";
            SqlCommand cmd = new SqlCommand(query, con);
            // cmd.Parameters.AddWithValue("@MODEL",S );
            //cmd.Parameters.AddWithValue("@pass", password.Text);

            SqlDataReader drr = cmd.ExecuteReader();
            while (drr.Read())
            {
                Brand = drr.GetString(0).ToString();
                Model = drr.GetString(1).ToString();
                Ram = drr.GetString(2).ToString();
                Storage = drr.GetString(3).ToString();
                Os = drr.GetString(4).ToString();
                Megepixel = drr.GetString(5).ToString();
                Display = drr.GetString(6).ToString();
                Price = drr.GetString(7).ToString();
            }

            con.Close();
            this.Close();

            SpecificationSamsung s = new SpecificationSamsung();
            s.Show();
        }

        private void S5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select BRAND, MODEL, RAM, STORAGE, OPERATING_SYSTEM, MEGAPIXELS, DISPLAY, PRICE from SAMSUNG where MODEL = 'GALAXY S5'";
            SqlCommand cmd = new SqlCommand(query, con);
            // cmd.Parameters.AddWithValue("@MODEL",S );
            //cmd.Parameters.AddWithValue("@pass", password.Text);

            SqlDataReader drr = cmd.ExecuteReader();
            while (drr.Read())
            {
                Brand = drr.GetString(0).ToString();
                Model = drr.GetString(1).ToString();
                Ram = drr.GetString(2).ToString();
                Storage = drr.GetString(3).ToString();
                Os = drr.GetString(4).ToString();
                Megepixel = drr.GetString(5).ToString();
                Display = drr.GetString(6).ToString();
                Price = drr.GetString(7).ToString();
            }

            con.Close();
            this.Close();

            SpecificationSamsung s = new SpecificationSamsung();
            s.Show();
        }

        private void S4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select BRAND, MODEL, RAM, STORAGE, OPERATING_SYSTEM, MEGAPIXELS, DISPLAY, PRICE from SAMSUNG where MODEL = 'GALAXY S4'";
            SqlCommand cmd = new SqlCommand(query, con);
            // cmd.Parameters.AddWithValue("@MODEL",S );
            //cmd.Parameters.AddWithValue("@pass", password.Text);

            SqlDataReader drr = cmd.ExecuteReader();
            while (drr.Read())
            {
                Brand = drr.GetString(0).ToString();
                Model = drr.GetString(1).ToString();
                Ram = drr.GetString(2).ToString();
                Storage = drr.GetString(3).ToString();
                Os = drr.GetString(4).ToString();
                Megepixel = drr.GetString(5).ToString();
                Display = drr.GetString(6).ToString();
                Price = drr.GetString(7).ToString();
            }

            con.Close();
            this.Close();

            SpecificationSamsung s = new SpecificationSamsung();
            s.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Contactus c = new Contactus();
            c.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Aboutus a = new Aboutus();
            a.Show();
        }
    }
}
