namespace Autosalon
{
    partial class InfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.infoComboBox = new System.Windows.Forms.ComboBox();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // infoComboBox
            // 
            this.infoComboBox.FormattingEnabled = true;
            this.infoComboBox.Items.AddRange(new object[] {
            "",
            "Машины",
            "Комплектующие",
            "Пользователи"});
            this.infoComboBox.Location = new System.Drawing.Point(421, 33);
            this.infoComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.infoComboBox.Name = "infoComboBox";
            this.infoComboBox.Size = new System.Drawing.Size(288, 28);
            this.infoComboBox.TabIndex = 0;
            this.infoComboBox.Text = "Выберите таблицу БД";
            this.infoComboBox.SelectedIndexChanged += new System.EventHandler(this.infoComboBox_SelectedIndexChanged);
            // 
            // InfoPanel
            // 
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InfoPanel.Location = new System.Drawing.Point(0, 69);
            this.InfoPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(1090, 591);
            this.InfoPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сводная информация по таблицам БД";
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 660);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.infoComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InfoForm";
            this.Text = "InfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox infoComboBox;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Label label1;
    }
}