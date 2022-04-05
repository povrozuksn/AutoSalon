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
            int x = 20;
            int y = 10;
            foreach (Car car in selectCars)
            {
                //1 столбец
                PictureBox picture = new PictureBox();
                picture.Location = new Point(x, y);
                picture.Size = new Size(200, 200);
                picture.SizeMode = PictureBoxSizeMode.Zoom;
                picture.Image = car.picture.Image;
                Controls.Add(picture);

                //2 столбец
                Label label1 = new Label();
                label1.Font = new Font("Microsoft Sans Serif", 16);
                label1.Text = "Модель: " + car.name;
                label1.Location = new Point(x + 210, y);
                label1.Size = new Size(200, 40);
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

                //3 столбец
                Label label4 = new Label();
                label4.Font = new Font("Microsoft Sans Serif", 12);
                label4.Text = "ЦЕНА - " + car.price.ToString() + " руб.";
                label4.Location = new Point(x + 500, y+50);
                label4.Size = new Size(200, 40);
                Controls.Add(label4);

                y = y + 190;
                
            }


        }

        private void SelectForm_Load(object sender, EventArgs e)
        {

        }
    }
}