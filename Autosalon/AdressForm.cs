using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Autosalon
{
    public partial class AdressForm : Form
    {
        public AdressForm()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            MailAddress fromAddress = new MailAddress("auto.uln.22@mail.ru");

            if (AdressTextBox.Text == "")
            {
                MessageBox.Show("Введите адрес электронной почты");
            }
            else
            {
                MailAddress toAddress = new MailAddress(AdressTextBox.Text);

                using (MailMessage message = new MailMessage(fromAddress, toAddress))

                using (SmtpClient client = new SmtpClient())
                {
                    message.Subject = "Ваш список избранного";
                    message.Body = "Здравствуйте!" + Environment.NewLine + "Мы прислали Вам содержимое Вашей корзины";
                    message.IsBodyHtml = true;

                    File.AppendAllText("Избранное.csv", "Название,Количество,Цена");
                    foreach(KeyValuePair<Car, int> my_car in SelectedForm.cars_selected)
                    {
                        File.AppendAllText("Избранное.csv", 
                                            Environment.NewLine + 
                                            my_car.Key.name +","+ my_car.Value +","+ my_car.Key.price);
                    }
                    message.Attachments.Add(new Attachment("Избранное.csv"));

                    client.Host = "smtp.mail.ru";
                    client.Port = 587;
                    client.EnableSsl = true;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(fromAddress.Address, "ukWmp3IPaNab1XBAUlPu");
                    client.Send(message);
                }
                MessageBox.Show("Сообщение отправлено");
                Close();
            }            
        }
    }
}
