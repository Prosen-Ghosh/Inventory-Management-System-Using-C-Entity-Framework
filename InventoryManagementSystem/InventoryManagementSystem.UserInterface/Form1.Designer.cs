namespace InventoryManagementSystem.UserInterface
{
    partial class LoginForm
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
            this.lvlUserId = new System.Windows.Forms.Label();
            this.lvlUserPassword = new System.Windows.Forms.Label();
            this.tbUserId = new System.Windows.Forms.TextBox();
            this.tbUserPassword = new System.Windows.Forms.TextBox();
            this.panellogin = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panellogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvlUserId
            // 
            this.lvlUserId.AutoSize = true;
            this.lvlUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlUserId.Location = new System.Drawing.Point(3, 30);
            this.lvlUserId.Name = "lvlUserId";
            this.lvlUserId.Size = new System.Drawing.Size(72, 16);
            this.lvlUserId.TabIndex = 0;
            this.lvlUserId.Text = "User ID : ";
            // 
            // lvlUserPassword
            // 
            this.lvlUserPassword.AutoSize = true;
            this.lvlUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlUserPassword.Location = new System.Drawing.Point(3, 101);
            this.lvlUserPassword.Name = "lvlUserPassword";
            this.lvlUserPassword.Size = new System.Drawing.Size(125, 16);
            this.lvlUserPassword.TabIndex = 1;
            this.lvlUserPassword.Text = "User Password : ";
            // 
            // tbUserId
            // 
            this.tbUserId.Location = new System.Drawing.Point(162, 26);
            this.tbUserId.Name = "tbUserId";
            this.tbUserId.Size = new System.Drawing.Size(227, 20);
            this.tbUserId.TabIndex = 2;
            // 
            // tbUserPassword
            // 
            this.tbUserPassword.Location = new System.Drawing.Point(162, 101);
            this.tbUserPassword.Name = "tbUserPassword";
            this.tbUserPassword.Size = new System.Drawing.Size(227, 20);
            this.tbUserPassword.TabIndex = 3;
            this.tbUserPassword.UseSystemPasswordChar = true;
            // 
            // panellogin
            // 
            this.panellogin.Controls.Add(this.lvlUserId);
            this.panellogin.Controls.Add(this.tbUserPassword);
            this.panellogin.Controls.Add(this.lvlUserPassword);
            this.panellogin.Controls.Add(this.tbUserId);
            this.panellogin.Location = new System.Drawing.Point(111, 66);
            this.panellogin.Name = "panellogin";
            this.panellogin.Size = new System.Drawing.Size(401, 140);
            this.panellogin.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(425, 221);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 29);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "LogIn";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 302);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.panellogin);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Log In";
            this.panellogin.ResumeLayout(false);
            this.panellogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lvlUserId;
        private System.Windows.Forms.Label lvlUserPassword;
        private System.Windows.Forms.TextBox tbUserId;
        private System.Windows.Forms.TextBox tbUserPassword;
        private System.Windows.Forms.Panel panellogin;
        private System.Windows.Forms.Button btnLogin;
    }
}

