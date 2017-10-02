namespace Npman.Dialogs
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Username_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.Login_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.SignUp_ll = new System.Windows.Forms.LinkLabel();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.User_Image = new System.Windows.Forms.PictureBox();
            this.Pass_Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pass_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Username_label
            // 
            this.Username_label.AutoSize = true;
            this.Username_label.Location = new System.Drawing.Point(46, 52);
            this.Username_label.Name = "Username_label";
            this.Username_label.Size = new System.Drawing.Size(55, 13);
            this.Username_label.TabIndex = 0;
            this.Username_label.Text = "Username";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(48, 106);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(53, 13);
            this.Password_label.TabIndex = 1;
            this.Password_label.Text = "Password";
            // 
            // Username
            // 
            this.err.SetError(this.Username, "Username does not exists");
            this.err.SetIconPadding(this.Username, 5);
            this.Username.Location = new System.Drawing.Point(116, 49);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(426, 20);
            this.Username.TabIndex = 2;
            this.Username.TextChanged += new System.EventHandler(this.Text_Changed);
            this.Username.Enter += new System.EventHandler(this.Username_entered);
            this.Username.Validating += new System.ComponentModel.CancelEventHandler(this.Validating_username);
            // 
            // Login_btn
            // 
            this.Login_btn.Location = new System.Drawing.Point(372, 148);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(75, 23);
            this.Login_btn.TabIndex = 4;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.Login_Clicked);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(467, 148);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.Cancel_btn.TabIndex = 5;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_Clicked);
            // 
            // Password
            // 
            this.err.SetError(this.Password, "Wrong Password");
            this.err.SetIconPadding(this.Password, 5);
            this.Password.Location = new System.Drawing.Point(116, 103);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(426, 20);
            this.Password.TabIndex = 3;
            this.Password.UseSystemPasswordChar = true;
            this.Password.Enter += new System.EventHandler(this.Password_Entered);
            // 
            // SignUp_ll
            // 
            this.SignUp_ll.AutoSize = true;
            this.SignUp_ll.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SignUp_ll.Location = new System.Drawing.Point(113, 135);
            this.SignUp_ll.Name = "SignUp_ll";
            this.SignUp_ll.Size = new System.Drawing.Size(162, 13);
            this.SignUp_ll.TabIndex = 6;
            this.SignUp_ll.TabStop = true;
            this.SignUp_ll.Text = "*Dont\'t Have A Account Sign Up";
            this.SignUp_ll.Click += new System.EventHandler(this.SignUp_Clicked);
            // 
            // err
            // 
            this.err.BlinkRate = 1000;
            this.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.err.ContainerControl = this;
            this.err.Icon = ((System.Drawing.Icon)(resources.GetObject("err.Icon")));
            // 
            // User_Image
            // 
            this.User_Image.Image = ((System.Drawing.Image)(resources.GetObject("User_Image.Image")));
            this.User_Image.Location = new System.Drawing.Point(548, 52);
            this.User_Image.Name = "User_Image";
            this.User_Image.Size = new System.Drawing.Size(19, 20);
            this.User_Image.TabIndex = 10;
            this.User_Image.TabStop = false;
            // 
            // Pass_Image
            // 
            this.Pass_Image.Image = ((System.Drawing.Image)(resources.GetObject("Pass_Image.Image")));
            this.Pass_Image.Location = new System.Drawing.Point(548, 106);
            this.Pass_Image.Name = "Pass_Image";
            this.Pass_Image.Size = new System.Drawing.Size(19, 20);
            this.Pass_Image.TabIndex = 11;
            this.Pass_Image.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.Login_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 221);
            this.Controls.Add(this.Pass_Image);
            this.Controls.Add(this.User_Image);
            this.Controls.Add(this.SignUp_ll);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Username_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pass_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.LinkLabel SignUp_ll;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.PictureBox Pass_Image;
        private System.Windows.Forms.PictureBox User_Image;
    }
}