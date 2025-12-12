using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autosalon
{
    public partial class AdminToolsForm : Form
    {
        public AdminToolsForm()
        {
            InitializeComponent();

            List<string> car_list = SQLClass.mySelect("SELECT id, name FROM cars");
            for (int i = 0; i < car_list.Count; i += 2)
            {
                carComboBox.Items.Add(car_list[i] + ". " + car_list[i+1]);
            }

            List<string> tool_list = SQLClass.mySelect("SELECT id, name FROM complect");
            for (int i = 0; i < tool_list.Count; i += 2)
            {
                DelComboBox1.Items.Add(tool_list[i] + ". " + tool_list[i + 1]);
            }
        }

        string FileName = "";
        private void loadpicButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog1.FileName;
                picBox.Load(FileName);
                FileName = Path.GetFileName(openFileDialog1.FileName);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int a;
            if (!Int32.TryParse(priceTextBox.Text, out a))
            {
                MessageBox.Show("Цена не число");
                return;
            }

            if (nameTextBox.Text == "" || carComboBox.Text == "" || priceTextBox.Text == "")
            {
                MessageBox.Show("Все поля обязательны для заполнения");
                return;
            }

            string car_id = carComboBox.Text.Split(new string[] { ". " }, StringSplitOptions.None)[0];

            SQLClass.myUpdate("INSERT INTO complect (name, price, car_id, image, opis) VALUES ('" + nameTextBox.Text + "', '" + priceTextBox.Text + "', '" + car_id + "', '" + FileName + "', '" + opisTextBox.Text + "')");

            MessageBox.Show("Сохранено");
            var result = MessageBox.Show("Вы хотите продолжить добавление объектов", "Следующий шаг", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                nameTextBox.Text = "";
                carComboBox.Text = "";
                priceTextBox.Text = "";
            }
            else
            {
                Close();
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
                string id = DelComboBox1.Text.Split(new string[] { ". " }, StringSplitOptions.None)[0];
                SQLClass.myUpdate("DELETE FROM complect WHERE id = '" + id + "'");
                MessageBox.Show("Удалено");
                DelComboBox1.Text = "";
                textBox1.Text = "";
            }
        }
    }
}
