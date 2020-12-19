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
    public partial class Oneplusinfo : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Oneplusinfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu m = new MainMenu();
            m.Show();
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

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into ADDRESS_INFO values(@house_no,@street_name,@area_name,@city,@country)" +
                "insert into PERSONAL_INFO values(@full_name,@contact_number,@email_id)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@house_no", housetxtbox.Text);
            cmd.Parameters.AddWithValue("@street_name", streettxtbox.Text);
            cmd.Parameters.AddWithValue("@area_name", areatxtbox.Text);
            cmd.Parameters.AddWithValue("@city", citytxtbox.Text);
            cmd.Parameters.AddWithValue("@country", countrydrop.selectedValue.ToString());
            cmd.Parameters.AddWithValue("@full_name", nametxtbox.Text);
            cmd.Parameters.AddWithValue("@contact_number", contact.Text);
            cmd.Parameters.AddWithValue("@email_id", email.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
