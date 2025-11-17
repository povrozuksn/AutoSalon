namespace Autosalon
{
    partial class ComplectForm
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
            this.nameCarLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameCarLabel
            // 
            this.nameCarLabel.AutoSize = true;
            this.nameCarLabel.Location = new System.Drawing.Point(32, 26);
            this.nameCarLabel.Name = "nameCarLabel";
            this.nameCarLabel.Size = new System.Drawing.Size(58, 22);
            this.nameCarLabel.TabIndex = 0;
            this.nameCarLabel.Text = "label1";
            // 
            // ComplectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 617);
            this.Controls.Add(this.nameCarLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ComplectForm";
            this.Text = "ComplectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameCarLabel;
    }
}