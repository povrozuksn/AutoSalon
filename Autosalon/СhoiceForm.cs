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
    public partial class СhoiceForm : Form
    {
        public СhoiceForm()
        {
            InitializeComponent();
        }

        private void CarButton_Click(object sender, EventArgs e)
        {
            AdminForm car = new AdminForm();
            car.ShowDialog();
        }

        private void ToolsButton_Click(object sender, EventArgs e)
        {
            AdminToolsForm toolsForm = new AdminToolsForm();
            toolsForm.ShowDialog();
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm();
            infoForm.ShowDialog();
        }
    }
}
