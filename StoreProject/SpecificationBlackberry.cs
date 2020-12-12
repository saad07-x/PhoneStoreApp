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
    public partial class SpecificationBlackberry : Form
    {
        public SpecificationBlackberry()
        {
            InitializeComponent();
        }

        private void SpecificationBlackberry_Load(object sender, EventArgs e)
        {
            brand.Text = Blackberry.Brand;
            model.Text = Blackberry.Model;
            ram.Text = Blackberry.Ram;
            storage.Text = Blackberry.Storage;
            operatingsys.Text = Blackberry.Os;
            megapixel.Text = Blackberry.Megepixel;
            disp.Text = Blackberry.Display;
            price.Text = Blackberry.Price;
        }
    }
    
}
