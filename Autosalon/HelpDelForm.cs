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
        public HelpDelForm()
        {
            InitializeComponent();
            textBox1.Text = System.IO.File.ReadAllText("HelpDel.txt");
        }
    }
}
