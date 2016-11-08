namespace InventoryManagementSystem.UserInterface
{
    partial class InventoryManagementSystem
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
            this.tabInventoryManagementSystem = new System.Windows.Forms.TabControl();
            this.tabPageDashboard = new System.Windows.Forms.TabPage();
            this.tabPageStock = new System.Windows.Forms.TabPage();
            this.tabPageSales = new System.Windows.Forms.TabPage();
            this.tabPagePurchase = new System.Windows.Forms.TabPage();
            this.tabPageSupplier = new System.Windows.Forms.TabPage();
            this.tabPageUsers = new System.Windows.Forms.TabPage();
            this.tabPageCustomer = new System.Windows.Forms.TabPage();
            this.tabInventoryManagementSystem.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabInventoryManagementSystem
            // 
            this.tabInventoryManagementSystem.Controls.Add(this.tabPageDashboard);
            this.tabInventoryManagementSystem.Controls.Add(this.tabPageStock);
            this.tabInventoryManagementSystem.Controls.Add(this.tabPageSales);
            this.tabInventoryManagementSystem.Controls.Add(this.tabPagePurchase);
            this.tabInventoryManagementSystem.Controls.Add(this.tabPageSupplier);
            this.tabInventoryManagementSystem.Controls.Add(this.tabPageUsers);
            this.tabInventoryManagementSystem.Controls.Add(this.tabPageCustomer);
            this.tabInventoryManagementSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabInventoryManagementSystem.ItemSize = new System.Drawing.Size(90, 25);
            this.tabInventoryManagementSystem.Location = new System.Drawing.Point(0, 0);
            this.tabInventoryManagementSystem.Name = "tabInventoryManagementSystem";
            this.tabInventoryManagementSystem.Padding = new System.Drawing.Point(29, 3);
            this.tabInventoryManagementSystem.SelectedIndex = 0;
            this.tabInventoryManagementSystem.Size = new System.Drawing.Size(836, 564);
            this.tabInventoryManagementSystem.TabIndex = 3;
            this.tabInventoryManagementSystem.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabInventoryManagementSystem_Selected);
            // 
            // tabPageDashboard
            // 
            this.tabPageDashboard.Location = new System.Drawing.Point(4, 29);
            this.tabPageDashboard.Name = "tabPageDashboard";
            this.tabPageDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDashboard.Size = new System.Drawing.Size(828, 531);
            this.tabPageDashboard.TabIndex = 0;
            this.tabPageDashboard.Text = "Dashboard";
            this.tabPageDashboard.UseVisualStyleBackColor = true;
            // 
            // tabPageStock
            // 
            this.tabPageStock.Location = new System.Drawing.Point(4, 29);
            this.tabPageStock.Name = "tabPageStock";
            this.tabPageStock.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStock.Size = new System.Drawing.Size(828, 531);
            this.tabPageStock.TabIndex = 1;
            this.tabPageStock.Text = "Stock";
            this.tabPageStock.UseVisualStyleBackColor = true;
            // 
            // tabPageSales
            // 
            this.tabPageSales.Location = new System.Drawing.Point(4, 29);
            this.tabPageSales.Name = "tabPageSales";
            this.tabPageSales.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSales.Size = new System.Drawing.Size(828, 531);
            this.tabPageSales.TabIndex = 2;
            this.tabPageSales.Text = "Sales";
            this.tabPageSales.UseVisualStyleBackColor = true;
            // 
            // tabPagePurchase
            // 
            this.tabPagePurchase.Location = new System.Drawing.Point(4, 29);
            this.tabPagePurchase.Name = "tabPagePurchase";
            this.tabPagePurchase.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePurchase.Size = new System.Drawing.Size(828, 531);
            this.tabPagePurchase.TabIndex = 3;
            this.tabPagePurchase.Text = "Purchase";
            this.tabPagePurchase.UseVisualStyleBackColor = true;
            // 
            // tabPageSupplier
            // 
            this.tabPageSupplier.Location = new System.Drawing.Point(4, 29);
            this.tabPageSupplier.Name = "tabPageSupplier";
            this.tabPageSupplier.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSupplier.Size = new System.Drawing.Size(828, 531);
            this.tabPageSupplier.TabIndex = 4;
            this.tabPageSupplier.Text = "Supplier";
            this.tabPageSupplier.UseVisualStyleBackColor = true;
            // 
            // tabPageUsers
            // 
            this.tabPageUsers.Location = new System.Drawing.Point(4, 29);
            this.tabPageUsers.Name = "tabPageUsers";
            this.tabPageUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsers.Size = new System.Drawing.Size(828, 531);
            this.tabPageUsers.TabIndex = 5;
            this.tabPageUsers.Text = "Employee";
            this.tabPageUsers.UseVisualStyleBackColor = true;
            // 
            // tabPageCustomer
            // 
            this.tabPageCustomer.Location = new System.Drawing.Point(4, 29);
            this.tabPageCustomer.Name = "tabPageCustomer";
            this.tabPageCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustomer.Size = new System.Drawing.Size(828, 531);
            this.tabPageCustomer.TabIndex = 6;
            this.tabPageCustomer.Text = "Customer";
            this.tabPageCustomer.UseVisualStyleBackColor = true;
            // 
            // InventoryManagementSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 555);
            this.Controls.Add(this.tabInventoryManagementSystem);
            this.Name = "InventoryManagementSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InventoryManagementSystem_FormClosed);
            this.Load += new System.EventHandler(this.InventoryManagementSystem_Load);
            this.tabInventoryManagementSystem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabInventoryManagementSystem;
        private System.Windows.Forms.TabPage tabPageDashboard;
        private System.Windows.Forms.TabPage tabPageStock;
        private System.Windows.Forms.TabPage tabPageSales;
        private System.Windows.Forms.TabPage tabPagePurchase;
        private System.Windows.Forms.TabPage tabPageSupplier;
        private System.Windows.Forms.TabPage tabPageUsers;
        private System.Windows.Forms.TabPage tabPageCustomer;
    }
}