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
        public CarForm(string car)
        {
            InitializeComponent();
            Text = car;
            try
            {
                pictureBox1.Load("../../Pictures/" + car + ".jpg");
            }
            catch (Exception) { }

            try
            {
                textBox1.Text = car + Environment.NewLine + "" + File.ReadAllText("../../Pictures/" + car + ".txt");
            }
            catch (Exception) { }
        }

        private void CarForm_Load(object sender, EventArgs e)
        {

        }
    }
}
