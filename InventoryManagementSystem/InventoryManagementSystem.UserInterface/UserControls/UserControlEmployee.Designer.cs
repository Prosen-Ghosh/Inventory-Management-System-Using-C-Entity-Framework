namespace InventoryManagementSystem.UserInterface.UserControls
{
    partial class UserControlEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbEmployeeSearchByIdOrName = new System.Windows.Forms.TextBox();
            this.cbEmployeeSearvhByIdOrName = new System.Windows.Forms.ComboBox();
            this.panelForEmployeeButton = new System.Windows.Forms.Panel();
            this.btnCreateNewEmployee = new System.Windows.Forms.Button();
            this.btnEmployeeDelete = new System.Windows.Forms.Button();
            this.btmEmployeUpdate = new System.Windows.Forms.Button();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.SelectCustomer = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeePhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panelForEmployeeButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // tbEmployeeSearchByIdOrName
            // 
            this.tbEmployeeSearchByIdOrName.Location = new System.Drawing.Point(116, 4);
            this.tbEmployeeSearchByIdOrName.Name = "tbEmployeeSearchByIdOrName";
            this.tbEmployeeSearchByIdOrName.Size = new System.Drawing.Size(120, 20);
            this.tbEmployeeSearchByIdOrName.TabIndex = 3;
            this.tbEmployeeSearchByIdOrName.TextChanged += new System.EventHandler(this.tbEmployeeSearchByIdOrName_TextChanged);
            // 
            // cbEmployeeSearvhByIdOrName
            // 
            this.cbEmployeeSearvhByIdOrName.FormattingEnabled = true;
            this.cbEmployeeSearvhByIdOrName.Location = new System.Drawing.Point(3, 3);
            this.cbEmployeeSearvhByIdOrName.Name = "cbEmployeeSearvhByIdOrName";
            this.cbEmployeeSearvhByIdOrName.Size = new System.Drawing.Size(107, 21);
            this.cbEmployeeSearvhByIdOrName.TabIndex = 2;
            this.cbEmployeeSearvhByIdOrName.Text = "Search By";
            this.cbEmployeeSearvhByIdOrName.SelectedIndexChanged += new System.EventHandler(this.cbEmployeeSearvhByIdOrName_SelectedIndexChanged);
            // 
            // panelForEmployeeButton
            // 
            this.panelForEmployeeButton.Controls.Add(this.btnRefresh);
            this.panelForEmployeeButton.Controls.Add(this.btnCreateNewEmployee);
            this.panelForEmployeeButton.Controls.Add(this.btnEmployeeDelete);
            this.panelForEmployeeButton.Controls.Add(this.btmEmployeUpdate);
            this.panelForEmployeeButton.Location = new System.Drawing.Point(61, 356);
            this.panelForEmployeeButton.Name = "panelForEmployeeButton";
            this.panelForEmployeeButton.Size = new System.Drawing.Size(480, 53);
            this.panelForEmployeeButton.TabIndex = 4;
            // 
            // btnCreateNewEmployee
            // 
            this.btnCreateNewEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNewEmployee.Location = new System.Drawing.Point(378, 3);
            this.btnCreateNewEmployee.Name = "btnCreateNewEmployee";
            this.btnCreateNewEmployee.Size = new System.Drawing.Size(99, 47);
            this.btnCreateNewEmployee.TabIndex = 2;
            this.btnCreateNewEmployee.Text = "New Employee";
            this.btnCreateNewEmployee.UseVisualStyleBackColor = true;
            this.btnCreateNewEmployee.Click += new System.EventHandler(this.btnCreateNewEmployee_Click);
            // 
            // btnEmployeeDelete
            // 
            this.btnEmployeeDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeDelete.Location = new System.Drawing.Point(273, 3);
            this.btnEmployeeDelete.Name = "btnEmployeeDelete";
            this.btnEmployeeDelete.Size = new System.Drawing.Size(99, 47);
            this.btnEmployeeDelete.TabIndex = 1;
            this.btnEmployeeDelete.Text = "Employee Delete";
            this.btnEmployeeDelete.UseVisualStyleBackColor = true;
            this.btnEmployeeDelete.Click += new System.EventHandler(this.btnEmployeeDelete_Click);
            // 
            // btmEmployeUpdate
            // 
            this.btmEmployeUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmEmployeUpdate.Location = new System.Drawing.Point(168, 3);
            this.btmEmployeUpdate.Name = "btmEmployeUpdate";
            this.btmEmployeUpdate.Size = new System.Drawing.Size(99, 47);
            this.btmEmployeUpdate.TabIndex = 0;
            this.btmEmployeUpdate.Text = "Employee Update";
            this.btmEmployeUpdate.UseVisualStyleBackColor = true;
            this.btmEmployeUpdate.Click += new System.EventHandler(this.btmEmployeUpdate_Click);
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectCustomer,
            this.CustomerId,
            this.CustomerName,
            this.EmployeeType,
            this.CustomerEmail,
            this.EmployeePhone,
            this.CustomerLocation});
            this.dataGridViewEmployee.Location = new System.Drawing.Point(3, 30);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.Size = new System.Drawing.Size(574, 311);
            this.dataGridViewEmployee.TabIndex = 5;
            // 
            // SelectCustomer
            // 
            this.SelectCustomer.HeaderText = "Select Employee";
            this.SelectCustomer.Name = "SelectCustomer";
            this.SelectCustomer.Width = 85;
            // 
            // CustomerId
            // 
            this.CustomerId.HeaderText = "Employee Id";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Width = 150;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Employee Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Width = 150;
            // 
            // EmployeeType
            // 
            this.EmployeeType.HeaderText = "Employee Type";
            this.EmployeeType.Name = "EmployeeType";
            this.EmployeeType.Width = 125;
            // 
            // CustomerEmail
            // 
            this.CustomerEmail.HeaderText = "Employee Email";
            this.CustomerEmail.Name = "CustomerEmail";
            this.CustomerEmail.Width = 185;
            // 
            // EmployeePhone
            // 
            this.EmployeePhone.HeaderText = "Employe Phone";
            this.EmployeePhone.Name = "EmployeePhone";
            // 
            // CustomerLocation
            // 
            this.CustomerLocation.HeaderText = "Employee Address";
            this.CustomerLocation.Name = "CustomerLocation";
            this.CustomerLocation.Width = 210;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(63, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(99, 47);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // UserControlEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewEmployee);
            this.Controls.Add(this.panelForEmployeeButton);
            this.Controls.Add(this.tbEmployeeSearchByIdOrName);
            this.Controls.Add(this.cbEmployeeSearvhByIdOrName);
            this.Name = "UserControlEmployee";
            this.Size = new System.Drawing.Size(581, 412);
            this.Load += new System.EventHandler(this.UserControlEmployee_Load);
            this.panelForEmployeeButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEmployeeSearchByIdOrName;
        private System.Windows.Forms.ComboBox cbEmployeeSearvhByIdOrName;
        private System.Windows.Forms.Panel panelForEmployeeButton;
        private System.Windows.Forms.Button btnCreateNewEmployee;
        private System.Windows.Forms.Button btnEmployeeDelete;
        private System.Windows.Forms.Button btmEmployeUpdate;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeePhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerLocation;
        private System.Windows.Forms.Button btnRefresh;
    }
}
