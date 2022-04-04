
namespace CourseProject
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.authorizationButton = new Guna.UI.WinForms.GunaGradientButton();
            this.loginTextBox = new Guna.UI.WinForms.GunaLineTextBox();
            this.passwordTextBox = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
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
            this.authorizationButton.Location = new System.Drawing.Point(69, 317);
            this.authorizationButton.Name = "authorizationButton";
            this.authorizationButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.authorizationButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.authorizationButton.OnHoverBorderColor = System.Drawing.Color.PaleVioletRed;
            this.authorizationButton.OnHoverForeColor = System.Drawing.Color.White;
            this.authorizationButton.OnHoverImage = null;
            this.authorizationButton.OnPressedColor = System.Drawing.Color.PaleVioletRed;
            this.authorizationButton.Size = new System.Drawing.Size(116, 43);
            this.authorizationButton.TabIndex = 0;
            this.authorizationButton.Text = "Увійти";
            this.authorizationButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.authorizationButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.authorizationButton.Click += new System.EventHandler(this.authorizationButton_Click);
            // 
            // loginTextBox
            // 
            this.loginTextBox.BackColor = System.Drawing.Color.White;
            this.loginTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginTextBox.FocusedLineColor = System.Drawing.Color.DarkOrchid;
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.ForeColor = System.Drawing.Color.DarkOrchid;
            this.loginTextBox.LineColor = System.Drawing.Color.Gainsboro;
            this.loginTextBox.Location = new System.Drawing.Point(30, 168);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.PasswordChar = '\0';
            this.loginTextBox.SelectedText = "";
            this.loginTextBox.Size = new System.Drawing.Size(200, 32);
            this.loginTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.White;
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.FocusedLineColor = System.Drawing.Color.DarkOrchid;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.DarkOrchid;
            this.passwordTextBox.LineColor = System.Drawing.Color.Gainsboro;
            this.passwordTextBox.Location = new System.Drawing.Point(30, 252);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.Size = new System.Drawing.Size(200, 32);
            this.passwordTextBox.TabIndex = 3;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.gunaLabel1.Location = new System.Drawing.Point(93, 134);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(62, 18);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "  Логін";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.DarkOrchid;
            this.gunaLabel2.Location = new System.Drawing.Point(76, 225);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(85, 18);
            this.gunaLabel2.TabIndex = 5;
            this.gunaLabel2.Text = "    Пароль";
            this.gunaLabel2.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = global::CourseProject.Properties.Resources.Снимок;
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(60, 12);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(139, 79);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 1;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(264, 415);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.gunaCirclePictureBox1);
            this.Controls.Add(this.authorizationButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизація";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form2_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientButton authorizationButton;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private Guna.UI.WinForms.GunaLineTextBox loginTextBox;
        private Guna.UI.WinForms.GunaLineTextBox passwordTextBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
    }
}