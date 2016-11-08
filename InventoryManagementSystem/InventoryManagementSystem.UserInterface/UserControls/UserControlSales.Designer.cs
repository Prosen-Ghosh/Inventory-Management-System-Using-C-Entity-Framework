namespace InventoryManagementSystem.UserInterface.UserControls
{
    partial class UserControlSales
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
            this.panelUserControlsSales = new System.Windows.Forms.Panel();
            this.panelForSalesButton = new System.Windows.Forms.Panel();
            this.btnSelsReport = new System.Windows.Forms.Button();
            this.btnCreateNewSales = new System.Windows.Forms.Button();
            this.btnSalesDelete = new System.Windows.Forms.Button();
            this.btnSalesUpdate = new System.Windows.Forms.Button();
            this.dataGridViewSales = new System.Windows.Forms.DataGridView();
            this.SelectSales = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SalesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbSalesSearchByIdOrName = new System.Windows.Forms.TextBox();
            this.cbSalesSearchByIdOrName = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panelUserControlsSales.SuspendLayout();
            this.panelForSalesButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUserControlsSales
            // 
            this.panelUserControlsSales.Controls.Add(this.panelForSalesButton);
            this.panelUserControlsSales.Controls.Add(this.dataGridViewSales);
            this.panelUserControlsSales.Controls.Add(this.tbSalesSearchByIdOrName);
            this.panelUserControlsSales.Controls.Add(this.cbSalesSearchByIdOrName);
            this.panelUserControlsSales.Location = new System.Drawing.Point(4, 4);
            this.panelUserControlsSales.Name = "panelUserControlsSales";
            this.panelUserControlsSales.Size = new System.Drawing.Size(574, 408);
            this.panelUserControlsSales.TabIndex = 0;
            // 
            // panelForSalesButton
            // 
            this.panelForSalesButton.Controls.Add(this.btnRefresh);
            this.panelForSalesButton.Controls.Add(this.btnSelsReport);
            this.panelForSalesButton.Controls.Add(this.btnCreateNewSales);
            this.panelForSalesButton.Controls.Add(this.btnSalesDelete);
            this.panelForSalesButton.Controls.Add(this.btnSalesUpdate);
            this.panelForSalesButton.Location = new System.Drawing.Point(20, 347);
            this.panelForSalesButton.Name = "panelForSalesButton";
            this.panelForSalesButton.Size = new System.Drawing.Size(537, 53);
            this.panelForSalesButton.TabIndex = 7;
            // 
            // btnSelsReport
            // 
            this.btnSelsReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelsReport.Location = new System.Drawing.Point(97, 3);
            this.btnSelsReport.Name = "btnSelsReport";
            this.btnSelsReport.Size = new System.Drawing.Size(99, 47);
            this.btnSelsReport.TabIndex = 3;
            this.btnSelsReport.Text = "Sales Report";
            this.btnSelsReport.UseVisualStyleBackColor = true;
            this.btnSelsReport.Click += new System.EventHandler(this.btnSelsReport_Click);
            // 
            // btnCreateNewSales
            // 
            this.btnCreateNewSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNewSales.Location = new System.Drawing.Point(412, 3);
            this.btnCreateNewSales.Name = "btnCreateNewSales";
            this.btnCreateNewSales.Size = new System.Drawing.Size(90, 47);
            this.btnCreateNewSales.TabIndex = 2;
            this.btnCreateNewSales.Text = "New Sales";
            this.btnCreateNewSales.UseVisualStyleBackColor = true;
            this.btnCreateNewSales.Click += new System.EventHandler(this.btnCreateNewSales_Click);
            // 
            // btnSalesDelete
            // 
            this.btnSalesDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesDelete.Location = new System.Drawing.Point(307, 3);
            this.btnSalesDelete.Name = "btnSalesDelete";
            this.btnSalesDelete.Size = new System.Drawing.Size(99, 47);
            this.btnSalesDelete.TabIndex = 1;
            this.btnSalesDelete.Text = "Sales Delete";
            this.btnSalesDelete.UseVisualStyleBackColor = true;
            this.btnSalesDelete.Click += new System.EventHandler(this.btnSalesDelete_Click);
            // 
            // btnSalesUpdate
            // 
            this.btnSalesUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesUpdate.Location = new System.Drawing.Point(202, 3);
            this.btnSalesUpdate.Name = "btnSalesUpdate";
            this.btnSalesUpdate.Size = new System.Drawing.Size(99, 47);
            this.btnSalesUpdate.TabIndex = 0;
            this.btnSalesUpdate.Text = "Sales Update";
            this.btnSalesUpdate.UseVisualStyleBackColor = true;
            this.btnSalesUpdate.Click += new System.EventHandler(this.btnSalesUpdate_Click);
            // 
            // dataGridViewSales
            // 
            this.dataGridViewSales.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectSales,
            this.SalesId,
            this.ProductId,
            this.SupplierId,
            this.CustomerId,
            this.EmployeeId,
            this.SalesTax,
            this.SalesPrice,
            this.SalesQuantity,
            this.SalesDate});
            this.dataGridViewSales.Location = new System.Drawing.Point(3, 30);
            this.dataGridViewSales.Name = "dataGridViewSales";
            this.dataGridViewSales.Size = new System.Drawing.Size(568, 311);
            this.dataGridViewSales.TabIndex = 6;
            // 
            // SelectSales
            // 
            this.SelectSales.HeaderText = "Select Sales";
            this.SelectSales.Name = "SelectSales";
            this.SelectSales.Width = 85;
            // 
            // SalesId
            // 
            this.SalesId.HeaderText = "Sales Id";
            this.SalesId.Name = "SalesId";
            this.SalesId.Width = 150;
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "Product Id";
            this.ProductId.Name = "ProductId";
            // 
            // SupplierId
            // 
            this.SupplierId.HeaderText = "Supplier Id";
            this.SupplierId.Name = "SupplierId";
            this.SupplierId.Width = 150;
            // 
            // CustomerId
            // 
            this.CustomerId.HeaderText = "Customer Id";
            this.CustomerId.Name = "CustomerId";
            // 
            // EmployeeId
            // 
            this.EmployeeId.HeaderText = "Employee Id";
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.Width = 110;
            // 
            // SalesTax
            // 
            this.SalesTax.HeaderText = "Sales Tax";
            this.SalesTax.Name = "SalesTax";
            this.SalesTax.Width = 185;
            // 
            // SalesPrice
            // 
            this.SalesPrice.HeaderText = "Sales Price";
            this.SalesPrice.Name = "SalesPrice";
            // 
            // SalesQuantity
            // 
            this.SalesQuantity.HeaderText = "Sales Quantity";
            this.SalesQuantity.Name = "SalesQuantity";
            this.SalesQuantity.Width = 110;
            // 
            // SalesDate
            // 
            this.SalesDate.HeaderText = "Sales Date";
            this.SalesDate.Name = "SalesDate";
            // 
            // tbSalesSearchByIdOrName
            // 
            this.tbSalesSearchByIdOrName.Location = new System.Drawing.Point(116, 4);
            this.tbSalesSearchByIdOrName.Name = "tbSalesSearchByIdOrName";
            this.tbSalesSearchByIdOrName.Size = new System.Drawing.Size(120, 20);
            this.tbSalesSearchByIdOrName.TabIndex = 5;
            this.tbSalesSearchByIdOrName.TextChanged += new System.EventHandler(this.tbSalesSearchByIdOrName_TextChanged);
            // 
            // cbSalesSearchByIdOrName
            // 
            this.cbSalesSearchByIdOrName.FormattingEnabled = true;
            this.cbSalesSearchByIdOrName.Location = new System.Drawing.Point(3, 3);
            this.cbSalesSearchByIdOrName.Name = "cbSalesSearchByIdOrName";
            this.cbSalesSearchByIdOrName.Size = new System.Drawing.Size(107, 21);
            this.cbSalesSearchByIdOrName.TabIndex = 4;
            this.cbSalesSearchByIdOrName.Text = "Search By";
            this.cbSalesSearchByIdOrName.SelectedIndexChanged += new System.EventHandler(this.cbSalesSearchByIdOrName_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(18, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(73, 47);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // UserControlSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelUserControlsSales);
            this.Name = "UserControlSales";
            this.Size = new System.Drawing.Size(581, 412);
            this.Load += new System.EventHandler(this.UserControlSales_Load);
            this.panelUserControlsSales.ResumeLayout(false);
            this.panelUserControlsSales.PerformLayout();
            this.panelForSalesButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUserControlsSales;
        private System.Windows.Forms.TextBox tbSalesSearchByIdOrName;
        private System.Windows.Forms.ComboBox cbSalesSearchByIdOrName;
        private System.Windows.Forms.DataGridView dataGridViewSales;
        private System.Windows.Forms.Panel panelForSalesButton;
        private System.Windows.Forms.Button btnCreateNewSales;
        private System.Windows.Forms.Button btnSalesDelete;
        private System.Windows.Forms.Button btnSalesUpdate;
        private System.Windows.Forms.Button btnSelsReport;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesDate;
        private System.Windows.Forms.Button btnRefresh;
    }
}
