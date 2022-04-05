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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CarClick(object sender, EventArgs e)
        {
            filtrForm.CarClick(sender, e);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            filtrForm filtr = new filtrForm();
            filtr.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            filtrForm.car_list[0] = new Car("Lada Priora",     446000,  "МКПП", 98);
            filtrForm.car_list[1] = new Car("Lada Granta",     627800,  "МКПП", 87);
            filtrForm.car_list[2] = new Car("Lada Vesta",      1035900, "МКПП", 106);
            filtrForm.car_list[3] = new Car("KIA Sorento",     2659900, "АКПП", 180);
            filtrForm.car_list[4] = new Car("KIA Soul",        1319900, "МКПП", 123);
            filtrForm.car_list[5] = new Car("KIA Sportage",    2319900, "АКПП", 184);
            filtrForm.car_list[6] = new Car("Nissan Note",     499000,  "МКПП", 88);
            filtrForm.car_list[7] = new Car("Nissan Qashqai",  1597000, "МКПП", 115);
            filtrForm.car_list[8] = new Car("Nissan Xtrail",   2325000, "МКПП", 130);
            filtrForm.car_list[9] = new Car("Toyota Corolla",  1675000, "МКПП", 122);
            filtrForm.car_list[10] = new Car("Toyota Camry",   2563000, "АКПП", 200);
            filtrForm.car_list[11] = new Car("Toyota Supra",   5534000, "АКПП", 340);
            filtrForm.car_list[12] = new Car("Lada Xray",      1548000, "АКПП", 106);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            SelectForm select = new SelectForm();
            select.ShowDialog();
        }
    }
}
