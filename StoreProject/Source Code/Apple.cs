using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace StoreProject
{
    public partial class Apple : Form
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
        public Apple()
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
            Buy p = new Buy();
            p.Show();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select BRAND, MODEL, RAM, STORAGE, OPERATING_SYSTEM, MEGAPIXELS, DISPLAY, PRICE from APPLE where MODEL = 'iphone 6'";
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
            SpecificationApple specification = new SpecificationApple();
            specification.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Login l = new Login();
            l.Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //IPHONE 12
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select BRAND, MODEL, RAM, STORAGE, OPERATING_SYSTEM, MEGAPIXELS, DISPLAY, PRICE from APPLE where MODEL = 'iphone 12'";
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
            SpecificationApple specification = new SpecificationApple();
            specification.Show();
        }

        private void Apple_Load(object sender, EventArgs e)
        {

        }

        private void Ip11_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select BRAND, MODEL, RAM, STORAGE, OPERATING_SYSTEM, MEGAPIXELS, DISPLAY, PRICE from APPLE where MODEL = 'iphone 11'";
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
            SpecificationApple specification = new SpecificationApple();
            specification.Show();
        }

        private void Ipx_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select BRAND, MODEL, RAM, STORAGE, OPERATING_SYSTEM, MEGAPIXELS, DISPLAY, PRICE from APPLE where MODEL = 'iphone X'";
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
            SpecificationApple specification = new SpecificationApple();
            specification.Show();
        }

        private void IP8_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select BRAND, MODEL, RAM, STORAGE, OPERATING_SYSTEM, MEGAPIXELS, DISPLAY, PRICE from APPLE where MODEL = 'iphone 8'";
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
            SpecificationApple specification = new SpecificationApple();
            specification.Show();
        }

        private void Ip7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select BRAND, MODEL, RAM, STORAGE, OPERATING_SYSTEM, MEGAPIXELS, DISPLAY, PRICE from APPLE where MODEL = 'iphone 7'";
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
            SpecificationApple specification = new SpecificationApple();
            specification.Show();
        }

        private void Ip5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select BRAND, MODEL, RAM, STORAGE, OPERATING_SYSTEM, MEGAPIXELS, DISPLAY, PRICE from APPLE where MODEL = 'iphone 5'";
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
            SpecificationApple specification = new SpecificationApple();
            specification.Show();
        }

        private void Ip4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select BRAND, MODEL, RAM, STORAGE, OPERATING_SYSTEM, MEGAPIXELS, DISPLAY, PRICE from APPLE where MODEL = 'iphone 4'";
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
            SpecificationApple specification = new SpecificationApple();
            specification.Show();
        }

        private void Ip3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select BRAND, MODEL, RAM, STORAGE, OPERATING_SYSTEM, MEGAPIXELS, DISPLAY, PRICE from APPLE where MODEL = 'iphone 3'";
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
            SpecificationApple specification = new SpecificationApple();
            specification.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Aboutus a = new Aboutus();
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Contactus c = new Contactus();
            c.Show();
        }
    }
}
