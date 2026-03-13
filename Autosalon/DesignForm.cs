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
        #region Параметры Label
        public static Font LABEL_FONT;
        public static Color LABEL_FONT_COLOR;
        #endregion

        #region Параметры Panel
        public static Color PANEL_COLOR;
        #endregion

        public DesignForm()
        {
            InitializeComponent();

            ReApply();
        }

        #region Выбор и сохранение параметров Label
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            LabelfontDialog.Font = LABEL_FONT;
            LabelfontDialog.Color = LABEL_FONT_COLOR;

            if (LabelfontDialog.ShowDialog() == DialogResult.OK)
            {
                LABEL_FONT = LabelfontDialog.Font;
                LABEL_FONT_COLOR = LabelfontDialog.Color;

                ReApply();

                SQLClass.myUpdate("DELETE FROM design WHERE type = '" + PrimerLabel.GetType() + "' AND parametr = 'FONT' AND user = '" + MainForm.user_id + "'");
                SQLClass.myUpdate("DELETE FROM design WHERE type = '" + PrimerLabel.GetType() + "' AND parametr = 'FONT_COLOR' AND user = '" + MainForm.user_id + "'");

                SQLClass.myUpdate("INSERT INTO design (user, type, parametr, value) VALUES ('" + MainForm.user_id + "','" + PrimerLabel.GetType() + "', 'FONT', '" + LABEL_FONT.Name + ";" + LABEL_FONT.Size.ToString() + "')");
                SQLClass.myUpdate("INSERT INTO design (user, type, parametr, value) VALUES ('" + MainForm.user_id + "','" + PrimerLabel.GetType() + "', 'FONT_COLOR', '" + LABEL_FONT_COLOR.ToArgb() + "')");
            }
        }
        #endregion

        #region Применение параметров дизайна на этой форме
        void ReApply()
        {
            PrimerLabel.Font = LABEL_FONT;
            PrimerLabel.ForeColor = LABEL_FONT_COLOR;
            PrimerPanel.BackColor = PANEL_COLOR;
        }
        #endregion

        #region Применение параметров дизайна везде
        public static void ApplyDesign(Control Form)
        {
            foreach (Control control in Form.Controls)
            {
                //Label
                if(control is Label)
                {
                    control.Font = LABEL_FONT;
                    control.ForeColor = LABEL_FONT_COLOR;
                }
                else
                {
                    ApplyDesign(control);
                }
                //Panel
                if (control is Panel)
                {
                    control.BackColor = PANEL_COLOR;
                }
                else
                {
                    ApplyDesign(control);
                }

            }
        }
        #endregion

        #region Чтение параметров дизайна из БД
        public static void ReadDesign()
        {
            #region  Чтение параметров Label
            try
            {
                string font = SQLClass.mySelect("SELECT value FROM design WHERE type = 'System.Windows.Forms.Label' AND parametr = 'FONT' AND user = '" + MainForm.user_id + "'")[0];
                string[] parts = font.Split(new char[] { ';' });
                LABEL_FONT = new Font(new FontFamily(parts[0]), (float)Convert.ToDouble(parts[1]));

                string color = SQLClass.mySelect("SELECT value FROM design WHERE type = 'System.Windows.Forms.Label' AND parametr = 'FONT_COLOR' AND user = '" + MainForm.user_id + "'")[0];
                LABEL_FONT_COLOR = Color.FromArgb(Convert.ToInt32(color));
            }
            catch (Exception) { }
            #endregion

            #region  Чтение параметров Panel
            try
            {
                string color_panel = SQLClass.mySelect("SELECT value FROM design WHERE type = 'System.Windows.Forms.Panel' AND parametr = 'COLOR' AND user = '" + MainForm.user_id + "'")[0];
                PANEL_COLOR = Color.FromArgb(Convert.ToInt32(color_panel));
            }
            catch (Exception) { }
            #endregion
        }
        #endregion

        #region Выбор и сохранение параметров Panel
        private void ChangeButtonPanel_Click(object sender, EventArgs e)
        {
            PanelcolorDialog.Color = PANEL_COLOR;
            if (PanelcolorDialog.ShowDialog() == DialogResult.OK)
            {
                PANEL_COLOR = PanelcolorDialog.Color;
                ReApply();

                SQLClass.myUpdate("DELETE FROM design WHERE type = '" + PrimerPanel.GetType() + "' AND parametr = 'COLOR' AND user = '" + MainForm.user_id + "'");
                SQLClass.myUpdate("INSERT INTO design (user, type, parametr, value) VALUES ('" + MainForm.user_id + "','" + PrimerPanel.GetType() + "', 'COLOR', '" + PANEL_COLOR.ToArgb() + "')");
            }
        }
        #endregion
    }
}
