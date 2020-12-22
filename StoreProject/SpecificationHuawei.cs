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
    public partial class SpecificationHuawei : Form
    {
        public SpecificationHuawei()
        {
            InitializeComponent();
        }

        private void SpecificationHuawei_Load(object sender, EventArgs e)
        {
            brand.Text = Huawei.Brand;
            model.Text = Huawei.Model;
            ram.Text = Huawei.Ram;
            storage.Text = Huawei.Storage;
            operatingsys.Text = Huawei.Os;
            megapixel.Text = Huawei.Megepixel;
            disp.Text = Huawei.Display;
            price.Text = Huawei.Price;
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
            /*
            int pricepass = int.Parse(price.Text);
            //Convert.ToInt32(this.price.Text);
            this.Hide();
            Reciept r = new Reciept(model.Text, price.Text);
            r.Show();
            Convert.ToInt32(this.price.Text);
        
            */
            int pricepass = int.Parse(price.Text);
            //Convert.ToInt32(this.price.Text);
            this.Hide();
            Information r = new Information(model.Text, price.Text);
            r.Show();
        }
    }
}
