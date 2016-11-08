namespace InventoryManagementSystem.UserInterface.UserControls
{
    partial class UserControlCustomer
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
            this.cbCustomerSearvhByIdOrName = new System.Windows.Forms.ComboBox();
            this.tbCustomerSearchByIdOrName = new System.Windows.Forms.TextBox();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.SelectCustomer = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelForCustomerButton = new System.Windows.Forms.Panel();
            this.btnCreateNewCustomer = new System.Windows.Forms.Button();
            this.btnCustomerDelete = new System.Windows.Forms.Button();
            this.btmCustomerUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.panelForCustomerButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCustomerSearvhByIdOrName
            // 
            this.cbCustomerSearvhByIdOrName.FormattingEnabled = true;
            this.cbCustomerSearvhByIdOrName.Location = new System.Drawing.Point(6, 2);
            this.cbCustomerSearvhByIdOrName.Name = "cbCustomerSearvhByIdOrName";
            this.cbCustomerSearvhByIdOrName.Size = new System.Drawing.Size(107, 21);
            this.cbCustomerSearvhByIdOrName.TabIndex = 0;
            this.cbCustomerSearvhByIdOrName.Text = "Search By";
            this.cbCustomerSearvhByIdOrName.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tbCustomerSearchByIdOrName
            // 
            this.tbCustomerSearchByIdOrName.Location = new System.Drawing.Point(119, 3);
            this.tbCustomerSearchByIdOrName.Name = "tbCustomerSearchByIdOrName";
            this.tbCustomerSearchByIdOrName.Size = new System.Drawing.Size(120, 20);
            this.tbCustomerSearchByIdOrName.TabIndex = 1;
            this.tbCustomerSearchByIdOrName.TextChanged += new System.EventHandler(this.tbCustomerSearchByIdOrName_TextChanged);
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectCustomer,
            this.CustomerName,
            this.CustomerId,
            this.CustomerEmail,
            this.CustomerLocation});
            this.dataGridViewCustomer.Location = new System.Drawing.Point(4, 29);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.Size = new System.Drawing.Size(574, 311);
            this.dataGridViewCustomer.TabIndex = 2;
            // 
            // SelectCustomer
            // 
            this.SelectCustomer.HeaderText = "Select Customer";
            this.SelectCustomer.Name = "SelectCustomer";
            this.SelectCustomer.Width = 85;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Width = 150;
            // 
            // CustomerId
            // 
            this.CustomerId.HeaderText = "Customer Id";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Width = 150;
            // 
            // CustomerEmail
            // 
            this.CustomerEmail.HeaderText = "Customer Email";
            this.CustomerEmail.Name = "CustomerEmail";
            this.CustomerEmail.Width = 185;
            // 
            // CustomerLocation
            // 
            this.CustomerLocation.HeaderText = "Customer Location";
            this.CustomerLocation.Name = "CustomerLocation";
            this.CustomerLocation.Width = 210;
            // 
            // panelForCustomerButton
            // 
            this.panelForCustomerButton.Controls.Add(this.btnRefresh);
            this.panelForCustomerButton.Controls.Add(this.btnCreateNewCustomer);
            this.panelForCustomerButton.Controls.Add(this.btnCustomerDelete);
            this.panelForCustomerButton.Controls.Add(this.btmCustomerUpdate);
            this.panelForCustomerButton.Location = new System.Drawing.Point(104, 346);
            this.panelForCustomerButton.Name = "panelForCustomerButton";
            this.panelForCustomerButton.Size = new System.Drawing.Size(451, 53);
            this.panelForCustomerButton.TabIndex = 3;
            // 
            // btnCreateNewCustomer
            // 
            this.btnCreateNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNewCustomer.Location = new System.Drawing.Point(349, 3);
            this.btnCreateNewCustomer.Name = "btnCreateNewCustomer";
            this.btnCreateNewCustomer.Size = new System.Drawing.Size(99, 47);
            this.btnCreateNewCustomer.TabIndex = 2;
            this.btnCreateNewCustomer.Text = "New Customer";
            this.btnCreateNewCustomer.UseVisualStyleBackColor = true;
            this.btnCreateNewCustomer.Click += new System.EventHandler(this.btnCreateNewCustomer_Click);
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerDelete.Location = new System.Drawing.Point(244, 3);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(99, 47);
            this.btnCustomerDelete.TabIndex = 1;
            this.btnCustomerDelete.Text = "Customer Delete";
            this.btnCustomerDelete.UseVisualStyleBackColor = true;
            this.btnCustomerDelete.Click += new System.EventHandler(this.btnCustomerDelete_Click);
            // 
            // btmCustomerUpdate
            // 
            this.btmCustomerUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmCustomerUpdate.Location = new System.Drawing.Point(139, 3);
            this.btmCustomerUpdate.Name = "btmCustomerUpdate";
            this.btmCustomerUpdate.Size = new System.Drawing.Size(99, 47);
            this.btmCustomerUpdate.TabIndex = 0;
            this.btmCustomerUpdate.Text = "Customer Update";
            this.btmCustomerUpdate.UseVisualStyleBackColor = true;
            this.btmCustomerUpdate.Click += new System.EventHandler(this.btmCustomerUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(36, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(99, 47);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // UserControlCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelForCustomerButton);
            this.Controls.Add(this.dataGridViewCustomer);
            this.Controls.Add(this.tbCustomerSearchByIdOrName);
            this.Controls.Add(this.cbCustomerSearvhByIdOrName);
            this.Name = "UserControlCustomer";
            this.Size = new System.Drawing.Size(581, 412);
            this.Load += new System.EventHandler(this.UserControlCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.panelForCustomerButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCustomerSearvhByIdOrName;
        private System.Windows.Forms.TextBox tbCustomerSearchByIdOrName;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.Panel panelForCustomerButton;
        private System.Windows.Forms.Button btnCreateNewCustomer;
        private System.Windows.Forms.Button btnCustomerDelete;
        private System.Windows.Forms.Button btmCustomerUpdate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerLocation;
        private System.Windows.Forms.Button btnRefresh;
    }
}
