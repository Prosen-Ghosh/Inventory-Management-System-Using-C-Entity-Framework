using InventoryManagementSystem.DataRepository;
using InventoryManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.UserInterface
{
    public partial class PurchasesReport : Form
    {
        public PurchasesReport()
        {
            InitializeComponent();
            loadTotalPurchases();
        }

        private void loadTotalPurchases() {
            string error;
            decimal totalPurchases = 0;
            decimal purchasesCost = 0;
            int purchasesQuintity = 0;
            var purchaseRepository = new PurchaseDataRepository();
            foreach(Purchases p in purchaseRepository.GetPurchasesByDate(DateTime.Today,out error)){
                purchasesCost += p.PurchaseProductPrice;
                purchasesQuintity += p.PurchaseProductQuantity;
            }
            totalPurchases = purchasesCost*purchasesQuintity;
            lvlShowTotalPurchases.Text = Convert.ToString(totalPurchases);
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSendTotalPurchases_Click(object sender, EventArgs e)
        {
            try
            {
                string email = "prosenghosh25@gmail.com";
                string subject = "Today's Purchases Report";
                string message = lvlTotalPurchases.Text + lvlShowTotalPurchases.Text + "\n\n";

                MailMessage mailMessage = new MailMessage();
                btnSendTotalPurchases.Enabled = false;
                string myMail = "sourcecodei64@gmail.com";
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;

                mailMessage.From = new MailAddress(myMail);
                mailMessage.To.Add(email);
                mailMessage.Subject = subject;
                mailMessage.Body = message;
                smtp.Credentials = new System.Net.NetworkCredential(myMail, "PROSENghosh");
                smtp.EnableSsl = true;
                smtp.Send(mailMessage);
                MessageBox.Show("Mail Sent.");
                btnSendTotalPurchases.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
