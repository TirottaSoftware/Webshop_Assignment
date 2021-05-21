using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Webshop
{
    partial class ToyCollectorForm : Form
    {
        public ToyCollectorForm()
        {
            InitializeComponent();
        }

        public void OnProductAdded(object src, ProductEventArgs args)
        {
            if (args.Product.Type == ProductType.Toy)
            {
                lbToys.Items.Add($"{args.Product}");
            }
        }
    }
}
