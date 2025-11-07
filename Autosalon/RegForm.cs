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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            if (PassTextBox.Text == RePassTextBox.Text)
            {
                SQLClass.myUpdate("INSERT INTO users (name, family, login, password, admin) VALUES ('" + NameTextBox.Text + "', '" + FamTextBox.Text + "', '" + LoginTextBox.Text + "', '" + PassTextBox.Text + "', 0)");
                MessageBox.Show("Регистрация прошла успешно");
                Close();
            }
            else MessageBox.Show("Пароли не совпадают");
        }
    }
}
