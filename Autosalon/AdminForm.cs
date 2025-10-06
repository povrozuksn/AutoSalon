using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace Autosalon
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            for(int i=0; i<MainForm.cars.Count; i++)
            {
                DelComboBox1.Items.Add(MainForm.cars[i].name);
            }
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

            File.AppendAllText("../../Files/cars.txt", ModelTextBox.Text + ", " +
                                                                 KuzovComboBox.Text + ", " +
                                                                 KPPComboBox.Text + ", " +
                                                                 PriceTextBox.Text + 
                                                                 Environment.NewLine);

            if(FileName != "")
            {
                File.Copy(FileName, "../../Files/" + ModelTextBox.Text + ".jpg");
            }

            File.AppendAllText("../../Files/" + ModelTextBox.Text + ".txt", OpisTextBox.Text);
            
            MessageBox.Show("Сохранено");
            var result = MessageBox.Show("Вы хотите продолжить добавление объектов", "Следующий шаг", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ModelTextBox.Text = "";
                KuzovComboBox.Text = "";
                KPPComboBox.Text = "";
                PriceTextBox.Text = "";
            }
            else 
            { 
                Close();
            }
        }

        string FileName = "";
        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog1.FileName;
                picBox.Load(FileName);
            }
        }

        private void DelComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = DelComboBox1.Text;
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите удалить выбранный объект", "Удаление объекта", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                File.Delete("../../Files/cars.txt");
                for(int i=0; i<MainForm.cars.Count; i++)
                {
                    if(textBox1.Text == MainForm.cars[i].name)
                    {

                    }
                    else
                    {
                        File.AppendAllText("../../Files/cars.txt", MainForm.cars[i].name + ", " +
                                                                 MainForm.cars[i].kuzov + ", " +
                                                                 MainForm.cars[i].kpp + ", " +
                                                                 MainForm.cars[i].price +
                                                                 Environment.NewLine);
                    }
                }
                MessageBox.Show("Удалено");
            }

        }
    }
}
