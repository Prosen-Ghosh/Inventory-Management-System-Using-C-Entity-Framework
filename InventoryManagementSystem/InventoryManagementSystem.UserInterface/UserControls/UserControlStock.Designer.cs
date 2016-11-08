namespace InventoryManagementSystem.UserInterface.UserControls
{
    partial class UserControlStock
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
            this.panelUserControlsStock = new System.Windows.Forms.Panel();
            this.panelForStockButton = new System.Windows.Forms.Panel();
            this.btnCreateNewStock = new System.Windows.Forms.Button();
            this.btnStockDelete = new System.Windows.Forms.Button();
            this.btnStockUpdate = new System.Windows.Forms.Button();
            this.dataGridViewStock = new System.Windows.Forms.DataGridView();
            this.tbStockSearchByIdOrName = new System.Windows.Forms.TextBox();
            this.cbStockSearchByIdOrName = new System.Windows.Forms.ComboBox();
            this.SelectStock = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panelUserControlsStock.SuspendLayout();
            this.panelForStockButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUserControlsStock
            // 
            this.panelUserControlsStock.Controls.Add(this.panelForStockButton);
            this.panelUserControlsStock.Controls.Add(this.dataGridViewStock);
            this.panelUserControlsStock.Controls.Add(this.tbStockSearchByIdOrName);
            this.panelUserControlsStock.Controls.Add(this.cbStockSearchByIdOrName);
            this.panelUserControlsStock.Location = new System.Drawing.Point(3, 2);
            this.panelUserControlsStock.Name = "panelUserControlsStock";
            this.panelUserControlsStock.Size = new System.Drawing.Size(574, 407);
            this.panelUserControlsStock.TabIndex = 1;
            // 
            // panelForStockButton
            // 
            this.panelForStockButton.Controls.Add(this.btnRefresh);
            this.panelForStockButton.Controls.Add(this.btnCreateNewStock);
            this.panelForStockButton.Controls.Add(this.btnStockDelete);
            this.panelForStockButton.Controls.Add(this.btnStockUpdate);
            this.panelForStockButton.Location = new System.Drawing.Point(97, 347);
            this.panelForStockButton.Name = "panelForStockButton";
            this.panelForStockButton.Size = new System.Drawing.Size(454, 53);
            this.panelForStockButton.TabIndex = 7;
            // 
            // btnCreateNewStock
            // 
            this.btnCreateNewStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNewStock.Location = new System.Drawing.Point(352, 3);
            this.btnCreateNewStock.Name = "btnCreateNewStock";
            this.btnCreateNewStock.Size = new System.Drawing.Size(99, 47);
            this.btnCreateNewStock.TabIndex = 2;
            this.btnCreateNewStock.Text = "New Stock";
            this.btnCreateNewStock.UseVisualStyleBackColor = true;
            this.btnCreateNewStock.Click += new System.EventHandler(this.btnCreateNewStock_Click);
            // 
            // btnStockDelete
            // 
            this.btnStockDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockDelete.Location = new System.Drawing.Point(247, 3);
            this.btnStockDelete.Name = "btnStockDelete";
            this.btnStockDelete.Size = new System.Drawing.Size(99, 47);
            this.btnStockDelete.TabIndex = 1;
            this.btnStockDelete.Text = "Stock Delete";
            this.btnStockDelete.UseVisualStyleBackColor = true;
            this.btnStockDelete.Click += new System.EventHandler(this.btnStockDelete_Click);
            // 
            // btnStockUpdate
            // 
            this.btnStockUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockUpdate.Location = new System.Drawing.Point(142, 3);
            this.btnStockUpdate.Name = "btnStockUpdate";
            this.btnStockUpdate.Size = new System.Drawing.Size(99, 47);
            this.btnStockUpdate.TabIndex = 0;
            this.btnStockUpdate.Text = "Stock Update";
            this.btnStockUpdate.UseVisualStyleBackColor = true;
            this.btnStockUpdate.Click += new System.EventHandler(this.btnStockUpdate_Click);
            // 
            // dataGridViewStock
            // 
            this.dataGridViewStock.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectStock,
            this.ProductId,
            this.ProductName,
            this.ProductPrice,
            this.ProductQuantity,
            this.SupplierId});
            this.dataGridViewStock.Location = new System.Drawing.Point(3, 30);
            this.dataGridViewStock.Name = "dataGridViewStock";
            this.dataGridViewStock.Size = new System.Drawing.Size(568, 311);
            this.dataGridViewStock.TabIndex = 6;
            // 
            // tbStockSearchByIdOrName
            // 
            this.tbStockSearchByIdOrName.Location = new System.Drawing.Point(116, 4);
            this.tbStockSearchByIdOrName.Name = "tbStockSearchByIdOrName";
            this.tbStockSearchByIdOrName.Size = new System.Drawing.Size(120, 20);
            this.tbStockSearchByIdOrName.TabIndex = 5;
            this.tbStockSearchByIdOrName.TextChanged += new System.EventHandler(this.tbStockSearchByIdOrName_TextChanged);
            // 
            // cbStockSearchByIdOrName
            // 
            this.cbStockSearchByIdOrName.FormattingEnabled = true;
            this.cbStockSearchByIdOrName.Location = new System.Drawing.Point(3, 3);
            this.cbStockSearchByIdOrName.Name = "cbStockSearchByIdOrName";
            this.cbStockSearchByIdOrName.Size = new System.Drawing.Size(107, 21);
            this.cbStockSearchByIdOrName.TabIndex = 4;
            this.cbStockSearchByIdOrName.Text = "Search By";
            this.cbStockSearchByIdOrName.SelectedIndexChanged += new System.EventHandler(this.cbStockSearchByIdOrName_SelectedIndexChanged);
            // 
            // SelectStock
            // 
            this.SelectStock.HeaderText = "Select Stock";
            this.SelectStock.Name = "SelectStock";
            this.SelectStock.Width = 85;
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "Product Id";
            this.ProductId.Name = "ProductId";
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 150;
            // 
            // ProductPrice
            // 
            this.ProductPrice.HeaderText = "Product Price";
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Width = 185;
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.HeaderText = "Product Quantity";
            this.ProductQuantity.Name = "ProductQuantity";
            // 
            // SupplierId
            // 
            this.SupplierId.HeaderText = "Supplier Id";
            this.SupplierId.Name = "SupplierId";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(55, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(81, 47);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // UserControlStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelUserControlsStock);
            this.Name = "UserControlStock";
            this.Size = new System.Drawing.Size(581, 412);
            this.Load += new System.EventHandler(this.UserControlStock_Load);
            this.panelUserControlsStock.ResumeLayout(false);
            this.panelUserControlsStock.PerformLayout();
            this.panelForStockButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUserControlsStock;
        private System.Windows.Forms.Panel panelForStockButton;
        private System.Windows.Forms.Button btnCreateNewStock;
        private System.Windows.Forms.Button btnStockDelete;
        private System.Windows.Forms.Button btnStockUpdate;
        private System.Windows.Forms.DataGridView dataGridViewStock;
        private System.Windows.Forms.TextBox tbStockSearchByIdOrName;
        private System.Windows.Forms.ComboBox cbStockSearchByIdOrName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectStock;
        private System.Windows.Forms.Button btnRefresh;
    }
}
