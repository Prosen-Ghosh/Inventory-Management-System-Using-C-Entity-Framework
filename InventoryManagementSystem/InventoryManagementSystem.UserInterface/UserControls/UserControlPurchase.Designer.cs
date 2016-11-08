namespace InventoryManagementSystem.UserInterface.UserControls
{
    partial class UserControlPurchase
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
            this.tbPurchaseSearchByIdOrName = new System.Windows.Forms.TextBox();
            this.cbPurchaseSearchByIdOrName = new System.Windows.Forms.ComboBox();
            this.dataGridViewPurchase = new System.Windows.Forms.DataGridView();
            this.SelectPurchase = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasesDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelForPurchaseButton = new System.Windows.Forms.Panel();
            this.btnPurchesesReport = new System.Windows.Forms.Button();
            this.btnCreateNewPurchase = new System.Windows.Forms.Button();
            this.btnPurchaseDelete = new System.Windows.Forms.Button();
            this.btmPurchaseUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchase)).BeginInit();
            this.panelForPurchaseButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPurchaseSearchByIdOrName
            // 
            this.tbPurchaseSearchByIdOrName.Location = new System.Drawing.Point(116, 4);
            this.tbPurchaseSearchByIdOrName.Name = "tbPurchaseSearchByIdOrName";
            this.tbPurchaseSearchByIdOrName.Size = new System.Drawing.Size(120, 20);
            this.tbPurchaseSearchByIdOrName.TabIndex = 3;
            this.tbPurchaseSearchByIdOrName.TextChanged += new System.EventHandler(this.tbPurchaseSearchByIdOrName_TextChanged);
            // 
            // cbPurchaseSearchByIdOrName
            // 
            this.cbPurchaseSearchByIdOrName.FormattingEnabled = true;
            this.cbPurchaseSearchByIdOrName.Location = new System.Drawing.Point(3, 3);
            this.cbPurchaseSearchByIdOrName.Name = "cbPurchaseSearchByIdOrName";
            this.cbPurchaseSearchByIdOrName.Size = new System.Drawing.Size(107, 21);
            this.cbPurchaseSearchByIdOrName.TabIndex = 2;
            this.cbPurchaseSearchByIdOrName.Text = "Search By";
            this.cbPurchaseSearchByIdOrName.SelectedIndexChanged += new System.EventHandler(this.cbPurchaseSearchByIdOrName_SelectedIndexChanged);
            // 
            // dataGridViewPurchase
            // 
            this.dataGridViewPurchase.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPurchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectPurchase,
            this.SerialNumber,
            this.PurchaseId,
            this.SupplierId,
            this.ProductName,
            this.ProductQuantity,
            this.ProductPrice,
            this.UserId,
            this.PurchasesDate});
            this.dataGridViewPurchase.Location = new System.Drawing.Point(3, 30);
            this.dataGridViewPurchase.Name = "dataGridViewPurchase";
            this.dataGridViewPurchase.Size = new System.Drawing.Size(574, 311);
            this.dataGridViewPurchase.TabIndex = 4;
            // 
            // SelectPurchase
            // 
            this.SelectPurchase.HeaderText = "Select Purchase";
            this.SelectPurchase.Name = "SelectPurchase";
            this.SelectPurchase.Width = 85;
            // 
            // SerialNumber
            // 
            this.SerialNumber.HeaderText = "Serial Number";
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.Width = 60;
            // 
            // PurchaseId
            // 
            this.PurchaseId.HeaderText = "Purchase Id";
            this.PurchaseId.Name = "PurchaseId";
            this.PurchaseId.Width = 150;
            // 
            // SupplierId
            // 
            this.SupplierId.HeaderText = "Supplier Id";
            this.SupplierId.Name = "SupplierId";
            this.SupplierId.Width = 150;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 185;
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.HeaderText = "Product Quantity";
            this.ProductQuantity.Name = "ProductQuantity";
            this.ProductQuantity.Width = 110;
            // 
            // ProductPrice
            // 
            this.ProductPrice.HeaderText = "Product Price";
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Width = 110;
            // 
            // UserId
            // 
            this.UserId.HeaderText = "User Id";
            this.UserId.Name = "UserId";
            // 
            // PurchasesDate
            // 
            this.PurchasesDate.HeaderText = "Purchases Date";
            this.PurchasesDate.Name = "PurchasesDate";
            // 
            // panelForPurchaseButton
            // 
            this.panelForPurchaseButton.Controls.Add(this.btnRefresh);
            this.panelForPurchaseButton.Controls.Add(this.btnPurchesesReport);
            this.panelForPurchaseButton.Controls.Add(this.btnCreateNewPurchase);
            this.panelForPurchaseButton.Controls.Add(this.btnPurchaseDelete);
            this.panelForPurchaseButton.Controls.Add(this.btmPurchaseUpdate);
            this.panelForPurchaseButton.Location = new System.Drawing.Point(16, 347);
            this.panelForPurchaseButton.Name = "panelForPurchaseButton";
            this.panelForPurchaseButton.Size = new System.Drawing.Size(523, 53);
            this.panelForPurchaseButton.TabIndex = 5;
            // 
            // btnPurchesesReport
            // 
            this.btnPurchesesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchesesReport.Location = new System.Drawing.Point(92, 3);
            this.btnPurchesesReport.Name = "btnPurchesesReport";
            this.btnPurchesesReport.Size = new System.Drawing.Size(99, 47);
            this.btnPurchesesReport.TabIndex = 3;
            this.btnPurchesesReport.Text = "Purchase Report";
            this.btnPurchesesReport.UseVisualStyleBackColor = true;
            this.btnPurchesesReport.Click += new System.EventHandler(this.btnPurchesesReport_Click);
            // 
            // btnCreateNewPurchase
            // 
            this.btnCreateNewPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNewPurchase.Location = new System.Drawing.Point(407, 3);
            this.btnCreateNewPurchase.Name = "btnCreateNewPurchase";
            this.btnCreateNewPurchase.Size = new System.Drawing.Size(99, 47);
            this.btnCreateNewPurchase.TabIndex = 2;
            this.btnCreateNewPurchase.Text = "New Purchase";
            this.btnCreateNewPurchase.UseVisualStyleBackColor = true;
            this.btnCreateNewPurchase.Click += new System.EventHandler(this.btnCreateNewPurchase_Click);
            // 
            // btnPurchaseDelete
            // 
            this.btnPurchaseDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchaseDelete.Location = new System.Drawing.Point(302, 3);
            this.btnPurchaseDelete.Name = "btnPurchaseDelete";
            this.btnPurchaseDelete.Size = new System.Drawing.Size(99, 47);
            this.btnPurchaseDelete.TabIndex = 1;
            this.btnPurchaseDelete.Text = "Purchase Delete";
            this.btnPurchaseDelete.UseVisualStyleBackColor = true;
            this.btnPurchaseDelete.Click += new System.EventHandler(this.btnPurchaseDelete_Click);
            // 
            // btmPurchaseUpdate
            // 
            this.btmPurchaseUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmPurchaseUpdate.Location = new System.Drawing.Point(197, 3);
            this.btmPurchaseUpdate.Name = "btmPurchaseUpdate";
            this.btmPurchaseUpdate.Size = new System.Drawing.Size(99, 47);
            this.btmPurchaseUpdate.TabIndex = 0;
            this.btmPurchaseUpdate.Text = "Purchase Update";
            this.btmPurchaseUpdate.UseVisualStyleBackColor = true;
            this.btmPurchaseUpdate.Click += new System.EventHandler(this.btmPurchaseUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(16, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(70, 47);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // UserControlPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelForPurchaseButton);
            this.Controls.Add(this.dataGridViewPurchase);
            this.Controls.Add(this.tbPurchaseSearchByIdOrName);
            this.Controls.Add(this.cbPurchaseSearchByIdOrName);
            this.Name = "UserControlPurchase";
            this.Size = new System.Drawing.Size(581, 404);
            this.Load += new System.EventHandler(this.UserControlPurchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchase)).EndInit();
            this.panelForPurchaseButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPurchaseSearchByIdOrName;
        private System.Windows.Forms.ComboBox cbPurchaseSearchByIdOrName;
        private System.Windows.Forms.DataGridView dataGridViewPurchase;
        private System.Windows.Forms.Panel panelForPurchaseButton;
        private System.Windows.Forms.Button btnCreateNewPurchase;
        private System.Windows.Forms.Button btnPurchaseDelete;
        private System.Windows.Forms.Button btmPurchaseUpdate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectPurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.Button btnPurchesesReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasesDate;
        private System.Windows.Forms.Button btnRefresh;
    }
}
