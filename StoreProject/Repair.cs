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
    public partial class Repair : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Repair()
        {
            InitializeComponent();
        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into REPAIR values(@PHONE_NAME,@MODEL,@TIME_USED,@PROBLEM,@STREET,@AREA,@CITY,@COUNTRY)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@PHONE_NAME", brand.Text);
            cmd.Parameters.AddWithValue("@MODEL", mod.Text);
            cmd.Parameters.AddWithValue("@TIME_USED", time.Text);
            cmd.Parameters.AddWithValue("@PROBLEM", problems.selectedValue.ToString());
            cmd.Parameters.AddWithValue("@STREET", st.Text);
            cmd.Parameters.AddWithValue("@AREA", area.Text);
            cmd.Parameters.AddWithValue("@CITY", city.Text);
            cmd.Parameters.AddWithValue("@COUNTRY", countrydrop.selectedValue.ToString());

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void brand_OnValueChanged(object sender, EventArgs e)
        {

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
            Buy b = new Buy();
            b.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Login l = new Login();
            l.Show();
        }
    }
}
