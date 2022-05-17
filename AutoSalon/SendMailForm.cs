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


namespace AutoSalon
{
    public partial class SendMailForm : Form
    {
        public SendMailForm()
        {
            InitializeComponent();
        }

        private void SendMailForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailAddress fromMailAddress = new MailAddress("auto.uln.22@gmail.com", "AutoSalon");
            MailAddress toAddress = new MailAddress(textBox1.Text, "User");
            using (MailMessage mailMessage = new MailMessage(fromMailAddress, toAddress))

            using (SmtpClient smtpClient = new SmtpClient())
            {
                mailMessage.Subject = "Ваша корзина";
                mailMessage.Body = "Здравствуйте" + Environment.NewLine;
                mailMessage.IsBodyHtml = true;

                System.IO.File.WriteAllText("Ваш заказ.csv", "Название,Цена(руб.),Количество(шт.),Стоимость(руб.)");

                foreach (KeyValuePair<Car, int> select_Cars in SelectForm.selectCars)
                {
                    Car car = select_Cars.Key;
                    System.IO.File.AppendAllText("Ваш заказ.csv",
                    Environment.NewLine +
                    car.name + "," + car.price + "," + select_Cars.Value + "," + car.price* select_Cars.Value);
                }

                System.IO.File.AppendAllText("Ваш заказ.csv", 
                    Environment.NewLine + "Общая стоимость заказа (руб.) " + SelectForm.totalPrice);

                mailMessage.Attachments.Add(new Attachment("Ваш заказ.csv"));

                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(fromMailAddress.Address, "fN7-gWy-qGk-883");

                smtpClient.Send(mailMessage);
            }

            MessageBox.Show("Ваша заявка отправлена");
            Close();
        }
    }
}
