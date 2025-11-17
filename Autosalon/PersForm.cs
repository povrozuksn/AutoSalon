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
using System.Xml.Linq;

namespace Autosalon
{
    public partial class PersForm : Form
    {
        Car car;
        string car_id;
        public PersForm(Car _car)
        {
            InitializeComponent();

            car = _car;

            Text = car.name;
            nameLabel.Text = car.name;
            kuzovLabel.Text = car.kuzov;
            kppLabel.Text = car.kpp;
            priceLabel.Text = car.price.ToString();
            pictureBox1.Image = car.pic.Image;

            List<string> car_list = SQLClass.mySelect("SELECT id, opis FROM cars WHERE name = '" + car.name + "'");

            car_id = car_list[0];
            textBox1.Text = car_list[1];
            SelectedButton.Visible = false;
            if(MainForm.nameUser != "")
            {
                SelectedButton.Visible = true;
            }            
        }

        private void SelectedButton_Click(object sender, EventArgs e)
        {
            if(SelectedForm.cars_selected.ContainsKey(car))
            {
                SelectedForm.cars_selected[car]++;
            }
            else
            {
                SelectedForm.cars_selected.Add(car, 1);
            }
        }

        private void ComplectButton_Click(object sender, EventArgs e)
        {
            ComplectForm complectForm = new ComplectForm(car_id);
            complectForm.ShowDialog();
        }
    }
}
