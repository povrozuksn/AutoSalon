using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSalon
{
    public partial class CarForm : Form
    {
        Car car;
        public CarForm(Car _car)
        {
            InitializeComponent();
            car = _car;
            Text = car.name;
            try
            {
                pictureBox1.Load("../../Pictures/" + car.name + ".jpg");
            }
            catch (Exception) { }

            try
            {
                textBox1.Text = car.name + Environment.NewLine + "" + File.ReadAllText("../../Pictures/" + car.name + ".txt");
            }
            catch (Exception) { }
        }

        private void CarForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(SelectForm.selectCars.ContainsKey(car))
            {
                SelectForm.selectCars[car]++;
            }
            else
            SelectForm.selectCars.Add(car, 1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(car.web);
        }
    }
}
