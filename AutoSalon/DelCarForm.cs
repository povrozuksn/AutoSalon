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
    public partial class DelCarForm : Form
    {
        public DelCarForm()
        {
            InitializeComponent();
        }

        private void DelCarForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < filtrForm.car_list.Count; i++)
            {
                comboBox1.Items.Add(filtrForm.car_list[i].name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            System.IO.File.Delete("Автомобили.txt");
            for (int i = 0; i < filtrForm.car_list.Count; i++)
            {
                if(textBox1.Text == filtrForm.car_list[i].name)
                { }
                else
                {
                    System.IO.File.AppendAllText("Автомобили.txt",
                                        filtrForm.car_list[i].name + ", " +
                                        filtrForm.car_list[i].price + ", " +
                                        filtrForm.car_list[i].kpp + ", " +
                                        filtrForm.car_list[i].power + ", " +
                                        filtrForm.car_list[i].web +
                                        Environment.NewLine);
                }
            }
            MessageBox.Show("Удалено");
            Close();
        }
    }
}
