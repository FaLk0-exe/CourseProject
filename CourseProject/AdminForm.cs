using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseProject.CustomForms;
using slib;

namespace CourseProject
{
    public partial class AdminForm : CustomForm
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void authorizationButton_Click(object sender, EventArgs e)
        {
            if(!SecureChecker.CheckPassword(codeTextBox.Text))
            {
                MessageBox.Show("Неправильно введений код доступу!");
                ClearTextBoxes();
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
