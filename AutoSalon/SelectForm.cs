﻿using System;
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
        public static List<Car> selectCars = new List<Car>();

        public SelectForm()
        {
            InitializeComponent();
            Text = "Избранное";
            Draw();
        }

        void Draw()
        {
            Controls.Clear();
            int x = 20;
            int y = 10;
            foreach (Car car in selectCars)
            {
                #region 1 столбец
                PictureBox picture = new PictureBox();
                picture.Location = new Point(x, y);
                picture.Size = new Size(200, 200);
                picture.SizeMode = PictureBoxSizeMode.Zoom;
                picture.Image = car.picture.Image;
                Controls.Add(picture);
                #endregion

                #region 2 столбец
                Label label1 = new Label();
                label1.Font = new Font("Microsoft Sans Serif", 14);
                label1.Text = "Модель: " + car.name;
                label1.Location = new Point(x + 210, y);
                label1.Size = new Size(250, 40);
                Controls.Add(label1);
                
                Label label2 = new Label();
                label2.Font = new Font("Microsoft Sans Serif", 12);
                label2.Text = "Мощность двигателя - " + car.power.ToString() + " л.с.";
                label2.Location = new Point(x + 210, y+50);
                label2.Size = new Size(250, 40);
                Controls.Add(label2);

                Label label3 = new Label();
                label3.Font = new Font("Microsoft Sans Serif", 12);
                label3.Text = "Тип трансмиссии - " + car.kpp;
                label3.Location = new Point(x + 210, y + 100);
                label3.Size = new Size(200, 40);
                Controls.Add(label3);
                #endregion

                #region 3 столбец
                Label label4 = new Label();
                label4.Font = new Font("Microsoft Sans Serif", 12);
                label4.Text = "ЦЕНА - " + car.price.ToString() + " руб.";
                label4.Location = new Point(x + 500, y+50);
                label4.Size = new Size(200, 40);
                Controls.Add(label4);
                #endregion

                #region 4 столбец
                Button btn_del = new Button();
                btn_del.Font = new Font("Microsoft Sans Serif", 12);
                btn_del.Text = "Удалить";
                btn_del.Location = new Point(x+700, y + 50);
                btn_del.Size = new Size(100, 40);
                btn_del.Click += new EventHandler(Del);
                Controls.Add(btn_del);
                #endregion

                y = y + 190;
                
            }


        }

        void Del(object sender, EventArgs e)
        {
            
            Button b = new Button();
            b = (Button)sender;
            List<Car> selectCars1 = new List<Car>();
            foreach (Car car in selectCars)
            {
                if(b.Location == new Point(720, 60))
                { }
                else
                {
                    selectCars1.Add(car);
                }
            }
            selectCars = selectCars1;
            Draw();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {

        }
    }
}
