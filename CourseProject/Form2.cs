using CourseProject.custom_form;
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
            using (VP vp = new VP())
            {
                var user = vp.
                    user.
                    FirstOrDefault(l => l.login == loginTextBox.Text && l.password == passwordTextBox.Text);
                if (user != null)
                {
                 
                        AdminMenuForm f = new AdminMenuForm(user.login);
                        f.Show();
                        this.Hide();
                   
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
