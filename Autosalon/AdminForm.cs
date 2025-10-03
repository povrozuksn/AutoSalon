using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autosalon
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int a;
            if(!Int32.TryParse(PriceTextBox.Text, out a))
            {
                MessageBox.Show("Цена не число");
                return;
            }
            
            if(ModelTextBox.Text == "" || KuzovComboBox.Text == "" || KPPComboBox.Text == "" || PriceTextBox.Text == "")
            {
                MessageBox.Show("Поля с * обязательны для заполнения");
                return;
            }

            System.IO.File.AppendAllText("../../Files/cars.txt", ModelTextBox.Text + ", " +
                                                                 KuzovComboBox.Text + ", " +
                                                                 KPPComboBox.Text + ", " +
                                                                 PriceTextBox.Text + 
                                                                 Environment.NewLine);

            MessageBox.Show("Сохранено");
            ModelTextBox.Text = "";
            KuzovComboBox.Text = "";
            KPPComboBox.Text = "";
            PriceTextBox.Text = "";
        }
    }
}
