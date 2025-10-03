using Autosalon.Properties;
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

namespace Autosalon
{
    public struct Car
    {
        public string name;
        public string kuzov;
        public string kpp;
        public int price;
        public PictureBox pic;
        public Label lbl;

        public Car(string _name, string _kuzov, string _kpp, int _price)
        {
            name = _name;
            kuzov = _kuzov;
            kpp = _kpp;
            price = _price;
            pic = new PictureBox();
            pic.Tag = name;
            try
            {
                pic.Load("../../Files/" + name + ".jpg");
            }
            catch (Exception) { }
            lbl = new Label();
            lbl.Text = name;
        }
    }

    public partial class MainForm : Form
    {
        List<Car> cars = new List<Car>();
        public static string nameUser = "";
        bool isAdmin = false;

        public MainForm()
        {
            InitializeComponent();

            FilrtPanel.Height = HideButton.Height;
            HelloLabel.Visible = false;
            AdminPanelButton.Visible = false;
            
            string[] strs = File.ReadAllLines("../../Files/cars.txt");
            foreach (string str in strs) 
            {
                string[] parts = str.Split(new string[] {", "}, StringSplitOptions.None);
                Car car = new Car(parts[0], parts[1], parts[2], Convert.ToInt32(parts[3]));
                cars.Add(car);
            }

            ReDraw();             
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            if (FilrtPanel.Height == HideButton.Height)
            {
                FilrtPanel.Height = 115;
                HideButton.Text = "Скрыть";
            }
            else
            {
                FilrtPanel.Height = HideButton.Height;
                HideButton.Text = "Раскрыть";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                if ( ((PictureBox)sender).Tag == cars[i].pic.Tag)
                {
                    PersForm pers = new PersForm(cars[i]);
                    pers.ShowDialog();
                }
            }
        }

        void ReDraw()
        {
            int x = 20;
            int y = 20;
            for (int i = 0; i < cars.Count; i++)
            {
                cars[i].pic.Location = new Point(x, y);
                cars[i].pic.Size = new Size(230, 180);
                cars[i].pic.SizeMode = PictureBoxSizeMode.Zoom;
                cars[i].pic.Click += new EventHandler(pictureBox1_Click);
                InfoPanel.Controls.Add(cars[i].pic);

                cars[i].lbl.Location = new Point(x, y + 180);
                cars[i].lbl.Size = new Size(230, 30);
                cars[i].lbl.TextAlign = ContentAlignment.MiddleCenter;
                InfoPanel.Controls.Add(cars[i].lbl);

                x += 250;
                if (x + 230 > InfoPanel.Width)
                {
                    x = 20;
                    y += 230;
                }
            }
        }

        private void InfoPanel_Resize(object sender, EventArgs e)
        {
            FindButton_Click(null, null);
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            int x = 20;
            int y = 20;
            for (int i = 0; i < cars.Count; i++)
            {
                cars[i].pic.Visible = true;
                cars[i].lbl.Visible = true;

                if(ModelTextBox.Text != "" && !cars[i].name.Contains(ModelTextBox.Text))
                {
                    cars[i].pic.Visible = false;
                    cars[i].lbl.Visible = false;
                }
                
                if (KuzovComboBox.Text != "" && KuzovComboBox.Text != cars[i].kuzov)
                {
                    cars[i].pic.Visible = false;
                    cars[i].lbl.Visible = false;
                }

                if (KPPComboBox.Text != "" && KPPComboBox.Text != cars[i].kpp)
                {
                    cars[i].pic.Visible = false;
                    cars[i].lbl.Visible = false;
                }

                if (cars[i].pic.Visible)
                {
                    cars[i].pic.Location = new Point(x, y);
                    cars[i].lbl.Location = new Point(x, y+180);

                    x += 250;
                    if (x + 230 > InfoPanel.Width)
                    {
                        x = 20;
                        y += 230;
                    }
                }
            }
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            RegForm reg = new RegForm();
            reg.ShowDialog();
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            string[] strs = File.ReadAllLines("users.txt");
            foreach (string str in strs) 
            {
                string[] parts = str.Split(new string[] { ", " }, StringSplitOptions.None);
                
                if(LoginTextBox.Text == parts[2] && PasTextBox.Text == parts[3])
                {
                    nameUser = parts[0] + " " + parts[1];
                    isAdmin = (parts[4] == "1");
                    break;
                }
            }
            if(AuthButton.Text == "Выйти")
            {
                AuthPanel.Controls.Clear();
                AuthPanel.Controls.Add(label2);
                AuthPanel.Controls.Add(LoginTextBox);
                AuthPanel.Controls.Add(label3);
                AuthPanel.Controls.Add(PasTextBox);
                AuthPanel.Controls.Add(AuthButton);
                AuthPanel.Controls.Add(RegButton);
                HelloLabel.Visible = false;
                AdminPanelButton.Visible = false;
                AuthButton.Text = "Войти";
                LoginTextBox.Text = "";
                PasTextBox.Text = "";
                nameUser = "";
                isAdmin = false;
            }
            else
            {
                if(nameUser != "")
                {
                    AuthPanel.Controls.Clear();
                    AuthPanel.Controls.Add(HelloLabel);
                    AuthPanel.Controls.Add(AuthButton);
                    AuthPanel.Controls.Add(AdminPanelButton);
                    AdminPanelButton.Visible = isAdmin;
                    HelloLabel.Text = "Вы авторизовались как " + nameUser;
                    HelloLabel.Visible = true;
                    AuthButton.Text = "Выйти";
                }
                else
                {
                    MessageBox.Show("Введен неверный логин/пароль");
                }
            }
            

        }

        private void AdminPanelButton_Click(object sender, EventArgs e)
        {
            AdminForm form = new AdminForm();
            form.ShowDialog();
        }
    }
}
