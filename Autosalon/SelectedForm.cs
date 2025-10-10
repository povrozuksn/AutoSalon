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
    public partial class SelectedForm : Form
    {
        public static List<Car> cars_selected = new List<Car>();
        public SelectedForm()
        {
            InitializeComponent();
            UserLabel.Text = "Избранное пользователя: " + MainForm.nameUser;

            int x=50; int y=50;
            foreach (Car car in cars_selected)
            {
                #region 1 столбец
                PictureBox picture = new PictureBox();
                picture.Location = new Point(x, y);
                picture.Size = new Size(230, 180);
                picture.SizeMode = PictureBoxSizeMode.Zoom;
                picture.Image = car.pic.Image;
                Controls.Add(picture);
                #endregion

                #region 2 столбец
                Label name_label = new Label();
                name_label.Location = new Point(x+240, y);
                name_label.Size = new Size(300, 30);
                //name_label.BorderStyle = BorderStyle.FixedSingle;
                name_label.Text = "Наименование: " + car.name;
                Controls.Add(name_label);

                Label kuzov_label = new Label();
                kuzov_label.Location = new Point(x + 240, y+40);
                kuzov_label.Size = new Size(300, 30);
                kuzov_label.Text = "Тип кузова: " + car.kuzov;
                Controls.Add(kuzov_label);

                Label kpp_label = new Label();
                kpp_label.Location = new Point(x + 240, y + 80);
                kpp_label.Size = new Size(300, 30);
                kpp_label.Text = "Тип КПП: " + car.kpp;
                Controls.Add(kpp_label);
                #endregion

                #region 3 столбец
                Label price_label = new Label();
                price_label.Location = new Point(x + 550, y);
                price_label.Size = new Size(300, 30);
                price_label.Text = "Цена, руб.: " + car.price;
                Controls.Add(price_label);
                #endregion

                y += 200;

            }

        }
    }
}
