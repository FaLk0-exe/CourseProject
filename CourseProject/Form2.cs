using CourseProject.Context;
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

namespace CourseProject
{
    public partial class Form2 : CustomForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void authorizationButton_Click(object sender, EventArgs e)
        {
            using (Vapeshop vp = new Vapeshop())
            {
                var employeers = vp.
                    employee.
                    Where(l => l.login == loginTextBox.Text && l.password == passwordTextBox.Text);
                if (employeers.Count() != 0)
                {
                    if (employeers.First().login == "admin")
                    {
                        AdminForm f = new AdminForm();
                        f.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Користувача з такими даними не знайдено!");
                    ClearTextBoxes();
                }
            }
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
    }
}
