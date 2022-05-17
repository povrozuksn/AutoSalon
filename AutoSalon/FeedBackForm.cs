using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace AutoSalon
{
    public partial class FeedBackForm : Form
    {
        public FeedBackForm()
        {
            InitializeComponent();
        }

        private void FeedBackForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailAddress fromMailAddress = new MailAddress("auto.uln.22@gmail.com", "AutoSalon");
            MailAddress toAddress = new MailAddress("auto.uln.22@gmail.com", "User");
            using (MailMessage mailMessage = new MailMessage(fromMailAddress, toAddress))

            using (SmtpClient smtpClient = new SmtpClient())
            {
                mailMessage.Subject = comboBox1.Text;
                mailMessage.Body = "Здравствуйте" + Environment.NewLine + textBox1.Text;
                mailMessage.IsBodyHtml = true;                

                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(fromMailAddress.Address, "fN7-gWy-qGk-883");

                smtpClient.Send(mailMessage);
            }

            MessageBox.Show("Ваша сообщение отправлено");
            Close();
        }
    }
}
