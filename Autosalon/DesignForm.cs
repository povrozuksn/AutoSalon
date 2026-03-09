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
    public partial class DesignForm : Form
    {
        public static Font LABEL_FONT;
        public static Color LABEL_FONT_COLOR;

        public DesignForm()
        {
            InitializeComponent();

            ReApply();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            LabelfontDialog.Font = LABEL_FONT;
            LabelfontDialog.Color = LABEL_FONT_COLOR;

            if (LabelfontDialog.ShowDialog() == DialogResult.OK)
            {
                LABEL_FONT = LabelfontDialog.Font;
                LABEL_FONT_COLOR = LabelfontDialog.Color;

                ReApply();

                SQLClass.myUpdate("DELETE FROM design WHERE type = '" + PrimerLabel.GetType() + "' AND parametr = 'FONT'");
                SQLClass.myUpdate("DELETE FROM design WHERE type = '" + PrimerLabel.GetType() + "' AND parametr = 'FONT_COLOR'");

                SQLClass.myUpdate("INSERT INTO design (type, parametr, value) VALUES ('" + PrimerLabel.GetType() + "', 'FONT', '" + LABEL_FONT.Name + ";" + LABEL_FONT.Size.ToString() + "')");
                SQLClass.myUpdate("INSERT INTO design (type, parametr, value) VALUES ('" + PrimerLabel.GetType() + "', 'FONT_COLOR', '" + LABEL_FONT_COLOR.ToArgb() + "')");
            }
        }

        void ReApply()
        {
            PrimerLabel.Font = LABEL_FONT;
            PrimerLabel.ForeColor = LABEL_FONT_COLOR;
        }

        public static void ApplyDesign(Control Form)
        {
            foreach (Control control in Form.Controls)
            {
                if(control is Label)
                {
                    control.Font = LABEL_FONT;
                    control.ForeColor = LABEL_FONT_COLOR;
                }
                else
                {
                    ApplyDesign(control);
                }
            }
        }

        public static void ReadDesign()
        {
             
            string font = SQLClass.mySelect("SELECT value FROM design WHERE type = 'System.Windows.Forms.Label' AND parametr = 'FONT'")[0];
            string[] parts = font.Split(new char[] { ';' });
            LABEL_FONT = new Font(new FontFamily(parts[0]), (float)Convert.ToDouble(parts[1]));

            string color = SQLClass.mySelect("SELECT value FROM design WHERE type = 'System.Windows.Forms.Label' AND parametr = 'FONT_COLOR'")[0];
            LABEL_FONT_COLOR = Color.FromArgb(Convert.ToInt32(color));
                       
        }
    }
}
