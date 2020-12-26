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
    public partial class Information : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        string mm,pp;
        public Information(string modell, string p)
        {
            
            InitializeComponent();
            mm = modell;
            pp = p;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
            this.Close();
            Aboutus a = new Aboutus();
            a.Show();
        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into INFO values(@house_no,@street_name,@area_name,@city,@country,@full_name,@contact_number,@email_id,@product,@price)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@house_no", housetxtbox.Text);
            cmd.Parameters.AddWithValue("@street_name", streettxtbox.Text);
            cmd.Parameters.AddWithValue("@area_name", areatxtbox.Text);
            cmd.Parameters.AddWithValue("@city", citytxtbox.Text);
            cmd.Parameters.AddWithValue("@country", countrydrop.selectedValue.ToString());
            //string query = "insert into PERSONAL_INFO values(@full_name,@contact_number,@email_id)";
            //SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@full_name", nametxtbox.Text);
            cmd.Parameters.AddWithValue("@contact_number", contact.Text);
            cmd.Parameters.AddWithValue("@email_id", email.Text);
            cmd.Parameters.AddWithValue("@product",mm);
            cmd.Parameters.AddWithValue("@price",pp);



            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            /*
            SqlConnection conn = new SqlConnection(cs);
            string queryy = "insert into PERSONAL_INFO values(@full_name,@contact_number,@email_id)";
            SqlCommand cmdd = new SqlCommand(queryy, conn);
            cmd.Parameters.AddWithValue("@full_name", nametxtbox.Text);
            cmd.Parameters.AddWithValue("@contact_number", contactbox.Text);
            cmd.Parameters.AddWithValue("@email_id", emailbox.Text);
            conn.Open();

            cmdd.ExecuteNonQuery();
            conn.Close();
            */
            this.Close();
            Reciept r = new Reciept(mm, pp);
            r.Show();


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label11.Visible = true;
            card.Visible = true;
            label12.Visible = true;
            pin.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label11.Visible = false;
            card.Visible = false;
            label12.Visible = false;
            pin.Visible = false;
        }

        private void Appleinfo_Load(object sender, EventArgs e)
        {

        }
    }

}