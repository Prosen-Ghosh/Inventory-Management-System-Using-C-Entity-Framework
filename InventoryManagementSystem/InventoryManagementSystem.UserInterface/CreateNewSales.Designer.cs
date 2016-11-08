namespace InventoryManagementSystem.UserInterface
{
    partial class CreateNewSales
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
            this.panelNewSales = new System.Windows.Forms.Panel();
            this.btnNewSalesSubmit = new System.Windows.Forms.Button();
            this.lvlSalesId = new System.Windows.Forms.Label();
            this.lvlProductId = new System.Windows.Forms.Label();
            this.lvlSupplierId = new System.Windows.Forms.Label();
            this.lvlCustomerId = new System.Windows.Forms.Label();
            this.lvlUserId = new System.Windows.Forms.Label();
            this.lvlSalesTax = new System.Windows.Forms.Label();
            this.lvlSalesPrice = new System.Windows.Forms.Label();
            this.lvlSalesQuantity = new System.Windows.Forms.Label();
            this.comboBoxProductId = new System.Windows.Forms.ComboBox();
            this.comboBoxCustomerId = new System.Windows.Forms.ComboBox();
            this.tbUserId = new System.Windows.Forms.TextBox();
            this.tbSalesTax = new System.Windows.Forms.TextBox();
            this.tbSalesPrice = new System.Windows.Forms.TextBox();
            this.tbSalesQuantity = new System.Windows.Forms.TextBox();
            this.tbSalesId = new System.Windows.Forms.TextBox();
            this.tbSupplierId = new System.Windows.Forms.TextBox();
            this.panelNewSales.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNewSales
            // 
            this.panelNewSales.Controls.Add(this.tbSupplierId);
            this.panelNewSales.Controls.Add(this.tbSalesId);
            this.panelNewSales.Controls.Add(this.tbSalesQuantity);
            this.panelNewSales.Controls.Add(this.tbSalesPrice);
            this.panelNewSales.Controls.Add(this.tbSalesTax);
            this.panelNewSales.Controls.Add(this.tbUserId);
            this.panelNewSales.Controls.Add(this.comboBoxCustomerId);
            this.panelNewSales.Controls.Add(this.comboBoxProductId);
            this.panelNewSales.Controls.Add(this.lvlSalesQuantity);
            this.panelNewSales.Controls.Add(this.lvlSalesPrice);
            this.panelNewSales.Controls.Add(this.lvlSalesTax);
            this.panelNewSales.Controls.Add(this.lvlUserId);
            this.panelNewSales.Controls.Add(this.lvlCustomerId);
            this.panelNewSales.Controls.Add(this.lvlSupplierId);
            this.panelNewSales.Controls.Add(this.lvlProductId);
            this.panelNewSales.Controls.Add(this.lvlSalesId);
            this.panelNewSales.Location = new System.Drawing.Point(0, 1);
            this.panelNewSales.Name = "panelNewSales";
            this.panelNewSales.Size = new System.Drawing.Size(387, 375);
            this.panelNewSales.TabIndex = 0;
            // 
            // btnNewSalesSubmit
            // 
            this.btnNewSalesSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSalesSubmit.Location = new System.Drawing.Point(263, 382);
            this.btnNewSalesSubmit.Name = "btnNewSalesSubmit";
            this.btnNewSalesSubmit.Size = new System.Drawing.Size(113, 39);
            this.btnNewSalesSubmit.TabIndex = 1;
            this.btnNewSalesSubmit.Text = "Submit";
            this.btnNewSalesSubmit.UseVisualStyleBackColor = true;
            this.btnNewSalesSubmit.Click += new System.EventHandler(this.btnNewSalesSubmit_Click);
            // 
            // lvlSalesId
            // 
            this.lvlSalesId.AutoSize = true;
            this.lvlSalesId.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlSalesId.Location = new System.Drawing.Point(12, 8);
            this.lvlSalesId.Name = "lvlSalesId";
            this.lvlSalesId.Size = new System.Drawing.Size(59, 15);
            this.lvlSalesId.TabIndex = 0;
            this.lvlSalesId.Text = "Sales Id :";
            // 
            // lvlProductId
            // 
            this.lvlProductId.AutoSize = true;
            this.lvlProductId.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlProductId.Location = new System.Drawing.Point(12, 46);
            this.lvlProductId.Name = "lvlProductId";
            this.lvlProductId.Size = new System.Drawing.Size(72, 15);
            this.lvlProductId.TabIndex = 1;
            this.lvlProductId.Text = "Product Id :";
            // 
            // lvlSupplierId
            // 
            this.lvlSupplierId.AutoSize = true;
            this.lvlSupplierId.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlSupplierId.Location = new System.Drawing.Point(12, 89);
            this.lvlSupplierId.Name = "lvlSupplierId";
            this.lvlSupplierId.Size = new System.Drawing.Size(74, 15);
            this.lvlSupplierId.TabIndex = 2;
            this.lvlSupplierId.Text = "Supplier Id :";
            // 
            // lvlCustomerId
            // 
            this.lvlCustomerId.AutoSize = true;
            this.lvlCustomerId.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlCustomerId.Location = new System.Drawing.Point(12, 132);
            this.lvlCustomerId.Name = "lvlCustomerId";
            this.lvlCustomerId.Size = new System.Drawing.Size(84, 15);
            this.lvlCustomerId.TabIndex = 3;
            this.lvlCustomerId.Text = "Customer Id :";
            // 
            // lvlUserId
            // 
            this.lvlUserId.AutoSize = true;
            this.lvlUserId.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlUserId.Location = new System.Drawing.Point(12, 174);
            this.lvlUserId.Name = "lvlUserId";
            this.lvlUserId.Size = new System.Drawing.Size(55, 15);
            this.lvlUserId.TabIndex = 4;
            this.lvlUserId.Text = "User Id :";
            // 
            // lvlSalesTax
            // 
            this.lvlSalesTax.AutoSize = true;
            this.lvlSalesTax.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlSalesTax.Location = new System.Drawing.Point(12, 213);
            this.lvlSalesTax.Name = "lvlSalesTax";
            this.lvlSalesTax.Size = new System.Drawing.Size(69, 15);
            this.lvlSalesTax.TabIndex = 5;
            this.lvlSalesTax.Text = "Sales Tax :";
            // 
            // lvlSalesPrice
            // 
            this.lvlSalesPrice.AutoSize = true;
            this.lvlSalesPrice.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlSalesPrice.Location = new System.Drawing.Point(12, 254);
            this.lvlSalesPrice.Name = "lvlSalesPrice";
            this.lvlSalesPrice.Size = new System.Drawing.Size(79, 15);
            this.lvlSalesPrice.TabIndex = 6;
            this.lvlSalesPrice.Text = "Sales Price :";
            // 
            // lvlSalesQuantity
            // 
            this.lvlSalesQuantity.AutoSize = true;
            this.lvlSalesQuantity.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlSalesQuantity.Location = new System.Drawing.Point(12, 300);
            this.lvlSalesQuantity.Name = "lvlSalesQuantity";
            this.lvlSalesQuantity.Size = new System.Drawing.Size(97, 15);
            this.lvlSalesQuantity.TabIndex = 7;
            this.lvlSalesQuantity.Text = "Sales Quantity :";
            // 
            // comboBoxProductId
            // 
            this.comboBoxProductId.FormattingEnabled = true;
            this.comboBoxProductId.Location = new System.Drawing.Point(148, 44);
            this.comboBoxProductId.Name = "comboBoxProductId";
            this.comboBoxProductId.Size = new System.Drawing.Size(228, 21);
            this.comboBoxProductId.TabIndex = 9;
            this.comboBoxProductId.SelectedIndexChanged += new System.EventHandler(this.comboBoxProductId_SelectedIndexChanged);
            // 
            // comboBoxCustomerId
            // 
            this.comboBoxCustomerId.FormattingEnabled = true;
            this.comboBoxCustomerId.Location = new System.Drawing.Point(148, 130);
            this.comboBoxCustomerId.Name = "comboBoxCustomerId";
            this.comboBoxCustomerId.Size = new System.Drawing.Size(228, 21);
            this.comboBoxCustomerId.TabIndex = 11;
            // 
            // tbUserId
            // 
            this.tbUserId.Location = new System.Drawing.Point(148, 168);
            this.tbUserId.Name = "tbUserId";
            this.tbUserId.ReadOnly = true;
            this.tbUserId.Size = new System.Drawing.Size(228, 20);
            this.tbUserId.TabIndex = 12;
            // 
            // tbSalesTax
            // 
            this.tbSalesTax.Location = new System.Drawing.Point(148, 208);
            this.tbSalesTax.Name = "tbSalesTax";
            this.tbSalesTax.Size = new System.Drawing.Size(228, 20);
            this.tbSalesTax.TabIndex = 13;
            // 
            // tbSalesPrice
            // 
            this.tbSalesPrice.Location = new System.Drawing.Point(148, 249);
            this.tbSalesPrice.Name = "tbSalesPrice";
            this.tbSalesPrice.Size = new System.Drawing.Size(228, 20);
            this.tbSalesPrice.TabIndex = 14;
            this.tbSalesPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // tbSalesQuantity
            // 
            this.tbSalesQuantity.Location = new System.Drawing.Point(148, 295);
            this.tbSalesQuantity.Name = "tbSalesQuantity";
            this.tbSalesQuantity.Size = new System.Drawing.Size(228, 20);
            this.tbSalesQuantity.TabIndex = 15;
            this.tbSalesQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSalesQuantity_KeyPress);
            // 
            // tbSalesId
            // 
            this.tbSalesId.Location = new System.Drawing.Point(148, 6);
            this.tbSalesId.Name = "tbSalesId";
            this.tbSalesId.Size = new System.Drawing.Size(228, 20);
            this.tbSalesId.TabIndex = 16;
            // 
            // tbSupplierId
            // 
            this.tbSupplierId.Location = new System.Drawing.Point(148, 83);
            this.tbSupplierId.Name = "tbSupplierId";
            this.tbSupplierId.ReadOnly = true;
            this.tbSupplierId.Size = new System.Drawing.Size(228, 20);
            this.tbSupplierId.TabIndex = 17;
            // 
            // CreateNewSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 433);
            this.Controls.Add(this.btnNewSalesSubmit);
            this.Controls.Add(this.panelNewSales);
            this.Name = "CreateNewSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Sales";
            this.panelNewSales.ResumeLayout(false);
            this.panelNewSales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNewSales;
        private System.Windows.Forms.TextBox tbSalesQuantity;
        private System.Windows.Forms.TextBox tbSalesPrice;
        private System.Windows.Forms.TextBox tbSalesTax;
        private System.Windows.Forms.TextBox tbUserId;
        private System.Windows.Forms.ComboBox comboBoxCustomerId;
        private System.Windows.Forms.ComboBox comboBoxProductId;
        private System.Windows.Forms.Label lvlSalesQuantity;
        private System.Windows.Forms.Label lvlSalesPrice;
        private System.Windows.Forms.Label lvlSalesTax;
        private System.Windows.Forms.Label lvlUserId;
        private System.Windows.Forms.Label lvlCustomerId;
        private System.Windows.Forms.Label lvlSupplierId;
        private System.Windows.Forms.Label lvlProductId;
        private System.Windows.Forms.Label lvlSalesId;
        private System.Windows.Forms.Button btnNewSalesSubmit;
        private System.Windows.Forms.TextBox tbSalesId;
        private System.Windows.Forms.TextBox tbSupplierId;
    }
}