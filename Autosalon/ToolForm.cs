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
        public ToolForm(string id)
        {
            InitializeComponent();
            List<string> list = SQLClass.mySelect("SELECT id, name, price, image, opis FROM complect WHERE id = '" + id + "'");
            Text = list[1];
            NameLabel.Text = list[1];
            PriceLabel.Text = "Цена: " + list[2] + " руб.";
            try
            {
                pictureBox1.Load("http://localhost/autosalon/image/" + list[3]);
            }
            catch (Exception) { }
            textBox1.Text = list[4];
        }
    }
}
