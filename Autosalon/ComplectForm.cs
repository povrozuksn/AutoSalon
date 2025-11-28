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
    public partial class ComplectForm : Form
    {
        public ComplectForm(string car_id)
        {
            InitializeComponent();

            nameCarLabel.Text = "Комплектующие для: " + SQLClass.mySelect("SELECT name FROM cars WHERE id = '" + car_id + "'")[0];
            List<string> complect = SQLClass.mySelect("SELECT id, name, price, image FROM complect WHERE car_id = '" + car_id + "'");
            
            if(complect.Count>0)
            {
                int y = 70;
                for(int i=0; i<complect.Count; i+=4)
                {
                    #region Картинка
                    PictureBox pic = new PictureBox();
                    pic.Location = new Point(30, y);
                    pic.Size = new Size(50, 50);
                    pic.SizeMode = PictureBoxSizeMode.Zoom;
                    pic.BorderStyle = BorderStyle.FixedSingle;
                    try
                    {
                        pic.Load("http://localhost/autosalon/image/" + complect[i+3]);
                    }
                    catch (Exception) { }
                    Controls.Add(pic);
                    #endregion

                    #region Наименование
                    Label lbl = new Label();
                    lbl.Location = new Point(100, y+20);
                    lbl.Size = new Size(500, 20);
                    lbl.Text = complect[i+1] + " " + complect[i+2] + " руб.";
                    Controls.Add(lbl);
                    #endregion

                    #region Кнопка
                    Button btn = new Button();
                    btn.Location = new Point(650, y+15);
                    btn.Size = new Size(100,30);
                    btn.Text = "Подробнее";
                    btn.Tag = complect[i];
                    btn.Click += new EventHandler(Compl_Click);
                    Controls.Add(btn);
                    #endregion

                    y += 52;
                }
            }
        }

        private void Compl_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            ToolForm tool = new ToolForm(b.Tag.ToString());
            tool.ShowDialog();
        }

    }
}
