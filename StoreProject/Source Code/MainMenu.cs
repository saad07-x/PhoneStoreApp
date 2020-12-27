using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreProject
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();

            Buy p = new Buy();
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Login l = new Login();
            l.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Contactus c = new Contactus();
            c.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Aboutus a = new Aboutus();
            a.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
            Sell r = new Sell();
            r.Show();

        }
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.Hide();
            Repair r = new Repair();
            r.Show();

        }

        private void repair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Repair r = new Repair();
            r.Show();
        }
    }
}
