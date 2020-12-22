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
    public partial class SpecificationApple : Form
    {
        public SpecificationApple()
        {
            InitializeComponent();
        }

        private void SpecificationApple_Load(object sender, EventArgs e)
        {
            brand.Text = Apple.Brand;
            model.Text = Apple.Model;
            ram.Text = Apple.Ram;
            storage.Text = Apple.Storage;
            operatingsys.Text = Apple.Os;
            megapixel.Text = Apple.Megepixel;
            disp.Text = Apple.Display;
            price.Text = Apple.Price;

  
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
            //int pricepass = int.Parse(price.Text);
            //Convert.ToInt32(this.price.Text);
            this.Hide();
            Information r = new Information(model.Text, price.Text);
            r.Show();

        }
    }
}
