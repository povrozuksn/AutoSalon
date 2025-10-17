using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autosalon
{
    public partial class SelectedForm : Form
    {
        public static Dictionary<Car, int> cars_selected = new Dictionary<Car, int>();

        public SelectedForm()
        {
            InitializeComponent();
            UserLabel.Text = "Избранное пользователя: " + MainForm.nameUser;

            ReDraw();
        }

        void ReDraw()
        {
            Controls.Clear();
            Controls.Add(UserLabel);
            Controls.Add(totalPriceLabel);

            int x = 50; int y = 50;
            foreach (KeyValuePair<Car, int> car_select in cars_selected)
            {
                Car car = car_select.Key;

                #region 1 столбец
                PictureBox picture = new PictureBox();
                picture.Location = new Point(x, y);
                picture.Size = new Size(230, 180);
                picture.SizeMode = PictureBoxSizeMode.Zoom;
                picture.Image = car.pic.Image;
                Controls.Add(picture);
                #endregion

                #region 2 столбец
                Label name_label = new Label();
                name_label.Location = new Point(x + 240, y);
                name_label.Size = new Size(300, 30);
                name_label.Text = "Наименование: " + car.name;
                Controls.Add(name_label);

                Label kuzov_label = new Label();
                kuzov_label.Location = new Point(x + 240, y + 40);
                kuzov_label.Size = new Size(300, 30);
                kuzov_label.Text = "Тип кузова: " + car.kuzov;
                Controls.Add(kuzov_label);

                Label kpp_label = new Label();
                kpp_label.Location = new Point(x + 240, y + 80);
                kpp_label.Size = new Size(300, 30);
                kpp_label.Text = "Тип КПП: " + car.kpp;
                Controls.Add(kpp_label);
                #endregion

                #region 3 столбец
                Label price_label = new Label();
                price_label.Location = new Point(x + 550, y);
                price_label.Size = new Size(200, 30);
                //price_label.BorderStyle = BorderStyle.FixedSingle;
                price_label.Text = "Цена, руб.: " + car.price;
                Controls.Add(price_label);

                Label count_label = new Label();
                count_label.Location = new Point(x + 550, y + 40);
                count_label.Size = new Size(150, 20);
                count_label.Text = "Количество, шт.: ";
                Controls.Add(count_label);

                NumericUpDown count = new NumericUpDown();
                count.Location = new Point(x + 550, y + 60);
                count.Size = new Size(150, 30);
                count.Value = car_select.Value;
                count.ValueChanged += new EventHandler(CountChanged);
                Controls.Add(count);

                Label stoimot_label = new Label();
                stoimot_label.Location = new Point(x + 550, y + 90);
                stoimot_label.Size = new Size(250, 20);
                stoimot_label.Text = "Стоимость, руб.: " + car_select.Value* car.price;
                Controls.Add(stoimot_label);
                #endregion

                #region 4 столбец
                Button del = new Button();
                del.Location = new Point(x + 850, y + 50);
                del.Size = new Size(150, 60);
                del.BackColor = Color.Red;
                del.Text = "Удалить из избранного";
                del.Click += new EventHandler(DelClick);
                Controls.Add(del);
                #endregion

                y += 200;

            }

            totalPrice = 0;
            foreach (KeyValuePair<Car, int> car_select in cars_selected)
            {
                totalPrice += car_select.Value * car_select.Key.price;
            }
            totalPriceLabel.Text = "Общая стоимость, руб.: " + totalPrice.ToString();
        }

        void DelClick(object sender, EventArgs e)
        {
            int i = 0;
            Button bnt = (Button)sender;
            Dictionary<Car, int> cars_selected1 = new Dictionary<Car, int>();
            foreach (KeyValuePair<Car, int> car_select in cars_selected)
            {
                Car car = car_select.Key;
                if (bnt.Location == new Point(900, 200 * i + 100))
                {

                }
                else
                {
                    cars_selected1[car_select.Key] = car_select.Value;
                }
                i++;
            }
            cars_selected = cars_selected1;
            ReDraw();
        }

        int totalPrice = 0;
        void CountChanged(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;

            for(int i=0; i<cars_selected.Count; i++)
            {
                if (num.Location == new Point(600, 200 * i + 110))
                {
                    Image image = null;
                    int price = 0;
                    foreach (Control ctrl in Controls)
                    {
                        if (ctrl is PictureBox && ctrl.Location == new Point(50, 200 * i + 50))
                        {
                            image = ((PictureBox)ctrl).Image;
                        }
                    }

                    foreach (Car car in MainForm.cars)
                    {
                        if (car.pic.Image == image)
                        {
                            cars_selected[car] = Convert.ToInt32(num.Value);
                        }
                    }

                    foreach (Control ctrl in Controls)
                    {
                        if (ctrl is Label && ctrl.Location == new Point(600, 200 * i + 50))
                        {
                            price = Convert.ToInt32(ctrl.Text.Replace("Цена, руб.: ", ""));
                        }
                    }

                    foreach (Control ctrl in Controls)
                    {
                        if (ctrl is Label && ctrl.Location == new Point(600, 200 * i + 140))
                        {
                            ctrl.Text = "Стоимость, руб.: " + (price * num.Value).ToString();
                        }
                    }
                }
            }

            totalPrice = 0;
            foreach (KeyValuePair<Car, int> car_select in cars_selected)
            {
                totalPrice += car_select.Value * car_select.Key.price;
            }
            totalPriceLabel.Text = "Общая стоимость, руб.: " + totalPrice.ToString();

        }




    }
}
