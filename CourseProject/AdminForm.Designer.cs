
namespace CourseProject
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.authorizationButton = new Guna.UI.WinForms.GunaGradientButton();
            this.codeTextBox = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // authorizationButton
            // 
            this.authorizationButton.Animated = true;
            this.authorizationButton.AnimationHoverSpeed = 0.07F;
            this.authorizationButton.AnimationSpeed = 0.03F;
            this.authorizationButton.BackColor = System.Drawing.Color.Transparent;
            this.authorizationButton.BaseColor1 = System.Drawing.Color.PaleVioletRed;
            this.authorizationButton.BaseColor2 = System.Drawing.Color.MediumOrchid;
            this.authorizationButton.BorderColor = System.Drawing.Color.DarkOrchid;
            this.authorizationButton.BorderSize = 3;
            this.authorizationButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.authorizationButton.FocusedColor = System.Drawing.Color.Empty;
            this.authorizationButton.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorizationButton.ForeColor = System.Drawing.Color.White;
            this.authorizationButton.Image = null;
            this.authorizationButton.ImageSize = new System.Drawing.Size(20, 20);
            this.authorizationButton.Location = new System.Drawing.Point(141, 118);
            this.authorizationButton.Name = "authorizationButton";
            this.authorizationButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.authorizationButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.authorizationButton.OnHoverBorderColor = System.Drawing.Color.PaleVioletRed;
            this.authorizationButton.OnHoverForeColor = System.Drawing.Color.White;
            this.authorizationButton.OnHoverImage = null;
            this.authorizationButton.OnPressedColor = System.Drawing.Color.PaleVioletRed;
            this.authorizationButton.Size = new System.Drawing.Size(58, 35);
            this.authorizationButton.TabIndex = 1;
            this.authorizationButton.Text = "ОК";
            this.authorizationButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.authorizationButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.authorizationButton.Click += new System.EventHandler(this.authorizationButton_Click);
            // 
            // codeTextBox
            // 
            this.codeTextBox.BackColor = System.Drawing.Color.White;
            this.codeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.codeTextBox.FocusedLineColor = System.Drawing.Color.DarkOrchid;
            this.codeTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.codeTextBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.codeTextBox.LineColor = System.Drawing.Color.Gainsboro;
            this.codeTextBox.Location = new System.Drawing.Point(91, 70);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.PasswordChar = '\0';
            this.codeTextBox.SelectedText = "";
            this.codeTextBox.Size = new System.Drawing.Size(160, 26);
            this.codeTextBox.TabIndex = 3;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.gunaLabel1.Location = new System.Drawing.Point(115, 35);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(116, 18);
            this.gunaLabel1.TabIndex = 5;
            this.gunaLabel1.Text = "Код доступу:";
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = global::CourseProject.Properties.Resources.Снимок;
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(12, 8);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(90, 45);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 6;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(357, 212);
            this.Controls.Add(this.gunaCirclePictureBox1);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.authorizationButton);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientButton authorizationButton;
        private Guna.UI.WinForms.GunaLineTextBox codeTextBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
    }
}