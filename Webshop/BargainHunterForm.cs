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
    partial class BargainHunterForm : Form
    {
        public BargainHunterForm()
        {
            InitializeComponent();
        }
        public void OnProductAdded(object src, ProductEventArgs args)
        {
            lbBargains.Items.Add($"{args.Product}");
        }
    }
}
