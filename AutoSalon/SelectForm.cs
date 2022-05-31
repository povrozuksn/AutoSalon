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
    public partial class SelectForm : Form
    {
        public static int totalPrice = 0;
        public static Dictionary<Car,int> selectCars = new Dictionary<Car, int>();

        public static void Calculate()
        {
            totalPrice = 0;
            foreach (KeyValuePair<Car, int> select_Cars in selectCars)
            {
                totalPrice += select_Cars.Value * select_Cars.Key.price;
            }
        }

        public SelectForm()
        {
            InitializeComponent();
            Text = "Избранное";
            Draw();
        }

        void Draw()
        {
            Controls.Clear();
            Controls.Add(label1);

            Controls.Add(button1);

            int x = 20;
            int y = 10;
            foreach (KeyValuePair<Car,int> Select_Cars in selectCars)
            {
                Car car = Select_Cars.Key;               

                #region 1 столбец
                PictureBox picture = new PictureBox();
                picture.Location = new Point(x, y + AutoScrollPosition.Y);
                picture.Size = new Size(200, 200);
                picture.SizeMode = PictureBoxSizeMode.Zoom;
                picture.Image = car.picture.Image;
                Controls.Add(picture);
                #endregion

                #region 2 столбец
                Label label1 = new Label();
                label1.Font = new Font("Microsoft Sans Serif", 14);
                label1.Text = "Модель: " + car.name;
                label1.Location = new Point(x + 210, y + AutoScrollPosition.Y);
                label1.Size = new Size(250, 40);
                Controls.Add(label1);
                
                Label label2 = new Label();
                label2.Font = new Font("Microsoft Sans Serif", 12);
                label2.Text = "Мощность двигателя - " + car.power.ToString() + " л.с.";
                label2.Location = new Point(x + 210, y+ 50 + AutoScrollPosition.Y);
                label2.Size = new Size(250, 40);
                Controls.Add(label2);

                Label label3 = new Label();
                label3.Font = new Font("Microsoft Sans Serif", 12);
                label3.Text = "Тип трансмиссии - " + car.kpp;
                label3.Location = new Point(x + 210, y + 100 + AutoScrollPosition.Y);
                label3.Size = new Size(200, 40);
                Controls.Add(label3);
                #endregion

                #region 3 столбец
                Label label4 = new Label();
                label4.Font = new Font("Microsoft Sans Serif", 12);
                label4.Text = "ЦЕНА(руб.) - " + car.price.ToString();
                label4.Location = new Point(x + 500, y + AutoScrollPosition.Y);
                label4.Size = new Size(200, 30);
                Controls.Add(label4);

                NumericUpDown numericUpDown1 = new NumericUpDown();
                numericUpDown1.Font = new Font("Microsoft Sans Serif", 16);
                numericUpDown1.Location = new Point(x + 500, y + 30 + AutoScrollPosition.Y);
                numericUpDown1.Size = new Size(100, 40);
                numericUpDown1.Value = Select_Cars.Value;
                numericUpDown1.Click += new EventHandler(CountChanged);
                Controls.Add(numericUpDown1);                

                Label label6 = new Label();
                label6.Font = new Font("Microsoft Sans Serif", 12);
                label6.Text = "ИТОГО(руб.) - " + (car.price * Select_Cars.Value).ToString();
                label6.Location = new Point(x + 500, y + 100 + AutoScrollPosition.Y);
                label6.Size = new Size(200, 40);
                Controls.Add(label6);

                #endregion

                #region 4 столбец
                Button btn_del = new Button();
                btn_del.Font = new Font("Microsoft Sans Serif", 12);
                btn_del.Text = "Удалить";
                btn_del.Location = new Point(x+700, y + 50 + AutoScrollPosition.Y);
                btn_del.Size = new Size(100, 40);
                btn_del.Click += new EventHandler(Del);
                Controls.Add(btn_del);
                #endregion

                y = y + 190;
                
            }
            Calculate();
            label1.Text = "ОБЩАЯ СТОИМОСТЬ КОРЗИНЫ (РУБ.)  -  " + totalPrice.ToString();
        }

        void Del(object sender, EventArgs e)
        {
            int i = 0;
            Button b = new Button();
            b = (Button)sender;
            Dictionary<Car, int> selectCars1 = new Dictionary<Car, int>();
            foreach (KeyValuePair<Car,int> Select_Cars in selectCars)
            {
                if(b.Location == new Point(720, 190*i+ 60 + AutoScrollPosition.Y))
                { }
                else
                {
                    selectCars1[Select_Cars.Key] = Select_Cars.Value;
                }
                i++;
            }
            selectCars = selectCars1;
            Draw();
        }

        private void CountChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;            
            for(int i = 0; i < selectCars.Count; i++)
            {
                int price = 0;
                Image image = null;
                if(nud.Location ==new Point(520, 190*i + 40 + AutoScrollPosition.Y))
                { 
                    foreach(Control ctrl in Controls)
                    {
                        if (ctrl is PictureBox && ctrl.Location == new Point(20, 190 * i + 10 + AutoScrollPosition.Y))
                        {
                            image = ((PictureBox)ctrl).Image;
                        }
                    }
                    foreach(Car car in filtrForm.car_list)
                    {
                        if(car.picture.Image == image)
                        {
                            selectCars[car] = Convert.ToInt32(nud.Value);
                        }
                    }
                    foreach(Control ctrl in Controls)
                    {
                        if(ctrl is Label && ctrl.Location == new Point(520, 190 * i + 10 + AutoScrollPosition.Y))
                        {
                            price = Convert.ToInt32(ctrl.Text.Replace("ЦЕНА(руб.) - ", ""));   
                        }
                    }
                    foreach (Control ctrl in Controls)
                    {
                        if (ctrl is Label && ctrl.Location == new Point(520, 190 * i + 110 + AutoScrollPosition.Y))
                        {
                            ctrl.Text = "ИТОГО(руб.) - " + (price * nud.Value).ToString();
                        }
                    }
                }
            }

            Calculate();
            label1.Text = "ОБЩАЯ СТОИМОСТЬ КОРЗИНЫ (РУБ.)  -  " + totalPrice.ToString();

        }

        private void SelectForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendMailForm send = new SendMailForm();
            send.ShowDialog();
        }
    }
}
