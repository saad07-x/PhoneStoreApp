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
    public partial class Huawei : Form
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
        public Huawei()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu m = new MainMenu();
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Buy p = new Buy();
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Login l = new Login();
            l.Show();
        }

        private void Huawei_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Contactus c = new Contactus();
            c.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Aboutus a = new Aboutus();
            a.Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select BRAND, MODEL, RAM, STORAGE, OPERATING_SYSTEM, MEGAPIXELS, DISPLAY, PRICE from HUAWEI where MODEL = 'NOVA 8'";
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
            this.Hide();

            SpecificationHuawei specification = new SpecificationHuawei();
            specification.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select BRAND, MODEL, RAM, STORAGE, OPERATING_SYSTEM, MEGAPIXELS, DISPLAY, PRICE from HUAWEI where MODEL = 'MATE 40'";
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
            this.Hide();

            SpecificationHuawei specification = new SpecificationHuawei();
            specification.Show();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select BRAND, MODEL, RAM, STORAGE, OPERATING_SYSTEM, MEGAPIXELS, DISPLAY, PRICE from HUAWEI where MODEL = 'ENJOY 20'";
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
            this.Hide();

            SpecificationHuawei specification = new SpecificationHuawei();
            specification.Show();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select BRAND, MODEL, RAM, STORAGE, OPERATING_SYSTEM, MEGAPIXELS, DISPLAY, PRICE from HUAWEI where MODEL = 'NOVA 7'";
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
            SpecificationHuawei specification = new SpecificationHuawei();
            specification.Show();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select BRAND, MODEL, RAM, STORAGE, OPERATING_SYSTEM, MEGAPIXELS, DISPLAY, PRICE from HUAWEI where MODEL = 'P40'";
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
            this.Hide();

            SpecificationHuawei specification = new SpecificationHuawei();
            specification.Show();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select BRAND, MODEL, RAM, STORAGE, OPERATING_SYSTEM, MEGAPIXELS, DISPLAY, PRICE from HUAWEI where MODEL = 'NOVA 6'";
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
            this.Hide();

            SpecificationHuawei specification = new SpecificationHuawei();
            specification.Show();
        }

        private void bunifuThinButton29_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select BRAND, MODEL, RAM, STORAGE, OPERATING_SYSTEM, MEGAPIXELS, DISPLAY, PRICE from HUAWEI where MODEL = 'Y9'";
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
            this.Hide();

            SpecificationHuawei specification = new SpecificationHuawei();
            specification.Show();
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select BRAND, MODEL, RAM, STORAGE, OPERATING_SYSTEM, MEGAPIXELS, DISPLAY, PRICE from HUAWEI where MODEL = 'ENJOY 10'";
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
            this.Hide();

            SpecificationHuawei specification = new SpecificationHuawei();
            specification.Show();
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select BRAND, MODEL, RAM, STORAGE, OPERATING_SYSTEM, MEGAPIXELS, DISPLAY, PRICE from HUAWEI where MODEL = 'NOVA 5'";
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
            this.Hide();

            SpecificationHuawei specification = new SpecificationHuawei();
            specification.Show();
        }
    }
}
