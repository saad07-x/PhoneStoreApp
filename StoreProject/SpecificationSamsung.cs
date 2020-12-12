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
    }
}
