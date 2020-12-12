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
    public partial class OnePlus : Form
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
        public OnePlus()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select BRAND, MODEL, RAM, STORAGE, OPERATING_SYSTEM, MEGAPIXELS, DISPLAY, PRICE from ONEPLUS where MODEL = 'NORD'";
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
            SpecificationOneplus specification = new SpecificationOneplus();
            specification.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Products p = new Products();
            p.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu m = new MainMenu();
            m.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Login l = new Login();
            l.Show();
        }

        private void EIGHTT_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select BRAND, MODEL, RAM, STORAGE, OPERATING_SYSTEM, MEGAPIXELS, DISPLAY, PRICE from ONEPLUS where MODEL = '8T'";
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
            SpecificationOneplus specification = new SpecificationOneplus();
            specification.Show();
        }

        private void SEVENT_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select BRAND, MODEL, RAM, STORAGE, OPERATING_SYSTEM, MEGAPIXELS, DISPLAY, PRICE from ONEPLUS where MODEL = '7T'";
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
            SpecificationOneplus specification = new SpecificationOneplus();
            specification.Show();
        }

        private void SIXT_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select BRAND, MODEL, RAM, STORAGE, OPERATING_SYSTEM, MEGAPIXELS, DISPLAY, PRICE from ONEPLUS where MODEL = '6T'";
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
            SpecificationOneplus specification = new SpecificationOneplus();
            specification.Show();
        }

        private void FIVET_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select BRAND, MODEL, RAM, STORAGE, OPERATING_SYSTEM, MEGAPIXELS, DISPLAY, PRICE from ONEPLUS where MODEL = '5T'";
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
            SpecificationOneplus specification = new SpecificationOneplus();
            specification.Show();
        }

        private void THREET_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select BRAND, MODEL, RAM, STORAGE, OPERATING_SYSTEM, MEGAPIXELS, DISPLAY, PRICE from ONEPLUS where MODEL = '3T'";
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
            SpecificationOneplus specification = new SpecificationOneplus();
            specification.Show();
        }

        private void X_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select BRAND, MODEL, RAM, STORAGE, OPERATING_SYSTEM, MEGAPIXELS, DISPLAY, PRICE from ONEPLUS where MODEL = 'X'";
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
            SpecificationOneplus specification = new SpecificationOneplus();
            specification.Show();
        }

        private void ONE_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select BRAND, MODEL, RAM, STORAGE, OPERATING_SYSTEM, MEGAPIXELS, DISPLAY, PRICE from ONEPLUS where MODEL = 'ONE'";
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
            SpecificationOneplus specification = new SpecificationOneplus();
            specification.Show();
        }

        private void MCLAREN_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select BRAND, MODEL, RAM, STORAGE, OPERATING_SYSTEM, MEGAPIXELS, DISPLAY, PRICE from ONEPLUS where MODEL = 'MCLAREN'";
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
            SpecificationOneplus specification = new SpecificationOneplus();
            specification.Show();
        }
    }
}
