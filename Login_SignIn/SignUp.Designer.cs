namespace Note_Mini___Console___WinForms.Login_SignIn
{
    partial class SignUp
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
            this.MailBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PNumberBox = new System.Windows.Forms.TextBox();
            this.RadMale = new System.Windows.Forms.RadioButton();
            this.RadFemale = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(126, 311);
            this.LoginButton.Text = "Sign Up";
            this.LoginButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(149, 129);
            this.UsernameBox.Size = new System.Drawing.Size(116, 20);
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(149, 162);
            this.PassBox.Size = new System.Drawing.Size(116, 20);
            // 
            // GoToSign
            // 
            this.GoToSign.Location = new System.Drawing.Point(91, 187);
            this.GoToSign.Size = new System.Drawing.Size(0, 12);
            this.GoToSign.Text = "";
            this.GoToSign.Visible = false;
            // 
            // MailBox
            // 
            this.MailBox.Location = new System.Drawing.Point(149, 196);
            this.MailBox.Name = "MailBox";
            this.MailBox.Size = new System.Drawing.Size(116, 20);
            this.MailBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "E-Mail :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phone Number :";
            // 
            // PNumberBox
            // 
            this.PNumberBox.Location = new System.Drawing.Point(149, 231);
            this.PNumberBox.Name = "PNumberBox";
            this.PNumberBox.Size = new System.Drawing.Size(116, 20);
            this.PNumberBox.TabIndex = 8;
            // 
            // RadMale
            // 
            this.RadMale.AutoSize = true;
            this.RadMale.Location = new System.Drawing.Point(149, 264);
            this.RadMale.Name = "RadMale";
            this.RadMale.Size = new System.Drawing.Size(48, 17);
            this.RadMale.TabIndex = 10;
            this.RadMale.TabStop = true;
            this.RadMale.Text = "Male";
            this.RadMale.UseVisualStyleBackColor = true;
            // 
            // RadFemale
            // 
            this.RadFemale.AutoSize = true;
            this.RadFemale.Location = new System.Drawing.Point(206, 264);
            this.RadFemale.Name = "RadFemale";
            this.RadFemale.Size = new System.Drawing.Size(59, 17);
            this.RadFemale.TabIndex = 11;
            this.RadFemale.TabStop = true;
            this.RadFemale.Text = "Female";
            this.RadFemale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Gender :";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RadFemale);
            this.Controls.Add(this.RadMale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PNumberBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MailBox);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Controls.SetChildIndex(this.MailBox, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.PNumberBox, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.RadMale, 0);
            this.Controls.SetChildIndex(this.RadFemale, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.LoginButton, 0);
            this.Controls.SetChildIndex(this.UsernameBox, 0);
            this.Controls.SetChildIndex(this.PassBox, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.GoToSign, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MailBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PNumberBox;
        private System.Windows.Forms.RadioButton RadMale;
        private System.Windows.Forms.RadioButton RadFemale;
        private System.Windows.Forms.Label label5;
    }
}