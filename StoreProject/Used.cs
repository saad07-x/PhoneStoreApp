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

    public partial class Used : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString; //This line gives the file we created in appconfig to the varable cs.
        public static string brand;
        public static string model;
        public static string time;
        public static string price;
        public static string name;
        public static string number;
        public static string email;
        public static string city;
        public static Image a;
        public static string mmm;
        public Used()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           a = pictureBox1.Image;
            //mmm = 
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select BRAND, MODEL, TIME_USED, PRICE, P_NAME, P_NUMBER, EMAIL, CITY from SELL where CITY = 'KHI'";
            SqlCommand cmd = new SqlCommand(query, con);
            // cmd.Parameters.AddWithValue("@MODEL",S );
            //cmd.Parameters.AddWithValue("@pass", password.Text);

            SqlDataReader drr = cmd.ExecuteReader();
            while (drr.Read())
            {
                brand = drr.GetString(0).ToString();
                model = drr.GetString(1).ToString();
                time = drr.GetString(2).ToString();
                price = drr.GetString(3).ToString();
                name = drr.GetString(4).ToString();
                number = drr.GetString(5).ToString();
                email = drr.GetString(6).ToString();
                city = drr.GetString(7).ToString();
            }

            con.Close();
            this.Close();
            SpecificationSell specification = new SpecificationSell();
            specification.Show();
        }

        private void Used_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Sell.aa;
            butt.Text = Sell.mod;
        }
    }
}
