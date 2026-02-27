using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Autosalon
{
    public partial class FeedBackForm : Form
    {
        public FeedBackForm()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            MailAddress fromAddress = new MailAddress("auto.uln.22@mail.ru");
            MailAddress toAddress = new MailAddress("auto.uln.22@mail.ru");

            using (MailMessage message = new MailMessage(fromAddress, toAddress))

            using (SmtpClient client = new SmtpClient())
            {
                message.Subject = comboBox1.Text;
                message.Body = textBox1.Text;
                message.IsBodyHtml = true;

                client.Host = "smtp.mail.ru";
                client.Port = 587;
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(fromAddress.Address, "");
                client.Send(message);
            }
            MessageBox.Show("Сообщение отправлено");
            Close();
        }
    }
}
