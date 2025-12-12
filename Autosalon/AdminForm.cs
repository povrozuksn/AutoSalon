using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using MySql.Data.MySqlClient.Memcached;
using RestSharp;


namespace Autosalon
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            for(int i=0; i<MainForm.cars.Count; i++)
            {
                DelComboBox1.Items.Add(MainForm.cars[i].name);
            }
        } 

        private async void AddButton_Click(object sender, EventArgs e)
        {
            int a;
            if(!Int32.TryParse(PriceTextBox.Text, out a))
            {
                MessageBox.Show("Цена не число");
                return;
            }
            
            if(ModelTextBox.Text == "" || KuzovComboBox.Text == "" || KPPComboBox.Text == "" || PriceTextBox.Text == "")
            {
                MessageBox.Show("Поля с * обязательны для заполнения");
                return;
            }
            
            SQLClass.myUpdate("INSERT INTO cars (name, kuzov, kpp, price, opis) VALUES ('" + ModelTextBox.Text + "', '" + KuzovComboBox.Text + "', '" + KPPComboBox.Text + "', '" + PriceTextBox.Text + "', '" + OpisTextBox.Text + "')");
            
            if (FileName != "")
            {
                File.Copy(FileName, "../../Files/" + ModelTextBox.Text + ".jpg");

                #region
                /*
                using (var f = System.IO.File.OpenRead(@FileName))
                {
                    var client = new HttpClient();
                    var content = new StreamContent(f);
                    var mpcontent = new MultipartFormDataContent();
                    content.Headers.ContentType = new MediaTypeHeaderValue("image/jpeg");
                    mpcontent.Add(content);
                    await client.PostAsync("http://localhost/autosalon/image", mpcontent);
                }
                */
                /*
                // URL конечной точки REST API  
                string apiUrl = "http://localhost/autosalon/image";
                // Путь к файлу изображения  
                string imagePath = FileName;
                // Создать экземпляр HttpClient  
                using (HttpClient httpClient = new HttpClient())
                {
                    // Читать файл изображения в байты  
                    byte[] imageData = File.ReadAllBytes(imagePath);
                    // Создать ByteArrayContent для данных изображения  
                    ByteArrayContent content = new ByteArrayContent(imageData);
                    // Установить тип содержимого — «multipart/form-data»  
                    content.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");
                    // Создать MultipartFormDataContent с данными изображения  
                    using (MultipartFormDataContent formData = new MultipartFormDataContent())
                    {
                        // Добавить содержимое изображения в данные формы  
                        formData.Add(content, "image", FileName);
                        // Отправить данные формы на конечную точку API  
                        HttpResponseMessage response = await httpClient.PostAsync(apiUrl, formData);
                    }
                }*/
                /*
                // Создать новый экземпляр RestClient и установить базовый URL конечной точки API  
                var client = new RestClient("http://localhost/autosalon/image/");
                // Создать новый экземпляр RestRequest и установить метод HTTP — POST  
                var request = new RestRequest("endpoint", Method.Post);
                // Добавить файл в запрос в виде массива байтов  
                byte[] fileBytes = File.ReadAllBytes(FileName);
                request.AddFile("file", fileBytes, "file.jpg");
                // Выполнить запрос  
                var response = client.Execute(request);
                */
                #endregion
            }
            
            MessageBox.Show("Сохранено");
            var result = MessageBox.Show("Вы хотите продолжить добавление объектов", "Следующий шаг", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ModelTextBox.Text = "";
                KuzovComboBox.Text = "";
                KPPComboBox.Text = "";
                PriceTextBox.Text = "";
            }
            else 
            { 
                Close();
            }
        }

        string FileName = "";
        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog1.FileName;
                picBox.Load(FileName);
            }
        }

        private void DelComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = DelComboBox1.Text;
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите удалить выбранный объект", "Удаление объекта", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {                           
                for(int i=0; i<MainForm.cars.Count; i++)
                {
                    if(textBox1.Text == MainForm.cars[i].name)
                    {
                        SQLClass.myUpdate("DELETE FROM cars WHERE name = '"+ MainForm.cars[i].name + "'");
                        MessageBox.Show("Удалено");
                        DelComboBox1.Text = "";
                        textBox1.Text = "";
                    }                    
                } 
            }
        }

        private void HelpAddButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            HelpAddForm helpAddForm = new HelpAddForm(button.Name.ToString());
            helpAddForm.Show();
        }

        private void HelpDelButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            HelpDelForm helpDelForm = new HelpDelForm(button.Name.ToString());
            helpDelForm.Show();
        }
    }
}
