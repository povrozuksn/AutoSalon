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
    public partial class AddCarForm : Form
    {
        public AddCarForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.File.AppendAllText("Автомобили.txt",
                Environment.NewLine +
                nameTB.Text + ", " +
                priceTB.Text + ", " +
                kppCB.Text + ", " +
                powerTB.Text);

            if(fileName !="")
            System.IO.File.Copy(fileName, "../../Pictures/" + nameTB.Text + ".jpg");

            MessageBox.Show("Сохранено");
        }

        string fileName = "";
        private void button2_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                pictureBox1.Load(fileName);
            }
        }
    }
}
