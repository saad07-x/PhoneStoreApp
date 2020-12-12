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
    }
}
