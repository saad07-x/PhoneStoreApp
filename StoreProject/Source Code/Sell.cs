﻿using System;
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
    public partial class Sell : Form
    {
        public static Image aa;
        public static String mod;
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Sell()
        {
            InitializeComponent();
        }

        private void mainbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into SELL values(@brand,@model,@time,@price,@name,@number,@email,@city)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@brand", brand.Text);
            cmd.Parameters.AddWithValue("@model", model.Text);
            cmd.Parameters.AddWithValue("@time", time.Text);
            cmd.Parameters.AddWithValue("@price", price.Text);
            cmd.Parameters.AddWithValue("@name", naame.Text);
            cmd.Parameters.AddWithValue("@number", phone.Text);
            cmd.Parameters.AddWithValue("@email", email.Text);
            cmd.Parameters.AddWithValue("@city", city.Text);

            aa = pictureBox1.Image;
            mod = brand.Text;
            con.Open();
            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                //MessageBox.Show("Added");

            }
            con.Close();
            MessageBox.Show("Your Phone has beed added. Click Okay to got to the main menu.");
            this.Close();
            MainMenu m = new MainMenu();
            m.Show();
  
        }

        private void upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu m = new MainMenu();
            m.Show();
        }

        private void Sell_Load(object sender, EventArgs e)
        {

        }
    }
}
