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
    }
}
