using CourseProject.CustomForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            this.KeyPreview = true;
        }

        private void Authorize()
        {
            using (VapeshopContext vp = new VapeshopContext())
            {
                var employeers = vp.
                    employee.
                    Where(l => l.login == loginTextBox.Text && l.password == passwordTextBox.Text);
                if (employeers.Count() != 0)
                {
                    if (employeers.First().login == "admin")
                    {
                        AdminForm f = new AdminForm();
                        f.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Користувача з такими даними не знайдено!");
                    ClearTextBoxes();
                }
            }
        }

        private void authorizationButton_Click(object sender, EventArgs e)
        {
            Authorize();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                Authorize();
            }
        }
    }
}
