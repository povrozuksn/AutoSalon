namespace Autosalon
{
    partial class AdminToolsForm
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
            this.AddPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DelPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.carComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.loadpicButton = new System.Windows.Forms.Button();
            this.opisTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.AddPanel.SuspendLayout();
            this.DelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AddPanel
            // 
            this.AddPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddPanel.Controls.Add(this.addButton);
            this.AddPanel.Controls.Add(this.opisTextBox);
            this.AddPanel.Controls.Add(this.loadpicButton);
            this.AddPanel.Controls.Add(this.picBox);
            this.AddPanel.Controls.Add(this.label5);
            this.AddPanel.Controls.Add(this.priceTextBox);
            this.AddPanel.Controls.Add(this.label4);
            this.AddPanel.Controls.Add(this.label3);
            this.AddPanel.Controls.Add(this.carComboBox);
            this.AddPanel.Controls.Add(this.nameTextBox);
            this.AddPanel.Controls.Add(this.label1);
            this.AddPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddPanel.Location = new System.Drawing.Point(0, 0);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.Size = new System.Drawing.Size(1060, 455);
            this.AddPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавить комплект";
            // 
            // DelPanel
            // 
            this.DelPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DelPanel.Controls.Add(this.label2);
            this.DelPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DelPanel.Location = new System.Drawing.Point(0, 455);
            this.DelPanel.Name = "DelPanel";
            this.DelPanel.Size = new System.Drawing.Size(1060, 164);
            this.DelPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Удалить комплект";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(27, 204);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(290, 28);
            this.nameTextBox.TabIndex = 1;
            // 
            // carComboBox
            // 
            this.carComboBox.FormattingEnabled = true;
            this.carComboBox.Location = new System.Drawing.Point(27, 109);
            this.carComboBox.Name = "carComboBox";
            this.carComboBox.Size = new System.Drawing.Size(286, 30);
            this.carComboBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Выбери автомобиль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Введи наименование";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Введи стоимость, руб.";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(27, 283);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(290, 28);
            this.priceTextBox.TabIndex = 5;
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox.Location = new System.Drawing.Point(338, 36);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(350, 310);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 7;
            this.picBox.TabStop = false;
            // 
            // loadpicButton
            // 
            this.loadpicButton.Location = new System.Drawing.Point(338, 352);
            this.loadpicButton.Name = "loadpicButton";
            this.loadpicButton.Size = new System.Drawing.Size(350, 34);
            this.loadpicButton.TabIndex = 8;
            this.loadpicButton.Text = "Загрузить картинку";
            this.loadpicButton.UseVisualStyleBackColor = true;
            this.loadpicButton.Click += new System.EventHandler(this.loadpicButton_Click);
            // 
            // opisTextBox
            // 
            this.opisTextBox.Location = new System.Drawing.Point(706, 36);
            this.opisTextBox.Multiline = true;
            this.opisTextBox.Name = "opisTextBox";
            this.opisTextBox.Size = new System.Drawing.Size(342, 310);
            this.opisTextBox.TabIndex = 9;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(814, 407);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(224, 42);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AdminToolsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 619);
            this.Controls.Add(this.DelPanel);
            this.Controls.Add(this.AddPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminToolsForm";
            this.Text = "AdminToolsForm";
            this.AddPanel.ResumeLayout(false);
            this.AddPanel.PerformLayout();
            this.DelPanel.ResumeLayout(false);
            this.DelPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AddPanel;
        private System.Windows.Forms.Panel DelPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loadpicButton;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox carComboBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox opisTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}