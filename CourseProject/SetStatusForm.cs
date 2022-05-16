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
    public partial class SetStatusForm : Form
    {
        customer_order order;
        public SetStatusForm(customer_order order)
        {
            this.order = order;
            InitializeComponent();
        }

        private void SetStatusForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(ERMRepository.GetStatuses().
                Where(c=>c.id!=1&&
            c.id>order.order_status.id).
                Select(s=>s.name).ToArray());
        }

        private void authorizationButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                ERMRepository.SetOrderStatus(order, ERMRepository.GetStatuses().First(s => s.name == comboBox1.Text).id);
                MessageBox.Show("OK", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Спочатку оберіть статус замовлення",
                    "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
