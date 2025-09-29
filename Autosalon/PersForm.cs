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
        public PersForm(Car car)
        {
            InitializeComponent();
            Text = car.name;
            nameLabel.Text = car.name;
            kuzovLabel.Text = car.kuzov;
            kppLabel.Text = car.kpp;
            priceLabel.Text = car.price.ToString();
            pictureBox1.Image = car.pic.Image;
            try
            {
                textBox1.Text = System.IO.File.ReadAllText("../../Files/" + car.name + ".txt");
            }
            catch (Exception){ }
            
        }
    }
}
