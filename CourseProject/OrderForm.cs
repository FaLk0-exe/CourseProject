using CourseProject.custom_form;
using FastReport;
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
    public partial class OrderForm : Form
    {
        bool isEdited = false;
        customer_order order;
        public OrderForm(customer_order order)
        {
            this.order = order;
            InitializeComponent();
        }

        public void LoadOrder()
        {
            order = ERMRepository.GetOrderByCode(order.id);
            if (order != null)
            {
                if (order.order_status_id != 2)
                    authorizationButton.Visible = false;
                textBox1.Text = order.customer.initials;
                textBox2.Text = order.customer.phone_number;
                textBox4.Text = order.operation_time?.ToString("dd.MM.yyyy HH:mm");
                textBox5.Text = order.order_status.name;
                textBox3.Text = order.customer.address;
            }

        }

        public void LoadListOrder()
        {
            if (order != null)
            {
                dataGridView1.Rows.Clear();
                var orderList = ERMRepository.GetOrderListByOrderCode(order.id);
                foreach (var o in orderList)
                {
                    dataGridView1.Rows.Add(o.product.name, o.product.product_category.name,
                        string.Format("{0:0.00}",o.product.price.GetValueOrDefault()), o.product_amount);
                }
            }
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.DefaultCellStyle.ForeColor = Color.DarkOrchid;
            gunaGradientButton1.Text = "Відхилити" + Environment.NewLine + "замовлення";
            gunaGradientButton2.Text = "Змінити" + Environment.NewLine + "статус"
                + Environment.NewLine + "замовлення";
            gunaGradientButton3.Text = "Друкувати чек" + Environment.NewLine + "по замовленню";
            gunaGradientButton4.Text = "Дзвінок" + Environment.NewLine + "замовнику";
            LoadOrder();
            LoadListOrder();
        }

        private void OrderForm_Activated(object sender, EventArgs e)
        {
            LoadOrder();
            LoadListOrder();
            if (order.order_status.id == 6)
                Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (order != null)
            {
                if (!isEdited)
                {
                    isEdited = true;
                    pictureBox1.Image = Properties.Resources.kisspng_check_mark_checkbox_clip_art_yes_5ac17c66504f38_134743801522629734329;
                    textBox3.ReadOnly = false;
                }
                else
                {
                    isEdited = false;
                    pictureBox1.Image = Properties.Resources.edit_11_16;
                    textBox3.ReadOnly = true;
                    order.customer.address = textBox3.Text;
                    ERMRepository.EditCustomer(order.customer);
                }
            }
        }

        private void authorizationButton_Click(object sender, EventArgs e)
        {
            OrderListForm f = new OrderListForm(order);
            f.ShowDialog();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            var res=MessageBox.Show("Ви впевнені, що хочете відхилити замовлення?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res==DialogResult.Yes)
            {
                if (order.order_status.id != 5 && order.order_status.id != 6)
                {
                    ERMRepository.SetOrderStatus(order, 1);
                    MessageBox.Show("OK");
                    Close();
                }
                else
                {
                    MessageBox.Show("Замовлення вже було відправлено!","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            if (order.order_details.Count != 0)
            {
                SetStatusForm f = new SetStatusForm(order);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ви не можете змінити статус замовлення для пустого списку!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gunaGradientButton4_Click(object sender, EventArgs e)
        {
            WinMethods.OpenSkype(textBox2.Text);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {
            decimal sum = 0;
            Report f = Report.FromFile("Check.frx");
            List<ReportModel> models = new List<ReportModel>();
            foreach(DataGridViewRow r in dataGridView1.Rows)
            {
                models.Add(new ReportModel { name = r.Cells[0].Value.ToString(),
                    count =Convert.ToInt32(r.Cells[3].Value.ToString()),
                    price = r.Cells[2].Value.ToString()});
            }
            foreach(var n in models)
            {
                sum += n.count * Convert.ToDecimal(n.fullPrice);
            }
            
            f.RegisterData(models,"models");
            f.SetParameterValue("ID", order.id.ToString().PadLeft(6, '0'));
            f.SetParameterValue("adress", order.customer.address);
            f.SetParameterValue("phone", order.customer.phone_number);
            f.SetParameterValue("fio", order.customer.initials);
            f.SetParameterValue("sum", string.Format("{0:0.00}", sum));
            f.Show();
        }
    }
}
