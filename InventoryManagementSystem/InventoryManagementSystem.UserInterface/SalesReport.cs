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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.UserInterface
{
    public partial class SalesReport : Form
    {
        public SalesReport()
        {
            InitializeComponent();
            loadValue();
        }

        private void loadValue(){

            decimal purchasesCost = 0;
            decimal salesCost = 0;
            decimal profit = 0;
            int salesQuantity = 0;
            string error;
            var salesrepository = new SalesDataRepository();

            foreach (Sales s in salesrepository.GetSalesByDate(DateTime.Today,out error))
            {
                salesCost += s.SalesPrice;
                salesQuantity += s.SalesQuantity;
                var productRepository = new ProductDataRepository();
                Product product = productRepository.GetProductrById(s.ProductId, out error);
                purchasesCost += product.ProductPrice;
            }
            profit = (salesCost*salesQuantity) - (purchasesCost*salesQuantity);

            lvlShowPurchasesCost.Text = Convert.ToString(purchasesCost*salesQuantity);
            lvlShowSalesCost.Text = Convert.ToString(salesCost*salesQuantity);
            lvlShowTotalProfit.Text = Convert.ToString(profit);
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSendToMail_Click(object sender, EventArgs e)
        {
            try
            {
                string email = "prosenghosh25@gmail.com";
                string subject = "Today's Sales Report";
                string message = lvlTotalPerchasesCost.Text + lvlShowPurchasesCost.Text+"\n\n"
                    + lvlSelsCost.Text + lvlShowSalesCost.Text+"\n\n" + lvlShowTotalProfit.Text + lvlShowTotalProfit.Text;
                
                MailMessage mailMessage = new MailMessage();
                btnSendToMail.Enabled = false;
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
                btnSendToMail.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool CheckForEmail(string email)
        {
            bool IsValid = false;
            Regex r = new Regex(@"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
              @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$",
              RegexOptions.IgnoreCase);
            if (r.IsMatch(email)) IsValid = true;
            return IsValid;
        }
    }
}
