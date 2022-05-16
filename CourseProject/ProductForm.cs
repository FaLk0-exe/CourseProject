using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class ProductForm : Form
    {
        int row = -2;
        bool isOrderedByAsc = true;
        customer_order order;
        int? lastColumn;
        List<product_amount> products;
        public ProductForm(customer_order order)
        {
            products = ERMRepository.GetFullProducts(order);
            this.order = order;
            InitializeComponent();
        }

        void LoadProducts()
        {
            dataGridView1.Rows.Clear();
            foreach (var p in products)
            {
                dataGridView1.Rows.Add(p.product.id, p.product.name, p.product.product_category.name,
                    p.product.manufacturer.name,
                    string.Format("{0:0.00}", p.product.price.GetValueOrDefault()),
                    p.product_amount_value);
            }
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
            comboBox1.Items.AddRange(ERMRepository.GetCategoryNames().ToArray());
            comboBox2.Items.AddRange(ERMRepository.GetManufacturers().ToArray());
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != 6)
            {
                if (e.ColumnIndex == 0)
                {
                    products = products.OrderBy(o => o.product.id).ToList();
                }
                if (e.ColumnIndex == 1)
                {
                    products = products.OrderBy(o => o.product.name).ToList();
                }
                if (e.ColumnIndex == 2)
                {
                    products = products.OrderBy(o => o.product.product_category.name).ToList();
                }
                if (e.ColumnIndex == 3)
                {
                    products = products.OrderBy(o => o.product.manufacturer.name).ToList();
                }
                if (e.ColumnIndex == 4)
                {
                    products = products.OrderBy(o => o.product.price).ToList();
                }
                if (e.ColumnIndex == 5)
                {
                    products = products.OrderBy(o => o.product_amount_value).ToList();
                }

                if (lastColumn == null)
                {
                    lastColumn = e.ColumnIndex;
                }
                if (lastColumn == e.ColumnIndex)
                {
                    if (!isOrderedByAsc)
                    {
                        products.Reverse();
                        isOrderedByAsc = true;
                    }
                    else
                    {
                        isOrderedByAsc = false;
                    }

                }
                else
                {
                    lastColumn = e.ColumnIndex;
                    isOrderedByAsc = true;
                }

                LoadProducts();
            }
           
        }

        private void authorizationButton_Click(object sender, EventArgs e)
        {
            products= ERMRepository.GetFullProducts(order);
            if(textBox1.Text!="")
            {
                products = products.Where(p => p.product.id.ToString().Contains(textBox1.Text)).ToList();
            }
            if (comboBox1.Text != "")
            {
                products = products.Where(p => p.product.product_category.name.Contains(comboBox1.Text)).ToList();
            }
            if (comboBox2.Text != "")
            {
                products = products.Where(p => p.product.manufacturer.name.Contains(comboBox2.Text)).ToList();
            }
            LoadProducts();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            products = ERMRepository.GetFullProducts(order);
            LoadProducts();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            if(row!=-2)
            {
                var productName = dataGridView1.Rows[row].Cells[1].Value.ToString();
                var addedProduct = products.First(p => p.product.name == productName
                 );
                ERMRepository.AddElementToOrder(order,addedProduct.product.id);
                MessageBox.Show("OK", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 6)
                    MessageBox.Show(products[e.RowIndex].product.comment);
                row = e.RowIndex;
            }
        }
    }
}
