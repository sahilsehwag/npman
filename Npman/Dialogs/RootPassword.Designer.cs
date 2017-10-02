namespace Npman.Dialogs
{
    partial class RootPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RootPassword));
            this.Root = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.WrongPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Root
            // 
            this.Root.AutoSize = true;
            this.Root.Location = new System.Drawing.Point(25, 22);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(252, 13);
            this.Root.TabIndex = 0;
            this.Root.Text = "To Complete Sign Up Process Enter Root Password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(283, 19);
            this.password.Name = "password";
            this.password.PasswordChar = '_';
            this.password.Size = new System.Drawing.Size(171, 20);
            this.password.TabIndex = 1;
            this.password.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Password_Entered);
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(331, 59);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(123, 23);
            this.Confirm.TabIndex = 2;
            this.Confirm.Text = "Create Account";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Create_Account_Clicked);
            // 
            // WrongPassword
            // 
            this.WrongPassword.AutoSize = true;
            this.WrongPassword.ForeColor = System.Drawing.Color.Red;
            this.WrongPassword.Location = new System.Drawing.Point(25, 69);
            this.WrongPassword.Name = "WrongPassword";
            this.WrongPassword.Size = new System.Drawing.Size(88, 13);
            this.WrongPassword.TabIndex = 3;
            this.WrongPassword.Text = "Wrong Password";
            // 
            // RootPassword
            // 
            this.AcceptButton = this.Confirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 94);
            this.Controls.Add(this.WrongPassword);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.password);
            this.Controls.Add(this.Root);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RootPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RootPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Root;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Label WrongPassword;
    }
}