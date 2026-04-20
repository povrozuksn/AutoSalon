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
    public partial class ToolForm : UserControl
    {
        string name_tool = "";
        string price_tool = "";
        string image_tool = "";
        string id_komplect = "";
        public ToolForm(string id)
        {
            InitializeComponent();
            DesignForm.ApplyDesign(this);
            List<string> list = SQLClass.mySelect("SELECT id, name, price, image, opis FROM complect WHERE id = '" + id + "'");
            id_komplect = list[0];
            Text = list[1];
            NameLabel.Text = list[1];
            name_tool = list[1];
            priceLabel.Text = list[2];
            price_tool = list[2];
            try
            {
                pictureBox1.Load("http://localhost/autosalon/image/" + list[3]);
            }
            catch (Exception) { }
            image_tool = list[3];
            textBox1.Text = list[4];
            ZakazButton.Visible = (MainForm.nameUser != "");
            addOpisButton.Visible = MainForm.isAdmin;
            textBox1.ReadOnly = !MainForm.isAdmin;
        }

        private void ZakazButton_Click(object sender, EventArgs e)
        {
            Car tool = new Car(name_tool, "", "", Convert.ToInt32(price_tool));
            try
            {
                tool.pic.Load("http://localhost/autosalon/image/" + image_tool);
            }
            catch (Exception) { }
            if (SelectedForm.cars_selected.ContainsKey(tool))
            {
                SelectedForm.cars_selected[tool]++;
            }
            else
            {
                SelectedForm.cars_selected.Add(tool, 1);
            }
        }

        private void addOpisButton_Click(object sender, EventArgs e)
        {
            SQLClass.myUpdate("UPDATE complect SET opis = '" + textBox1.Text + "' WHERE id = '" + id_komplect + "'");
            MessageBox.Show("Сохранено");
        }
    }
}
