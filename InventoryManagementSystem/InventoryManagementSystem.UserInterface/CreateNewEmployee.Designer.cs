namespace InventoryManagementSystem.UserInterface
{
    partial class CreateNewEmployee
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
            this.panelCreateNewEmployee = new System.Windows.Forms.Panel();
            this.tbNewUserPassword = new System.Windows.Forms.TextBox();
            this.tbNewUserAddress = new System.Windows.Forms.TextBox();
            this.tbNewUserPhone = new System.Windows.Forms.TextBox();
            this.tbNewUserEmail = new System.Windows.Forms.TextBox();
            this.tbNewUserName = new System.Windows.Forms.TextBox();
            this.lvlNewUserPassword = new System.Windows.Forms.Label();
            this.lvlNewUserAddress = new System.Windows.Forms.Label();
            this.comboBoxNewUserType = new System.Windows.Forms.ComboBox();
            this.lvlNewUserName = new System.Windows.Forms.Label();
            this.lvlNewUserType = new System.Windows.Forms.Label();
            this.lvlNewUserEmail = new System.Windows.Forms.Label();
            this.lvlNewUserPhone = new System.Windows.Forms.Label();
            this.tbNewUserId = new System.Windows.Forms.TextBox();
            this.lvlNewUserId = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panelCreateNewEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCreateNewEmployee
            // 
            this.panelCreateNewEmployee.Controls.Add(this.tbNewUserPassword);
            this.panelCreateNewEmployee.Controls.Add(this.tbNewUserAddress);
            this.panelCreateNewEmployee.Controls.Add(this.tbNewUserPhone);
            this.panelCreateNewEmployee.Controls.Add(this.tbNewUserEmail);
            this.panelCreateNewEmployee.Controls.Add(this.tbNewUserName);
            this.panelCreateNewEmployee.Controls.Add(this.lvlNewUserPassword);
            this.panelCreateNewEmployee.Controls.Add(this.lvlNewUserAddress);
            this.panelCreateNewEmployee.Controls.Add(this.comboBoxNewUserType);
            this.panelCreateNewEmployee.Controls.Add(this.lvlNewUserName);
            this.panelCreateNewEmployee.Controls.Add(this.lvlNewUserType);
            this.panelCreateNewEmployee.Controls.Add(this.lvlNewUserEmail);
            this.panelCreateNewEmployee.Controls.Add(this.lvlNewUserPhone);
            this.panelCreateNewEmployee.Controls.Add(this.tbNewUserId);
            this.panelCreateNewEmployee.Controls.Add(this.lvlNewUserId);
            this.panelCreateNewEmployee.Location = new System.Drawing.Point(13, 13);
            this.panelCreateNewEmployee.Name = "panelCreateNewEmployee";
            this.panelCreateNewEmployee.Size = new System.Drawing.Size(371, 320);
            this.panelCreateNewEmployee.TabIndex = 0;
            // 
            // tbNewUserPassword
            // 
            this.tbNewUserPassword.Location = new System.Drawing.Point(162, 279);
            this.tbNewUserPassword.Name = "tbNewUserPassword";
            this.tbNewUserPassword.Size = new System.Drawing.Size(190, 20);
            this.tbNewUserPassword.TabIndex = 13;
            // 
            // tbNewUserAddress
            // 
            this.tbNewUserAddress.Location = new System.Drawing.Point(162, 204);
            this.tbNewUserAddress.Multiline = true;
            this.tbNewUserAddress.Name = "tbNewUserAddress";
            this.tbNewUserAddress.Size = new System.Drawing.Size(190, 50);
            this.tbNewUserAddress.TabIndex = 12;
            // 
            // tbNewUserPhone
            // 
            this.tbNewUserPhone.Location = new System.Drawing.Point(162, 165);
            this.tbNewUserPhone.Name = "tbNewUserPhone";
            this.tbNewUserPhone.Size = new System.Drawing.Size(190, 20);
            this.tbNewUserPhone.TabIndex = 11;
            // 
            // tbNewUserEmail
            // 
            this.tbNewUserEmail.Location = new System.Drawing.Point(162, 128);
            this.tbNewUserEmail.Name = "tbNewUserEmail";
            this.tbNewUserEmail.Size = new System.Drawing.Size(190, 20);
            this.tbNewUserEmail.TabIndex = 10;
            // 
            // tbNewUserName
            // 
            this.tbNewUserName.Location = new System.Drawing.Point(162, 59);
            this.tbNewUserName.Name = "tbNewUserName";
            this.tbNewUserName.Size = new System.Drawing.Size(190, 20);
            this.tbNewUserName.TabIndex = 9;
            // 
            // lvlNewUserPassword
            // 
            this.lvlNewUserPassword.AutoSize = true;
            this.lvlNewUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlNewUserPassword.Location = new System.Drawing.Point(3, 283);
            this.lvlNewUserPassword.Name = "lvlNewUserPassword";
            this.lvlNewUserPassword.Size = new System.Drawing.Size(117, 16);
            this.lvlNewUserPassword.TabIndex = 8;
            this.lvlNewUserPassword.Text = "User Password:";
            // 
            // lvlNewUserAddress
            // 
            this.lvlNewUserAddress.AutoSize = true;
            this.lvlNewUserAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlNewUserAddress.Location = new System.Drawing.Point(3, 204);
            this.lvlNewUserAddress.Name = "lvlNewUserAddress";
            this.lvlNewUserAddress.Size = new System.Drawing.Size(111, 16);
            this.lvlNewUserAddress.TabIndex = 7;
            this.lvlNewUserAddress.Text = "User Address :";
            // 
            // comboBoxNewUserType
            // 
            this.comboBoxNewUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNewUserType.FormattingEnabled = true;
            this.comboBoxNewUserType.Location = new System.Drawing.Point(162, 90);
            this.comboBoxNewUserType.Name = "comboBoxNewUserType";
            this.comboBoxNewUserType.Size = new System.Drawing.Size(190, 24);
            this.comboBoxNewUserType.TabIndex = 6;
            this.comboBoxNewUserType.Text = "Select A User Type";
            this.comboBoxNewUserType.SelectedIndexChanged += new System.EventHandler(this.comboBoxNewUserType_SelectedIndexChanged);
            // 
            // lvlNewUserName
            // 
            this.lvlNewUserName.AutoSize = true;
            this.lvlNewUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlNewUserName.Location = new System.Drawing.Point(3, 60);
            this.lvlNewUserName.Name = "lvlNewUserName";
            this.lvlNewUserName.Size = new System.Drawing.Size(94, 16);
            this.lvlNewUserName.TabIndex = 5;
            this.lvlNewUserName.Text = "User Name :";
            // 
            // lvlNewUserType
            // 
            this.lvlNewUserType.AutoSize = true;
            this.lvlNewUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlNewUserType.Location = new System.Drawing.Point(3, 96);
            this.lvlNewUserType.Name = "lvlNewUserType";
            this.lvlNewUserType.Size = new System.Drawing.Size(89, 16);
            this.lvlNewUserType.TabIndex = 4;
            this.lvlNewUserType.Text = "User Type :";
            // 
            // lvlNewUserEmail
            // 
            this.lvlNewUserEmail.AutoSize = true;
            this.lvlNewUserEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlNewUserEmail.Location = new System.Drawing.Point(3, 132);
            this.lvlNewUserEmail.Name = "lvlNewUserEmail";
            this.lvlNewUserEmail.Size = new System.Drawing.Size(92, 16);
            this.lvlNewUserEmail.TabIndex = 3;
            this.lvlNewUserEmail.Text = "User Email :";
            // 
            // lvlNewUserPhone
            // 
            this.lvlNewUserPhone.AutoSize = true;
            this.lvlNewUserPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlNewUserPhone.Location = new System.Drawing.Point(3, 165);
            this.lvlNewUserPhone.Name = "lvlNewUserPhone";
            this.lvlNewUserPhone.Size = new System.Drawing.Size(93, 16);
            this.lvlNewUserPhone.TabIndex = 2;
            this.lvlNewUserPhone.Text = "User Phone:";
            // 
            // tbNewUserId
            // 
            this.tbNewUserId.Location = new System.Drawing.Point(162, 17);
            this.tbNewUserId.Name = "tbNewUserId";
            this.tbNewUserId.Size = new System.Drawing.Size(190, 20);
            this.tbNewUserId.TabIndex = 1;
            // 
            // lvlNewUserId
            // 
            this.lvlNewUserId.AutoSize = true;
            this.lvlNewUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlNewUserId.Location = new System.Drawing.Point(3, 22);
            this.lvlNewUserId.Name = "lvlNewUserId";
            this.lvlNewUserId.Size = new System.Drawing.Size(66, 16);
            this.lvlNewUserId.TabIndex = 0;
            this.lvlNewUserId.Text = "User Id :";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(269, 339);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(96, 40);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // CreateNewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 385);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.panelCreateNewEmployee);
            this.Name = "CreateNewEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Employee";
            this.panelCreateNewEmployee.ResumeLayout(false);
            this.panelCreateNewEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCreateNewEmployee;
        private System.Windows.Forms.Label lvlNewUserName;
        private System.Windows.Forms.Label lvlNewUserType;
        private System.Windows.Forms.Label lvlNewUserEmail;
        private System.Windows.Forms.Label lvlNewUserPhone;
        private System.Windows.Forms.TextBox tbNewUserId;
        private System.Windows.Forms.Label lvlNewUserId;
        private System.Windows.Forms.TextBox tbNewUserPassword;
        private System.Windows.Forms.TextBox tbNewUserAddress;
        private System.Windows.Forms.TextBox tbNewUserPhone;
        private System.Windows.Forms.TextBox tbNewUserEmail;
        private System.Windows.Forms.TextBox tbNewUserName;
        private System.Windows.Forms.Label lvlNewUserPassword;
        private System.Windows.Forms.Label lvlNewUserAddress;
        private System.Windows.Forms.ComboBox comboBoxNewUserType;
        private System.Windows.Forms.Button btnSubmit;
    }
}