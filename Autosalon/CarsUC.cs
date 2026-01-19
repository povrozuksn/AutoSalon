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
    public partial class CarsUC : UserControl
    {
        public CarsUC()
        {
            InitializeComponent();

            ReRead();
        }

        void ReRead()
        {
            List<string> cars_list = SQLClass.mySelect("SELECT id, name, kuzov, kpp, price FROM cars");

            MainForm.cars.Clear();
            for (int i = 0; i < cars_list.Count; i += 5)
            {
                Car car = new Car(cars_list[i + 1], cars_list[i + 2], cars_list[i + 3], Convert.ToInt32(cars_list[i + 4]));
                MainForm.cars.Add(car);
            }

            ReDraw();
        }

        void ReDraw()
        {
            Controls.Clear();
            int x = 20;
            int y = 20;
            for (int i = 0; i < MainForm.cars.Count; i++)
            {
                MainForm.cars[i].pic.Location = new Point(x, y);
                MainForm.cars[i].pic.Size = new Size(230, 180);
                MainForm.cars[i].pic.SizeMode = PictureBoxSizeMode.Zoom;
                MainForm.cars[i].pic.Click += new EventHandler(pictureBox1_Click);
                Controls.Add(MainForm.cars[i].pic);

                MainForm.cars[i].lbl.Location = new Point(x, y + 180);
                MainForm.cars[i].lbl.Size = new Size(230, 30);
                MainForm.cars[i].lbl.TextAlign = ContentAlignment.MiddleCenter;
                Controls.Add(MainForm.cars[i].lbl);

                x += 250;
                if (x + 230 > Width)
                {
                    x = 20;
                    y += 230;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < MainForm.cars.Count; i++)
            {
                if (((PictureBox)sender).Tag == MainForm.cars[i].pic.Tag)
                {
                    PersForm pers = new PersForm(MainForm.cars[i]);
                    pers.Dock = DockStyle.Fill;
                    Controls.Clear();
                    Controls.Add( pers );
                }
            }
        }

    }
}
