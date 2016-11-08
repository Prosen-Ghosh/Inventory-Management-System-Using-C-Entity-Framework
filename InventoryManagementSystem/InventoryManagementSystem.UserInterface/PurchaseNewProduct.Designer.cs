namespace InventoryManagementSystem.UserInterface
{
    partial class PurchaseNewProduct
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
            this.lvlPurchaseId = new System.Windows.Forms.Label();
            this.lvlSupplierId = new System.Windows.Forms.Label();
            this.lvlProductName = new System.Windows.Forms.Label();
            this.lvlProductQuantity = new System.Windows.Forms.Label();
            this.lvlProductPrice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbProductPrice = new System.Windows.Forms.TextBox();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.tbProductQuantity = new System.Windows.Forms.TextBox();
            this.tbPurchaseId = new System.Windows.Forms.TextBox();
            this.btnPurchaseSubmit = new System.Windows.Forms.Button();
            this.comboBoxSupplierId = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvlPurchaseId
            // 
            this.lvlPurchaseId.AutoSize = true;
            this.lvlPurchaseId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlPurchaseId.Location = new System.Drawing.Point(3, 9);
            this.lvlPurchaseId.Name = "lvlPurchaseId";
            this.lvlPurchaseId.Size = new System.Drawing.Size(91, 15);
            this.lvlPurchaseId.TabIndex = 0;
            this.lvlPurchaseId.Text = "Purchase Id :";
            // 
            // lvlSupplierId
            // 
            this.lvlSupplierId.AutoSize = true;
            this.lvlSupplierId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlSupplierId.Location = new System.Drawing.Point(3, 50);
            this.lvlSupplierId.Name = "lvlSupplierId";
            this.lvlSupplierId.Size = new System.Drawing.Size(84, 15);
            this.lvlSupplierId.TabIndex = 1;
            this.lvlSupplierId.Text = "Supplier Id :";
            // 
            // lvlProductName
            // 
            this.lvlProductName.AutoSize = true;
            this.lvlProductName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlProductName.Location = new System.Drawing.Point(3, 93);
            this.lvlProductName.Name = "lvlProductName";
            this.lvlProductName.Size = new System.Drawing.Size(107, 15);
            this.lvlProductName.TabIndex = 2;
            this.lvlProductName.Text = "Product Name :";
            // 
            // lvlProductQuantity
            // 
            this.lvlProductQuantity.AutoSize = true;
            this.lvlProductQuantity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlProductQuantity.Location = new System.Drawing.Point(3, 137);
            this.lvlProductQuantity.Name = "lvlProductQuantity";
            this.lvlProductQuantity.Size = new System.Drawing.Size(124, 15);
            this.lvlProductQuantity.TabIndex = 3;
            this.lvlProductQuantity.Text = "Product Quantity :";
            // 
            // lvlProductPrice
            // 
            this.lvlProductPrice.AutoSize = true;
            this.lvlProductPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlProductPrice.Location = new System.Drawing.Point(3, 182);
            this.lvlProductPrice.Name = "lvlProductPrice";
            this.lvlProductPrice.Size = new System.Drawing.Size(104, 15);
            this.lvlProductPrice.TabIndex = 4;
            this.lvlProductPrice.Text = "Product Price :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxSupplierId);
            this.panel1.Controls.Add(this.tbProductPrice);
            this.panel1.Controls.Add(this.tbProductName);
            this.panel1.Controls.Add(this.tbProductQuantity);
            this.panel1.Controls.Add(this.tbPurchaseId);
            this.panel1.Controls.Add(this.lvlPurchaseId);
            this.panel1.Controls.Add(this.lvlProductPrice);
            this.panel1.Controls.Add(this.lvlSupplierId);
            this.panel1.Controls.Add(this.lvlProductQuantity);
            this.panel1.Controls.Add(this.lvlProductName);
            this.panel1.Location = new System.Drawing.Point(4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 220);
            this.panel1.TabIndex = 5;
            // 
            // tbProductPrice
            // 
            this.tbProductPrice.Location = new System.Drawing.Point(186, 177);
            this.tbProductPrice.Name = "tbProductPrice";
            this.tbProductPrice.Size = new System.Drawing.Size(211, 20);
            this.tbProductPrice.TabIndex = 9;
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(186, 88);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(211, 20);
            this.tbProductName.TabIndex = 7;
            // 
            // tbProductQuantity
            // 
            this.tbProductQuantity.Location = new System.Drawing.Point(186, 132);
            this.tbProductQuantity.Name = "tbProductQuantity";
            this.tbProductQuantity.Size = new System.Drawing.Size(211, 20);
            this.tbProductQuantity.TabIndex = 6;
            // 
            // tbPurchaseId
            // 
            this.tbPurchaseId.Location = new System.Drawing.Point(186, 9);
            this.tbPurchaseId.Name = "tbPurchaseId";
            this.tbPurchaseId.Size = new System.Drawing.Size(211, 20);
            this.tbPurchaseId.TabIndex = 5;
            // 
            // btnPurchaseSubmit
            // 
            this.btnPurchaseSubmit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchaseSubmit.Location = new System.Drawing.Point(287, 232);
            this.btnPurchaseSubmit.Name = "btnPurchaseSubmit";
            this.btnPurchaseSubmit.Size = new System.Drawing.Size(114, 30);
            this.btnPurchaseSubmit.TabIndex = 6;
            this.btnPurchaseSubmit.Text = "Sublit";
            this.btnPurchaseSubmit.UseVisualStyleBackColor = true;
            this.btnPurchaseSubmit.Click += new System.EventHandler(this.btnPurchaseSubmit_Click);
            // 
            // comboBoxSupplierId
            // 
            this.comboBoxSupplierId.FormattingEnabled = true;
            this.comboBoxSupplierId.Location = new System.Drawing.Point(186, 50);
            this.comboBoxSupplierId.Name = "comboBoxSupplierId";
            this.comboBoxSupplierId.Size = new System.Drawing.Size(211, 21);
            this.comboBoxSupplierId.TabIndex = 10;
            // 
            // PurchaseNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 283);
            this.Controls.Add(this.btnPurchaseSubmit);
            this.Controls.Add(this.panel1);
            this.Name = "PurchaseNewProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase New Product";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lvlPurchaseId;
        private System.Windows.Forms.Label lvlSupplierId;
        private System.Windows.Forms.Label lvlProductName;
        private System.Windows.Forms.Label lvlProductQuantity;
        private System.Windows.Forms.Label lvlProductPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbProductPrice;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.TextBox tbProductQuantity;
        private System.Windows.Forms.TextBox tbPurchaseId;
        private System.Windows.Forms.Button btnPurchaseSubmit;
        private System.Windows.Forms.ComboBox comboBoxSupplierId;
    }
}