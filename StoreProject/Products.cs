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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
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
            Huawei h = new Huawei();
            h.Show();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            Blackberry b = new Blackberry();
            b.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Apple a = new Apple();
            a.Show();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            OnePlus o = new OnePlus();
            o.Show();
        }
    }
}
