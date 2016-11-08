namespace InventoryManagementSystem.UserInterface
{
    partial class CreateNewCustomer
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
            this.lvlCustomerId = new System.Windows.Forms.Label();
            this.tbCustomerId = new System.Windows.Forms.TextBox();
            this.lvlCustomerName = new System.Windows.Forms.Label();
            this.lvlCustomerEmail = new System.Windows.Forms.Label();
            this.lvlCustomerLocation = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.tbCustomerEmail = new System.Windows.Forms.TextBox();
            this.tbCustomerLocation = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvlCustomerId
            // 
            this.lvlCustomerId.AutoSize = true;
            this.lvlCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlCustomerId.Location = new System.Drawing.Point(24, 38);
            this.lvlCustomerId.Name = "lvlCustomerId";
            this.lvlCustomerId.Size = new System.Drawing.Size(102, 16);
            this.lvlCustomerId.TabIndex = 0;
            this.lvlCustomerId.Text = "Customer Id : ";
            // 
            // tbCustomerId
            // 
            this.tbCustomerId.Location = new System.Drawing.Point(221, 34);
            this.tbCustomerId.Name = "tbCustomerId";
            this.tbCustomerId.Size = new System.Drawing.Size(181, 20);
            this.tbCustomerId.TabIndex = 1;
            // 
            // lvlCustomerName
            // 
            this.lvlCustomerName.AutoSize = true;
            this.lvlCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlCustomerName.Location = new System.Drawing.Point(24, 85);
            this.lvlCustomerName.Name = "lvlCustomerName";
            this.lvlCustomerName.Size = new System.Drawing.Size(130, 16);
            this.lvlCustomerName.TabIndex = 2;
            this.lvlCustomerName.Text = "Customer Name : ";
            // 
            // lvlCustomerEmail
            // 
            this.lvlCustomerEmail.AutoSize = true;
            this.lvlCustomerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlCustomerEmail.Location = new System.Drawing.Point(24, 131);
            this.lvlCustomerEmail.Name = "lvlCustomerEmail";
            this.lvlCustomerEmail.Size = new System.Drawing.Size(128, 16);
            this.lvlCustomerEmail.TabIndex = 3;
            this.lvlCustomerEmail.Text = "Customer Email : ";
            // 
            // lvlCustomerLocation
            // 
            this.lvlCustomerLocation.AutoSize = true;
            this.lvlCustomerLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlCustomerLocation.Location = new System.Drawing.Point(24, 178);
            this.lvlCustomerLocation.Name = "lvlCustomerLocation";
            this.lvlCustomerLocation.Size = new System.Drawing.Size(148, 16);
            this.lvlCustomerLocation.TabIndex = 4;
            this.lvlCustomerLocation.Text = "Customer Location : ";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(221, 85);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(181, 20);
            this.tbCustomerName.TabIndex = 5;
            // 
            // tbCustomerEmail
            // 
            this.tbCustomerEmail.Location = new System.Drawing.Point(221, 131);
            this.tbCustomerEmail.Name = "tbCustomerEmail";
            this.tbCustomerEmail.Size = new System.Drawing.Size(181, 20);
            this.tbCustomerEmail.TabIndex = 6;
            // 
            // tbCustomerLocation
            // 
            this.tbCustomerLocation.Location = new System.Drawing.Point(221, 178);
            this.tbCustomerLocation.Name = "tbCustomerLocation";
            this.tbCustomerLocation.Size = new System.Drawing.Size(181, 20);
            this.tbCustomerLocation.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(296, 272);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(106, 32);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // CreateNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 316);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbCustomerLocation);
            this.Controls.Add(this.tbCustomerEmail);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.lvlCustomerLocation);
            this.Controls.Add(this.lvlCustomerEmail);
            this.Controls.Add(this.lvlCustomerName);
            this.Controls.Add(this.tbCustomerId);
            this.Controls.Add(this.lvlCustomerId);
            this.Name = "CreateNewCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lvlCustomerId;
        private System.Windows.Forms.TextBox tbCustomerId;
        private System.Windows.Forms.Label lvlCustomerName;
        private System.Windows.Forms.Label lvlCustomerEmail;
        private System.Windows.Forms.Label lvlCustomerLocation;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.TextBox tbCustomerEmail;
        private System.Windows.Forms.TextBox tbCustomerLocation;
        private System.Windows.Forms.Button btnSubmit;
    }
}