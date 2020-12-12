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
    public partial class SpecificationOneplus : Form
    {
        public SpecificationOneplus()
        {
            InitializeComponent();
        }

        private void SpecificationOneplus_Load(object sender, EventArgs e)
        {
            brand.Text = OnePlus.Brand;
            model.Text = OnePlus.Model;
            ram.Text = OnePlus.Ram;
            storage.Text = OnePlus.Storage;
            operatingsys.Text = OnePlus.Os;
            megapixel.Text = OnePlus.Megepixel;
            disp.Text = OnePlus.Display;
            price.Text = OnePlus.Price;
        }
    }
}
