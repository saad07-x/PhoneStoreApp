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
    public partial class SpecificationSamsung : Form
    {
        public SpecificationSamsung()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SpecificationSamsung_Load(object sender, EventArgs e)
        {
            brand.Text = Samsung.Brand;
            model.Text = Samsung.Model;
            ram.Text = Samsung.Ram;
            storage.Text = Samsung.Storage;
            operatingsys.Text = Samsung.Os;
            megapixel.Text = Samsung.Megepixel;
            disp.Text = Samsung.Display;
            price.Text = Samsung.Price;
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

        private void button8_Click(object sender, EventArgs e)
        {
            int pricepass = int.Parse(price.Text);
            //Convert.ToInt32(this.price.Text);
            this.Hide();
            Information r = new Information(model.Text, price.Text);
            r.Show();
        }
    }
}
