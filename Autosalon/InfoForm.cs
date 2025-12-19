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
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        private void infoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            InfoPanel.Controls.Clear();
            if(infoComboBox.Text == "Машины")
            {
                List<string> list = SQLClass.mySelect("SELECT id, name FROM cars");
                int y = 10;
                for(int i=0; i<list.Count;i+=2)
                {
                    Label lbl_id = new Label();
                    lbl_id.Location = new Point(20, y);
                    lbl_id.Size = new Size(30, 15);
                    lbl_id.Text = list[i];
                    InfoPanel.Controls.Add(lbl_id);

                    Label lbl_name = new Label();
                    lbl_name.Location = new Point(55, y);
                    lbl_name.Size = new Size(200, 15);
                    lbl_name.Text = list[i+1];
                    InfoPanel.Controls.Add(lbl_name);

                    y += 20;
                }
            }

            else if (infoComboBox.Text == "Комплектующие")
            {
                List<string> list = SQLClass.mySelect("SELECT id, name, car_id FROM complect");
                int y = 10;
                for (int i = 0; i < list.Count; i += 3)
                {
                    Label lbl_id = new Label();
                    lbl_id.Location = new Point(20, y);
                    lbl_id.Size = new Size(30, 15);
                    lbl_id.Text = list[i];
                    InfoPanel.Controls.Add(lbl_id);

                    Label lbl_name = new Label();
                    lbl_name.Location = new Point(55, y);
                    lbl_name.Size = new Size(200, 15);
                    lbl_name.Text = list[i + 1];
                    InfoPanel.Controls.Add(lbl_name);

                    string car = SQLClass.mySelect("SELECT name FROM cars WHERE id = '" + list[i+2] + "'")[0];

                    Label lbl_car = new Label();
                    lbl_car.Location = new Point(260, y);
                    lbl_car.Size = new Size(200, 15);
                    lbl_car.Text = car;
                    InfoPanel.Controls.Add(lbl_car);

                    y += 20;
                }
            }

            else if (infoComboBox.Text == "Пользователи")
            {
                List<string> list = SQLClass.mySelect("SELECT id, name, family FROM users");
                int y = 10;
                for (int i = 0; i < list.Count; i += 3)
                {
                    Label lbl_id = new Label();
                    lbl_id.Location = new Point(20, y);
                    lbl_id.Size = new Size(30, 15);
                    lbl_id.Text = list[i];
                    InfoPanel.Controls.Add(lbl_id);

                    Label lbl_name = new Label();
                    lbl_name.Location = new Point(55, y);
                    lbl_name.Size = new Size(200, 15);
                    lbl_name.Text = list[i + 1];
                    InfoPanel.Controls.Add(lbl_name);

                    Label lbl_family = new Label();
                    lbl_family.Location = new Point(260, y);
                    lbl_family.Size = new Size(200, 15);
                    lbl_family.Text = list[i + 2];
                    InfoPanel.Controls.Add(lbl_family);

                    y += 20;
                }
            }
        }
    }
}
