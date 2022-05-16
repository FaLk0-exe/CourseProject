
namespace CourseProject
{
    partial class SetStatusForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.authorizationButton = new Guna.UI.WinForms.GunaGradientButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label1.Location = new System.Drawing.Point(101, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Оберіть статус";
            // 
            // authorizationButton
            // 
            this.authorizationButton.Animated = true;
            this.authorizationButton.AnimationHoverSpeed = 0.07F;
            this.authorizationButton.AnimationSpeed = 0.03F;
            this.authorizationButton.BackColor = System.Drawing.Color.Transparent;
            this.authorizationButton.BaseColor1 = System.Drawing.Color.MediumOrchid;
            this.authorizationButton.BaseColor2 = System.Drawing.Color.MediumOrchid;
            this.authorizationButton.BorderColor = System.Drawing.Color.DarkOrchid;
            this.authorizationButton.BorderSize = 3;
            this.authorizationButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.authorizationButton.FocusedColor = System.Drawing.Color.Empty;
            this.authorizationButton.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorizationButton.ForeColor = System.Drawing.Color.White;
            this.authorizationButton.Image = null;
            this.authorizationButton.ImageSize = new System.Drawing.Size(20, 20);
            this.authorizationButton.Location = new System.Drawing.Point(104, 138);
            this.authorizationButton.Name = "authorizationButton";
            this.authorizationButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.authorizationButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.authorizationButton.OnHoverBorderColor = System.Drawing.Color.PaleVioletRed;
            this.authorizationButton.OnHoverForeColor = System.Drawing.Color.White;
            this.authorizationButton.OnHoverImage = null;
            this.authorizationButton.OnPressedColor = System.Drawing.Color.PaleVioletRed;
            this.authorizationButton.Size = new System.Drawing.Size(123, 35);
            this.authorizationButton.TabIndex = 5;
            this.authorizationButton.Text = "Примінити";
            this.authorizationButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.authorizationButton.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            this.authorizationButton.Click += new System.EventHandler(this.authorizationButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // SetStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 212);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.authorizationButton);
            this.Controls.Add(this.label1);
            this.Name = "SetStatusForm";
            this.Text = "SetStatusForm";
            this.Load += new System.EventHandler(this.SetStatusForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaGradientButton authorizationButton;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}