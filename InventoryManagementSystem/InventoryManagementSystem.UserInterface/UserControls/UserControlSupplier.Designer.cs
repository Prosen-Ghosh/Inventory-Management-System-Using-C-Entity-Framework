namespace InventoryManagementSystem.UserInterface.UserControls
{
    partial class UserControlSupplier
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
            this.panelForSupplierButton = new System.Windows.Forms.Panel();
            this.btnCreateNewSupplier = new System.Windows.Forms.Button();
            this.btnSupplierDelete = new System.Windows.Forms.Button();
            this.btmSupplierUpdate = new System.Windows.Forms.Button();
            this.dataGridViewSupplier = new System.Windows.Forms.DataGridView();
            this.SelectCustomer = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbSupplierrSearchByIdOrName = new System.Windows.Forms.TextBox();
            this.cbSupplierSearchByIdOrName = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panelForSupplierButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // panelForSupplierButton
            // 
            this.panelForSupplierButton.Controls.Add(this.btnRefresh);
            this.panelForSupplierButton.Controls.Add(this.btnCreateNewSupplier);
            this.panelForSupplierButton.Controls.Add(this.btnSupplierDelete);
            this.panelForSupplierButton.Controls.Add(this.btmSupplierUpdate);
            this.panelForSupplierButton.Location = new System.Drawing.Point(116, 347);
            this.panelForSupplierButton.Name = "panelForSupplierButton";
            this.panelForSupplierButton.Size = new System.Drawing.Size(437, 53);
            this.panelForSupplierButton.TabIndex = 4;
            // 
            // btnCreateNewSupplier
            // 
            this.btnCreateNewSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNewSupplier.Location = new System.Drawing.Point(322, 3);
            this.btnCreateNewSupplier.Name = "btnCreateNewSupplier";
            this.btnCreateNewSupplier.Size = new System.Drawing.Size(99, 47);
            this.btnCreateNewSupplier.TabIndex = 2;
            this.btnCreateNewSupplier.Text = "New Supplier";
            this.btnCreateNewSupplier.UseVisualStyleBackColor = true;
            this.btnCreateNewSupplier.Click += new System.EventHandler(this.btnCreateNewSupplier_Click);
            // 
            // btnSupplierDelete
            // 
            this.btnSupplierDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplierDelete.Location = new System.Drawing.Point(217, 3);
            this.btnSupplierDelete.Name = "btnSupplierDelete";
            this.btnSupplierDelete.Size = new System.Drawing.Size(99, 47);
            this.btnSupplierDelete.TabIndex = 1;
            this.btnSupplierDelete.Text = "Supplier Delete";
            this.btnSupplierDelete.UseVisualStyleBackColor = true;
            this.btnSupplierDelete.Click += new System.EventHandler(this.btnSupplierDelete_Click);
            // 
            // btmSupplierUpdate
            // 
            this.btmSupplierUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmSupplierUpdate.Location = new System.Drawing.Point(112, 3);
            this.btmSupplierUpdate.Name = "btmSupplierUpdate";
            this.btmSupplierUpdate.Size = new System.Drawing.Size(99, 47);
            this.btmSupplierUpdate.TabIndex = 0;
            this.btmSupplierUpdate.Text = "Supplier Update";
            this.btmSupplierUpdate.UseVisualStyleBackColor = true;
            this.btmSupplierUpdate.Click += new System.EventHandler(this.btmSupplierUpdate_Click);
            // 
            // dataGridViewSupplier
            // 
            this.dataGridViewSupplier.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectCustomer,
            this.CustomerId,
            this.CustomerName,
            this.CustomerLocation,
            this.CustomerEmail,
            this.SupplierPhone});
            this.dataGridViewSupplier.Location = new System.Drawing.Point(0, 30);
            this.dataGridViewSupplier.Name = "dataGridViewSupplier";
            this.dataGridViewSupplier.Size = new System.Drawing.Size(581, 311);
            this.dataGridViewSupplier.TabIndex = 5;
            // 
            // SelectCustomer
            // 
            this.SelectCustomer.HeaderText = "Select Supplier";
            this.SelectCustomer.Name = "SelectCustomer";
            this.SelectCustomer.Width = 85;
            // 
            // CustomerId
            // 
            this.CustomerId.HeaderText = "Supplier Id";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Width = 140;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Supplier Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Width = 140;
            // 
            // CustomerLocation
            // 
            this.CustomerLocation.HeaderText = "Supplier Address";
            this.CustomerLocation.Name = "CustomerLocation";
            this.CustomerLocation.Width = 200;
            // 
            // CustomerEmail
            // 
            this.CustomerEmail.HeaderText = "Supplier Email";
            this.CustomerEmail.Name = "CustomerEmail";
            this.CustomerEmail.Width = 185;
            // 
            // SupplierPhone
            // 
            this.SupplierPhone.HeaderText = "Supplier Phone";
            this.SupplierPhone.Name = "SupplierPhone";
            this.SupplierPhone.Width = 130;
            // 
            // tbSupplierrSearchByIdOrName
            // 
            this.tbSupplierrSearchByIdOrName.Location = new System.Drawing.Point(116, 4);
            this.tbSupplierrSearchByIdOrName.Name = "tbSupplierrSearchByIdOrName";
            this.tbSupplierrSearchByIdOrName.Size = new System.Drawing.Size(120, 20);
            this.tbSupplierrSearchByIdOrName.TabIndex = 7;
            this.tbSupplierrSearchByIdOrName.TextChanged += new System.EventHandler(this.tbSupplierrSearchByIdOrName_TextChanged);
            // 
            // cbSupplierSearchByIdOrName
            // 
            this.cbSupplierSearchByIdOrName.FormattingEnabled = true;
            this.cbSupplierSearchByIdOrName.Location = new System.Drawing.Point(3, 3);
            this.cbSupplierSearchByIdOrName.Name = "cbSupplierSearchByIdOrName";
            this.cbSupplierSearchByIdOrName.Size = new System.Drawing.Size(107, 21);
            this.cbSupplierSearchByIdOrName.TabIndex = 6;
            this.cbSupplierSearchByIdOrName.Text = "Search By";
            this.cbSupplierSearchByIdOrName.SelectedIndexChanged += new System.EventHandler(this.cbSupplierSearvhByIdOrName_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(28, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(78, 47);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // UserControlSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbSupplierrSearchByIdOrName);
            this.Controls.Add(this.cbSupplierSearchByIdOrName);
            this.Controls.Add(this.dataGridViewSupplier);
            this.Controls.Add(this.panelForSupplierButton);
            this.Name = "UserControlSupplier";
            this.Size = new System.Drawing.Size(593, 412);
            this.Load += new System.EventHandler(this.UserControlSupplier_Load);
            this.panelForSupplierButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelForSupplierButton;
        private System.Windows.Forms.Button btnCreateNewSupplier;
        private System.Windows.Forms.Button btnSupplierDelete;
        private System.Windows.Forms.Button btmSupplierUpdate;
        private System.Windows.Forms.DataGridView dataGridViewSupplier;
        private System.Windows.Forms.TextBox tbSupplierrSearchByIdOrName;
        private System.Windows.Forms.ComboBox cbSupplierSearchByIdOrName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierPhone;
        private System.Windows.Forms.Button btnRefresh;
    }
}
