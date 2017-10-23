namespace DhalTok
{
    partial class Login
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
            this.tbUname = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbUname
            // 
            this.tbUname.CausesValidation = false;
            this.tbUname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUname.Location = new System.Drawing.Point(190, 142);
            this.tbUname.Name = "tbUname";
            this.tbUname.Size = new System.Drawing.Size(257, 25);
            this.tbUname.TabIndex = 1;
            this.tbUname.TextChanged += new System.EventHandler(this.tbUname_TextChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(190, 181);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(257, 25);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.LimeGreen;
            this.btLogin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btLogin.Location = new System.Drawing.Point(333, 227);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(102, 32);
            this.btLogin.TabIndex = 2;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 35.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(208, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "DhalTok ";
            // 
            // btRegister
            // 
            this.btRegister.BackColor = System.Drawing.Color.RoyalBlue;
            this.btRegister.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btRegister.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btRegister.Location = new System.Drawing.Point(203, 227);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(103, 32);
            this.btRegister.TabIndex = 3;
            this.btRegister.Text = "Register";
            this.btRegister.UseVisualStyleBackColor = false;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(636, 377);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUname);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dhaltok App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbUname;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRegister;
    }
}