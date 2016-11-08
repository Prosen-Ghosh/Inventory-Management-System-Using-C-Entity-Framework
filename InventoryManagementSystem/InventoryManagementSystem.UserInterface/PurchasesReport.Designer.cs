namespace InventoryManagementSystem.UserInterface
{
    partial class PurchasesReport
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
            this.panelPurcheaesReport = new System.Windows.Forms.Panel();
            this.lvlShowTotalPurchases = new System.Windows.Forms.Label();
            this.lvlTotalPurchases = new System.Windows.Forms.Label();
            this.btnSendTotalPurchases = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.panelPurcheaesReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPurcheaesReport
            // 
            this.panelPurcheaesReport.Controls.Add(this.lvlShowTotalPurchases);
            this.panelPurcheaesReport.Controls.Add(this.lvlTotalPurchases);
            this.panelPurcheaesReport.Location = new System.Drawing.Point(2, 4);
            this.panelPurcheaesReport.Name = "panelPurcheaesReport";
            this.panelPurcheaesReport.Size = new System.Drawing.Size(281, 182);
            this.panelPurcheaesReport.TabIndex = 0;
            // 
            // lvlShowTotalPurchases
            // 
            this.lvlShowTotalPurchases.AutoSize = true;
            this.lvlShowTotalPurchases.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlShowTotalPurchases.Location = new System.Drawing.Point(171, 22);
            this.lvlShowTotalPurchases.Name = "lvlShowTotalPurchases";
            this.lvlShowTotalPurchases.Size = new System.Drawing.Size(16, 16);
            this.lvlShowTotalPurchases.TabIndex = 1;
            this.lvlShowTotalPurchases.Text = "0";
            // 
            // lvlTotalPurchases
            // 
            this.lvlTotalPurchases.AutoSize = true;
            this.lvlTotalPurchases.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlTotalPurchases.Location = new System.Drawing.Point(11, 22);
            this.lvlTotalPurchases.Name = "lvlTotalPurchases";
            this.lvlTotalPurchases.Size = new System.Drawing.Size(133, 16);
            this.lvlTotalPurchases.TabIndex = 0;
            this.lvlTotalPurchases.Text = "Total Purchases : ";
            // 
            // btnSendTotalPurchases
            // 
            this.btnSendTotalPurchases.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendTotalPurchases.Location = new System.Drawing.Point(85, 192);
            this.btnSendTotalPurchases.Name = "btnSendTotalPurchases";
            this.btnSendTotalPurchases.Size = new System.Drawing.Size(88, 42);
            this.btnSendTotalPurchases.TabIndex = 1;
            this.btnSendTotalPurchases.Text = "Send";
            this.btnSendTotalPurchases.UseVisualStyleBackColor = true;
            this.btnSendTotalPurchases.Click += new System.EventHandler(this.btnSendTotalPurchases_Click);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(179, 192);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(88, 42);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // PurchasesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 250);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnSendTotalPurchases);
            this.Controls.Add(this.panelPurcheaesReport);
            this.Name = "PurchasesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchases Report";
            this.panelPurcheaesReport.ResumeLayout(false);
            this.panelPurcheaesReport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPurcheaesReport;
        private System.Windows.Forms.Label lvlShowTotalPurchases;
        private System.Windows.Forms.Label lvlTotalPurchases;
        private System.Windows.Forms.Button btnSendTotalPurchases;
        private System.Windows.Forms.Button btnOk;
    }
}