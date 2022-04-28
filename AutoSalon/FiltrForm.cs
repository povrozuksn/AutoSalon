using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSalon
{
    public struct Car
    {
        public string name;
        public int price;
        public string kpp;
        public int power;
        public Button btn;
        public PictureBox picture;

        public Car(string _name, int _price, string _kpp, int _power)
        {
            name = _name;
            price = _price;
            kpp = _kpp;
            power = _power;
            btn = new Button();
            picture = new PictureBox();

            btn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            btn.Text = name;

            picture.SizeMode = PictureBoxSizeMode.Zoom;
            try
            {
                picture.Load("../../Pictures/" + name + ".jpg");
            }
            catch (Exception) { }


        }
    }

    public partial class filtrForm : Form
    {
        public static List<Car> car_list = new List<Car>();

        public filtrForm()
        {
           InitializeComponent();

            int x = 10;
            int y = 10;
            for (int i = 0; i < car_list.Count; i++)
            {
                car_list[i].btn.Location = new Point(x, y);
                car_list[i].btn.Size = new Size(140, 40);
                car_list[i].btn.Click += new EventHandler(CarClick);
                filtrPanel.Controls.Add(car_list[i].btn);

                car_list[i].picture.Location = new Point(x, y + 40);
                car_list[i].picture.Size = new Size(140, 140);
                filtrPanel.Controls.Add(car_list[i].picture);

                x = x + 150;
                if(x + 150 > Width)
                {
                    y = y + 200;
                    x = 10;
                }
            }
        }

        public static void CarClick(object sender, EventArgs e)
        {
            for (int i = 0; i < car_list.Count; i++)
            { 
               if(((Button)sender).Text == car_list[i].btn.Text)
               {
                    CarForm car = new CarForm(car_list[i]);
                    car.ShowDialog();
               }                
            }                          
        }

        private void filtrForm_Load(object sender, EventArgs e)
        {

        }

        private void filtrClick(object sender, EventArgs e)
        {
            int x = 10;
            int y = 10;
            for (int i = 0; i < car_list.Count; i++)
            {
                car_list[i].btn.Visible = true;
                car_list[i].picture.Visible = true;

                if (kppComboBox.Text != "" &&
                   car_list[i].kpp != kppComboBox.Text)
                {
                    car_list[i].btn.Visible = false;
                    car_list[i].picture.Visible = false;
                }

                if (priceTextBox.Text != "" &&
                    car_list[i].price > Convert.ToInt32(priceTextBox.Text))
                {
                    car_list[i].btn.Visible = false;
                    car_list[i].picture.Visible = false;
                }

                if(car_list[i].btn.Visible)
                {
                    car_list[i].btn.Location = new Point(x, y);
                    car_list[i].picture.Location = new Point(x, y + 40);

                    x = x + 150;
                    if (x + 150 > Width)
                    {
                        y = y + 200;
                        x = 10;
                    }
                }
                

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectForm select = new SelectForm();
            select.ShowDialog();
        }
    }
}
