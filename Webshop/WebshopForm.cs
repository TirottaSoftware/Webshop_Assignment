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
    partial class WebshopForm : Form
    {
        private Webshop webshop;
        public WebshopForm()
        {
            webshop = new Webshop();
            InitializeComponent();
            foreach (var item in Enum.GetNames(typeof(ProductType)).ToList())
            {
                cbProductType.Items.Add(item);
            }
        }

        private void UpdateGUI()
        {
            // TODO: implement update code here.
            lbProducts.Items.Clear();
            foreach (var item in webshop.GetProducts())
            {
                lbProducts.Items.Add(item);
            }
        }

        private void WebshopForm_Activated(object sender, EventArgs e)
        {
            UpdateGUI();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tbName.Text;
                double price = double.Parse(tbPrice.Text);
                int stock = int.Parse(tbStock.Text);
                Enum.TryParse(cbProductType.SelectedItem.ToString(), out ProductType productType);

                webshop.AddProduct(name, price, productType, stock);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            UpdateGUI();
        }

        private void WebshopForm_Load(object sender, EventArgs e)
        {
            var collectorForm = new ToyCollectorForm();
            var hunterForm = new BargainHunterForm();
            collectorForm.Show();
            hunterForm.Show();

            webshop.ProductAdded += hunterForm.OnProductAdded;
            webshop.ProductAdded += collectorForm.OnProductAdded;
        }

        private void lbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedProduct = (Product)lbProducts.SelectedItem;
            tbName.Text = selectedProduct.Name;
            tbPrice.Text = selectedProduct.Price.ToString();
            tbStock.Text = selectedProduct.Stock.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var selectedProduct = (Product)lbProducts.SelectedItem;
            string name = tbName.Text;
            double price = double.Parse(tbPrice.Text);
            int stock = int.Parse(tbStock.Text);
            Enum.TryParse(cbProductType.SelectedItem.ToString(), out ProductType productType);
            var newProduct = new Product(name, price, stock, productType);
            webshop.UpdateProduct(selectedProduct, newProduct);
            UpdateGUI();
        }
    }
}
