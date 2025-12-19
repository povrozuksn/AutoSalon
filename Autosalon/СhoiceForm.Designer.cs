namespace Autosalon
{
    partial class СhoiceForm
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
            this.CarButton = new System.Windows.Forms.Button();
            this.ToolsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CarButton
            // 
            this.CarButton.Location = new System.Drawing.Point(62, 73);
            this.CarButton.Name = "CarButton";
            this.CarButton.Size = new System.Drawing.Size(236, 56);
            this.CarButton.TabIndex = 0;
            this.CarButton.Text = "Изменить список автомобилей";
            this.CarButton.UseVisualStyleBackColor = true;
            this.CarButton.Click += new System.EventHandler(this.CarButton_Click);
            // 
            // ToolsButton
            // 
            this.ToolsButton.Location = new System.Drawing.Point(62, 158);
            this.ToolsButton.Name = "ToolsButton";
            this.ToolsButton.Size = new System.Drawing.Size(236, 56);
            this.ToolsButton.TabIndex = 1;
            this.ToolsButton.Text = "Изменить список комплектующих";
            this.ToolsButton.UseVisualStyleBackColor = true;
            this.ToolsButton.Click += new System.EventHandler(this.ToolsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите вариант внесения изменений";
            // 
            // InfoButton
            // 
            this.InfoButton.Location = new System.Drawing.Point(62, 248);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(236, 56);
            this.InfoButton.TabIndex = 3;
            this.InfoButton.Text = "Сводная информация по БД";
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // СhoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 352);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToolsButton);
            this.Controls.Add(this.CarButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "СhoiceForm";
            this.Text = "СhoiceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CarButton;
        private System.Windows.Forms.Button ToolsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InfoButton;
    }
}