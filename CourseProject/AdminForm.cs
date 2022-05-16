using System;
using System.Windows.Forms;
using CourseProject.custom_form;
using CourseProject.CustomForms;
using CourseProject.Security;

namespace CourseProject
{
    public partial class AdminForm : CustomForm
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void CheckPassword()
        {
            if (!SecureChecker.CheckPassword(codeTextBox.Text))
            {
                MessageBox.Show("Неправильно введений код доступу!");
                ClearTextBoxes();
            }
          //  AdminMenuForm f = new AdminMenuForm();
          //  f.Show();
          //  this.Hide();
        }

        private void authorizationButton_Click(object sender, EventArgs e)
        {
            CheckPassword();   
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void AdminForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                CheckPassword();
        }
    }
}
