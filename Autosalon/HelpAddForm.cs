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
    public partial class HelpAddForm : Form
    {
        public HelpAddForm(string nameButton)
        {
            InitializeComponent();
            if(nameButton == "HelpAddCarButton")
            {
                textBox1.Text = System.IO.File.ReadAllText("HelpAddCar.txt");
            }
            else if (nameButton == "HelpAddToolButton")
            {
                textBox1.Text = System.IO.File.ReadAllText("HelpAddTool.txt");
            }
        }
    }
}
