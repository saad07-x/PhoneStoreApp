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
    public partial class Reciept : Form
    {

        public Reciept(string modell, string pp)
        {
            InitializeComponent();
            model.Text = modell;
            pricee.Text = pp;

            int x = Int32.Parse(pp);
            //Calculation
            //int pr = int.Parse(pp);
            double tx = x * 0.15;
            double tot = x + tx;
            tax.Text = tx.ToString();
            total.Text = tot.ToString();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu m = new MainMenu();
            m.Show();
        }
        private void ex_Click(object sender, EventArgs e)
        {
           
            Application.Exit();
        }

        private void Reciept_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thankyou t = new Thankyou();
            t.Show();
        }
    }
 
}
