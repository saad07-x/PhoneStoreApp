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
    public partial class Buy : Form
    {
        public Buy()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
            Samsung s = new Samsung();
            s.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Login l = new Login();
            l.Show();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.Close();
            Huawei h = new Huawei();
            h.Show();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            this.Close();
            Blackberry b = new Blackberry();
            b.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
            Apple a = new Apple();
            a.Show();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            this.Close();
            OnePlus o = new OnePlus();
            o.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu m = new MainMenu();
            m.Show();
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

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            this.Close();
            Used u = new Used();
            u.Show();
        }
    }
}
