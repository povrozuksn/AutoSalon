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
    public partial class SelectForm : Form
    {
        public static List<Car> selectCars = new List<Car>();

        public SelectForm()
        {
            InitializeComponent();
            int x = 20;
            int y = 10;
            foreach (Car car in selectCars)
            {
                car.picture.Location = new Point(x, y + 40);
                car.picture.Size = new Size(140, 140);
                car.picture.SizeMode = PictureBoxSizeMode.Zoom;
                Controls.Add(car.picture);

                x = x + 150;
                if (x + 140 > Width)
                {
                    x = 20;
                    y = y + 190;
                }
            }


        }

        private void SelectForm_Load(object sender, EventArgs e)
        {

        }
    }
}
