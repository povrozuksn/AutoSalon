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

        private void button15_Click(object sender, EventArgs e)
        {
            FeedBackForm feedBack = new FeedBackForm();
            feedBack.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if(AuthForm.login == "")
            {
                AuthForm auth = new AuthForm();
                auth.ShowDialog();
            }
            else
            {
                AuthForm.login = "";
            }

            if (AuthForm.login == "")
            {
                button16.Text = "Войти";
                label1.Text = "";
            }
            else
            {
                button16.Text = "Выйти";
                label1.Text = "Привет, пользователь " + AuthForm.login;

            }

        }

        private void DelCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelCarForm delCar = new DelCarForm();
            delCar.ShowDialog();
            MainForm_Load(sender, e);
        }
    }
}
