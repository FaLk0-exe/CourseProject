using CourseProject.CustomForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.custom_form
{
    public partial class AdminMenuForm : CustomForm
    {
        
        List<dynamic> orders = new List<dynamic>();
        bool isOrderedByAsc=true;
        int? lastColumn;
        public AdminMenuForm(string login)
        {
            InitializeComponent();
            label4.Text += login;
        }

        void LoadOrders(List<dynamic> orders)
        {
            dataGridView1.Rows.Clear();
            if(orders.Count!=0)
            {
                foreach(var o in orders)
                {
                    dataGridView1.Rows.Add(o.OrderCode.ToString().PadLeft(6,'0'), o.CustomerPhone, o.OperationTime, o.OrderStatus);
                }
            }
        }

        void LoadOrders()
        {
            LoadOrders(orders);
        }

        private void MenuFormPrototype_Load(object sender, EventArgs e)
        {
            dataGridView1.EnableHeadersVisualStyles=false;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            orders = ERMRepository.GetDynamicOrders();
            LoadOrders();
        }

     


        private void tabControl1_DrawItem_1(object sender, DrawItemEventArgs e)
        {

        }

        private void authorizationButton_Click(object sender, EventArgs e)
        {
            orders = ERMRepository.GetDynamicOrders();
            if(textBox2.Text!="")
            {
                orders = orders.Where(o => o.OrderCode==
                              Convert.ToInt32(textBox2.Text)).ToList<dynamic>();
            }
            if(textBox1.Text!="")
            {
                orders = orders.Where(o => o.CustomerPhone.
                Contains(textBox1.Text)).ToList<dynamic>();
            }
            if(comboBox1.SelectedIndex!=-1)
            {
                orders = orders.Where(o => o.OrderStatus ==
                  comboBox1.SelectedItem.ToString()).ToList<dynamic>();
            }
            LoadOrders();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox1.Text = "";
            orders = ERMRepository.GetDynamicOrders();
            LoadOrders();
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != 4)
            {
                if (e.ColumnIndex == 0)
                {
                    orders = orders.OrderBy(o => o.OrderCode).ToList<dynamic>();
                }
                if (e.ColumnIndex == 1)
                {
                    orders = orders.OrderBy(o => o.CustomerPhone).ToList<dynamic>();
                }
                if (e.ColumnIndex == 2)
                {
                    orders = orders.OrderBy(o => o.OperationTime).ToList<dynamic>();
                }
                if (e.ColumnIndex == 3)
                {
                    orders = orders.OrderBy(o => o.OrderStatus).ToList<dynamic>();
                }
                if (lastColumn == null)
                {
                    lastColumn = e.ColumnIndex;
                }
                if (lastColumn == e.ColumnIndex)
                {
                    if (!isOrderedByAsc)
                    {
                        orders.Reverse();
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
                
                LoadOrders();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==4&&e.RowIndex>=0&&dataGridView1.Rows[e.RowIndex].Cells[0]
                .Value!=null)
            {
                OrderForm f = new OrderForm(ERMRepository.GetOrderByCode(
                    Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value)));
                f.ShowDialog();
            }
        }

        private void AdminMenuForm_Activated(object sender, EventArgs e)
        {
            orders = ERMRepository.GetDynamicOrders();
            LoadOrders();
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {

        }

        private void tabPage1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
