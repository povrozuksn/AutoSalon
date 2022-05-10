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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CarClick(object sender, EventArgs e)
        {
            filtrForm.CarClick(sender, e);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            filtrForm filtr = new filtrForm();
            filtr.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            filtrForm.car_list.Clear();
            string[] lines = System.IO.File.ReadAllLines("Автомобили.txt");

            foreach(string str in lines)
            {
                string[] parts = str.Split(new string[] {", "}, StringSplitOptions.None);
                Car car = new Car(parts[0], Convert.ToInt32(parts[1]), parts[2], Convert.ToInt32(parts[3]), parts[4]);
                filtrForm.car_list.Add(car);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SelectForm select = new SelectForm();
            select.ShowDialog();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCarForm add = new AddCarForm();
            add.ShowDialog();
            MainForm_Load(sender, e);
        }
    }
}
