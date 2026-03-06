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
    }
}
