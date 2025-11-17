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

            List<string> complect = SQLClass.mySelect("SELECT id, name, price FROM complect WHERE car_id = '" + car_id + "'");
            
            if(complect.Count>0)
            {
                int y = 70;
                for(int i=0; i<complect.Count; i+=3)
                {
                    Label lbl = new Label();
                    lbl.Location = new Point(30, y);
                    lbl.Size = new Size(500, 20);
                    lbl.Text = complect[i+1] + " " + complect[i+2] + " руб.";
                    Controls.Add(lbl);

                    y += 22;
                }
            }
        }
    }
}
