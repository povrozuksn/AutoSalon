namespace Autosalon
{
    partial class DesignForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ChangeButtonLabel = new System.Windows.Forms.Button();
            this.PrimerLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.LabelfontDialog = new System.Windows.Forms.FontDialog();
            this.ChangeButtonPanel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PrimerPanel = new System.Windows.Forms.Panel();
            this.PanelcolorDialog = new System.Windows.Forms.ColorDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(643, 274);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ChangeButtonLabel);
            this.tabPage1.Controls.Add(this.PrimerLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(635, 239);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Дизайн надписей";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ChangeButtonLabel
            // 
            this.ChangeButtonLabel.Location = new System.Drawing.Point(33, 67);
            this.ChangeButtonLabel.Name = "ChangeButtonLabel";
            this.ChangeButtonLabel.Size = new System.Drawing.Size(180, 31);
            this.ChangeButtonLabel.TabIndex = 1;
            this.ChangeButtonLabel.Text = "Изменить";
            this.ChangeButtonLabel.UseVisualStyleBackColor = true;
            this.ChangeButtonLabel.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // PrimerLabel
            // 
            this.PrimerLabel.AutoSize = true;
            this.PrimerLabel.Location = new System.Drawing.Point(42, 117);
            this.PrimerLabel.Name = "PrimerLabel";
            this.PrimerLabel.Size = new System.Drawing.Size(151, 22);
            this.PrimerLabel.TabIndex = 0;
            this.PrimerLabel.Text = "Пример надписи";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.PrimerPanel);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.ChangeButtonPanel);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(635, 239);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Дизайн панелей";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(635, 239);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Дизайн текстбоксов";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 31);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(635, 239);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Дизайн кнопок";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // LabelfontDialog
            // 
            this.LabelfontDialog.ShowColor = true;
            // 
            // ChangeButtonPanel
            // 
            this.ChangeButtonPanel.Location = new System.Drawing.Point(48, 43);
            this.ChangeButtonPanel.Name = "ChangeButtonPanel";
            this.ChangeButtonPanel.Size = new System.Drawing.Size(180, 31);
            this.ChangeButtonPanel.TabIndex = 2;
            this.ChangeButtonPanel.Text = "Изменить";
            this.ChangeButtonPanel.UseVisualStyleBackColor = true;
            this.ChangeButtonPanel.Click += new System.EventHandler(this.ChangeButtonPanel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Пример панели";
            // 
            // PrimerPanel
            // 
            this.PrimerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrimerPanel.Location = new System.Drawing.Point(262, 58);
            this.PrimerPanel.Name = "PrimerPanel";
            this.PrimerPanel.Size = new System.Drawing.Size(358, 167);
            this.PrimerPanel.TabIndex = 4;
            // 
            // DesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 274);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DesignForm";
            this.Text = "Форма дизайна";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button ChangeButtonLabel;
        private System.Windows.Forms.Label PrimerLabel;
        private System.Windows.Forms.FontDialog LabelfontDialog;
        private System.Windows.Forms.Button ChangeButtonPanel;
        private System.Windows.Forms.Panel PrimerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog PanelcolorDialog;
    }
}