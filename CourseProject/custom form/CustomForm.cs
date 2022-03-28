using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;

namespace CourseProject.CustomForms
{
    public class CustomForm : Form
    {
        public void ClearTextBoxes()
        {
            foreach (Control c in Controls)
            {
                if (c is GunaLineTextBox)
                {
                    ((GunaLineTextBox)c).Text = "";
                }
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
            }
        }
        private void CustomForm_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CustomForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "CustomForm";
            this.Load += new System.EventHandler(this.CustomForm_Load_1);
            this.ResumeLayout(false);

        }

        private void CustomForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
