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
        public Button btn;
        public PictureBox picture;

        public Car(string _name, int _price, string _kpp)
        {
            name = _name;
            price = _price;
            kpp = _kpp;
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
        Car[] car_list = new Car[12];

        public filtrForm()
        {
           InitializeComponent();

            car_list[0] = new Car("Lada Priora", 446000, "МКПП");
            car_list[1] = new Car("Lada Granta", 627800, "МКПП");
            car_list[2] = new Car("Lada Vesta", 1035900, "МКПП");
            car_list[3] = new Car("KIA Sorento", 2659900, "АКПП");
            car_list[4] = new Car("KIA Soul", 1319900, "МКПП");
            car_list[5] = new Car("KIA Sportage", 2319900, "АКПП");
            car_list[6] = new Car("Nissan Note", 499000, "МКПП");
            car_list[7] = new Car("Nissan Qashqai", 1597000, "МКПП");
            car_list[8] = new Car("Nissan Xtrail", 2325000, "МКПП");
            car_list[9] = new Car("Toyota Corolla", 1675000, "МКПП");
            car_list[10] = new Car("Toyota Camry", 2563000, "АКПП");
            car_list[11] = new Car("Toyota Supra", 5534000, "АКПП");



            int x = 10;
            int y = 10;
            for (int i = 0; i < car_list.Length; i++)
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

        private void CarClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            CarForm car = new CarForm(btn.Text);
            car.ShowDialog();
        }

        private void filtrForm_Load(object sender, EventArgs e)
        {

        }

        private void filtrClick(object sender, EventArgs e)
        {
            int x = 10;
            int y = 10;
            for (int i = 0; i < car_list.Length; i++)
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
    }
}
