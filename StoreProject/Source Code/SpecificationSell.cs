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
    public partial class SpecificationSell : Form
    {
        public SpecificationSell()
        {
            InitializeComponent();
        }

        private void SpecificationSell_Load(object sender, EventArgs e)
        {
            brand.Text = Used.brand;
            model.Text = Used.model;
            time.Text = Used.time;
            price.Text = Used.price;
            name.Text = Used.name;
            num.Text = Used.number;
            email.Text = Used.email;
            pr.Text = Used.price;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Information r = new Information(model.Text, price.Text);
            r.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
