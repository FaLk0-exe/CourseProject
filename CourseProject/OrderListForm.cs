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
    public partial class OrderListForm : Form
    {
        customer_order order;
        List<order_details> orderDetails;
        public OrderListForm(customer_order order)
        {
            this.order = order;
            InitializeComponent();
        }
        
        void LoadListOrder()
        {
            dataGridView1.Rows.Clear();
            orderDetails = ERMRepository.GetOrderListByOrderCode(order.id);
            foreach (var o in orderDetails)
            {
                dataGridView1.Rows.Add(o.product.name, o.product.product_category.name, string.Format("{0:0.00}", o.product.price.GetValueOrDefault()), o.product_amount);
            }
        }

        private void OrderListForm_Load(object sender, EventArgs e)
        {
            LoadListOrder();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int i = -2,
                        value = ERMRepository.GetProductByName(dataGridView1.Rows[e.RowIndex]
                        .Cells[0].Value.ToString()).product_amount_value.GetValueOrDefault();
                bool b = false;
                int oldValue = (int)dataGridView1.Rows[e.RowIndex].Cells[3].Value;
                if (e.ColumnIndex == 4)
                {
                    i = -1;

                    b = true;
                }
                if (e.ColumnIndex == 5)
                {
                    i = 1;

                    b = true;
                }
                if (b && (oldValue + i >= 1 && oldValue + i <= value))
                {
                    ERMRepository.ChangeOrderDetailValueAmount(orderDetails[e.RowIndex], i);
                    LoadListOrder();
                }
            }
        }

        private void authorizationButton_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow r in dataGridView1.Rows)
            {
                 
                if ((string)r.Cells[6].Value=="t")
                {
                    ERMRepository.RemoveElementFromOrder(orderDetails.First(o => o.product.name
                    == r.Cells[0].Value.ToString()));
                    orderDetails= ERMRepository.GetOrderListByOrderCode(order.id);
                }
            }
            LoadListOrder();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            ProductForm f = new ProductForm(order);
            f.ShowDialog();
        }

        private void OrderListForm_Activated(object sender, EventArgs e)
        {
            LoadListOrder();
        }
    }
}
