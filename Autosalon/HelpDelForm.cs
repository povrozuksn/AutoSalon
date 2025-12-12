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
    public partial class HelpDelForm : Form
    {
        public HelpDelForm(string nameButton)
        {
            InitializeComponent();
            if (nameButton == "HelpDelCarButton")
            {
                textBox1.Text = System.IO.File.ReadAllText("HelpDelCar.txt");
            }
            else if (nameButton == "HelpDelToolButton")
            {
                textBox1.Text = System.IO.File.ReadAllText("HelpDelTool.txt");
            }
        }
    }
}
