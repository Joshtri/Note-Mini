namespace Note_Mini___Console___WinForms.Login_SignIn
{
    partial class Login_N_Sign
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
            this.Button_Login = new System.Windows.Forms.Button();
            this.ButtonSign_Up = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Login
            // 
            this.Button_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Login.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Login.Location = new System.Drawing.Point(100, 240);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(107, 41);
            this.Button_Login.TabIndex = 0;
            this.Button_Login.Text = "Login";
            this.Button_Login.UseVisualStyleBackColor = true;
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // ButtonSign_Up
            // 
            this.ButtonSign_Up.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonSign_Up.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSign_Up.Location = new System.Drawing.Point(450, 240);
            this.ButtonSign_Up.Name = "ButtonSign_Up";
            this.ButtonSign_Up.Size = new System.Drawing.Size(107, 41);
            this.ButtonSign_Up.TabIndex = 1;
            this.ButtonSign_Up.Text = "Sign Up";
            this.ButtonSign_Up.UseVisualStyleBackColor = true;
            this.ButtonSign_Up.Click += new System.EventHandler(this.ButtonSign_Up_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Note_Mini___Console___WinForms.Properties.Resources.icon_notes;
            this.pictureBox1.Location = new System.Drawing.Point(281, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Login_N_Sign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(674, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ButtonSign_Up);
            this.Controls.Add(this.Button_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Login_N_Sign";
            this.Text = "Notes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Login;
        private System.Windows.Forms.Button ButtonSign_Up;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}