namespace Npman.Dialogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.user = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.sign_up = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.con_pass = new System.Windows.Forms.TextBox();
            this.pass_match = new System.Windows.Forms.Label();
            this.pass_strength = new System.Windows.Forms.Label();
            this.username_exists = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(43, 48);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(83, 13);
            this.user.TabIndex = 0;
            this.user.Text = "Enter Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Password";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(157, 45);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(359, 20);
            this.username.TabIndex = 3;
            this.username.Enter += new System.EventHandler(this.Username_Entered);
            this.username.Validating += new System.ComponentModel.CancelEventHandler(this.Username_Validating);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(157, 89);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(359, 20);
            this.pass.TabIndex = 4;
            this.pass.UseSystemPasswordChar = true;
            this.pass.Enter += new System.EventHandler(this.Password_Entered);
            this.pass.Validating += new System.ComponentModel.CancelEventHandler(this.Password_Validating);
            // 
            // sign_up
            // 
            this.sign_up.Location = new System.Drawing.Point(331, 179);
            this.sign_up.Name = "sign_up";
            this.sign_up.Size = new System.Drawing.Size(75, 23);
            this.sign_up.TabIndex = 6;
            this.sign_up.Text = "Sign Up";
            this.sign_up.UseVisualStyleBackColor = true;
            this.sign_up.Click += new System.EventHandler(this.Sign_Up_Clicked);
            // 
            // login
            // 
            this.login.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.login.Location = new System.Drawing.Point(441, 179);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 7;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.Login_Clicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Confirm Password";
            // 
            // con_pass
            // 
            this.con_pass.Location = new System.Drawing.Point(157, 130);
            this.con_pass.Name = "con_pass";
            this.con_pass.Size = new System.Drawing.Size(359, 20);
            this.con_pass.TabIndex = 5;
            this.con_pass.UseSystemPasswordChar = true;
            this.con_pass.Enter += new System.EventHandler(this.Confirm_Password_Entered);
            this.con_pass.Validating += new System.ComponentModel.CancelEventHandler(this.Confirm_Password_Validating);
            // 
            // pass_match
            // 
            this.pass_match.AutoSize = true;
            this.pass_match.Location = new System.Drawing.Point(154, 162);
            this.pass_match.Name = "pass_match";
            this.pass_match.Size = new System.Drawing.Size(0, 13);
            this.pass_match.TabIndex = 8;
            // 
            // pass_strength
            // 
            this.pass_strength.AutoSize = true;
            this.pass_strength.Location = new System.Drawing.Point(154, 117);
            this.pass_strength.Name = "pass_strength";
            this.pass_strength.Size = new System.Drawing.Size(0, 13);
            this.pass_strength.TabIndex = 9;
            // 
            // username_exists
            // 
            this.username_exists.AutoSize = true;
            this.username_exists.Location = new System.Drawing.Point(154, 73);
            this.username_exists.Name = "username_exists";
            this.username_exists.Size = new System.Drawing.Size(0, 13);
            this.username_exists.TabIndex = 10;
            // 
            // SignUp
            // 
            this.AcceptButton = this.sign_up;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.login;
            this.ClientSize = new System.Drawing.Size(582, 237);
            this.Controls.Add(this.username_exists);
            this.Controls.Add(this.pass_strength);
            this.Controls.Add(this.pass_match);
            this.Controls.Add(this.con_pass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.sign_up);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button sign_up;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox con_pass;
        private System.Windows.Forms.Label pass_match;
        private System.Windows.Forms.Label pass_strength;
        private System.Windows.Forms.Label username_exists;
    }
}