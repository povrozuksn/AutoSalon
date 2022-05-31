using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSalon
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "" || textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Вы не ввели имя или пароль, либо неудачно подтвердили пароль");
            }
            else
            {
                System.IO.File.AppendAllText("Users.txt", textBox1.Text + ", " + textBox2.Text +
                                             Environment.NewLine);
                Close();
            }            
        }
    }
}
