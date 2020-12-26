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

        public Reciept(string modell, string p)
        {
            InitializeComponent();
            model.Text = modell;
            pricee.Text = p;

            //Calculation
            int pr = int.Parse(pricee.Text);
            double tx = pr * 0.15;
            double tot = pr + tx;
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
    }
 
}
