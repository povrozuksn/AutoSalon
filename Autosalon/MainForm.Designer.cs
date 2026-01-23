namespace Autosalon
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Автомобили");
            this.AuthPanel = new System.Windows.Forms.Panel();
            this.SelectedButton = new System.Windows.Forms.Button();
            this.RegButton = new System.Windows.Forms.Button();
            this.AuthButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PasTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.HelloLabel = new System.Windows.Forms.Label();
            this.AdminPanelButton = new System.Windows.Forms.Button();
            this.FilrtPanel = new System.Windows.Forms.Panel();
            this.FindButton = new System.Windows.Forms.Button();
            this.KPPComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.KuzovComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.HideButton = new System.Windows.Forms.Button();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.AuthPanel.SuspendLayout();
            this.FilrtPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AuthPanel
            // 
            this.AuthPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AuthPanel.Controls.Add(this.SelectedButton);
            this.AuthPanel.Controls.Add(this.RegButton);
            this.AuthPanel.Controls.Add(this.AuthButton);
            this.AuthPanel.Controls.Add(this.label3);
            this.AuthPanel.Controls.Add(this.PasTextBox);
            this.AuthPanel.Controls.Add(this.label2);
            this.AuthPanel.Controls.Add(this.LoginTextBox);
            this.AuthPanel.Controls.Add(this.HelloLabel);
            this.AuthPanel.Controls.Add(this.AdminPanelButton);
            this.AuthPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AuthPanel.Location = new System.Drawing.Point(0, 0);
            this.AuthPanel.Name = "AuthPanel";
            this.AuthPanel.Size = new System.Drawing.Size(1149, 59);
            this.AuthPanel.TabIndex = 0;
            // 
            // SelectedButton
            // 
            this.SelectedButton.Location = new System.Drawing.Point(975, 12);
            this.SelectedButton.Name = "SelectedButton";
            this.SelectedButton.Size = new System.Drawing.Size(162, 33);
            this.SelectedButton.TabIndex = 8;
            this.SelectedButton.Text = "В избранное";
            this.SelectedButton.UseVisualStyleBackColor = true;
            this.SelectedButton.Click += new System.EventHandler(this.SelectedButton_Click);
            // 
            // RegButton
            // 
            this.RegButton.Location = new System.Drawing.Point(736, 12);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(142, 34);
            this.RegButton.TabIndex = 5;
            this.RegButton.Text = "Регистрация";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // AuthButton
            // 
            this.AuthButton.Location = new System.Drawing.Point(620, 12);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(101, 34);
            this.AuthButton.TabIndex = 4;
            this.AuthButton.Text = "Войти";
            this.AuthButton.UseVisualStyleBackColor = true;
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Пароль";
            // 
            // PasTextBox
            // 
            this.PasTextBox.Location = new System.Drawing.Point(390, 15);
            this.PasTextBox.Name = "PasTextBox";
            this.PasTextBox.PasswordChar = '*';
            this.PasTextBox.Size = new System.Drawing.Size(224, 28);
            this.PasTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(78, 15);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(224, 28);
            this.LoginTextBox.TabIndex = 0;
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Location = new System.Drawing.Point(12, 21);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(58, 22);
            this.HelloLabel.TabIndex = 6;
            this.HelloLabel.Text = "label1";
            // 
            // AdminPanelButton
            // 
            this.AdminPanelButton.Location = new System.Drawing.Point(736, 12);
            this.AdminPanelButton.Name = "AdminPanelButton";
            this.AdminPanelButton.Size = new System.Drawing.Size(233, 34);
            this.AdminPanelButton.TabIndex = 7;
            this.AdminPanelButton.Text = "Панель администратора";
            this.AdminPanelButton.UseVisualStyleBackColor = true;
            this.AdminPanelButton.Click += new System.EventHandler(this.AdminPanelButton_Click);
            // 
            // FilrtPanel
            // 
            this.FilrtPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FilrtPanel.Controls.Add(this.FindButton);
            this.FilrtPanel.Controls.Add(this.KPPComboBox);
            this.FilrtPanel.Controls.Add(this.label6);
            this.FilrtPanel.Controls.Add(this.KuzovComboBox);
            this.FilrtPanel.Controls.Add(this.label5);
            this.FilrtPanel.Controls.Add(this.label4);
            this.FilrtPanel.Controls.Add(this.ModelTextBox);
            this.FilrtPanel.Controls.Add(this.HideButton);
            this.FilrtPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FilrtPanel.Location = new System.Drawing.Point(0, 59);
            this.FilrtPanel.Name = "FilrtPanel";
            this.FilrtPanel.Size = new System.Drawing.Size(1149, 131);
            this.FilrtPanel.TabIndex = 1;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(847, 45);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(169, 31);
            this.FindButton.TabIndex = 7;
            this.FindButton.Text = "Найти";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // KPPComboBox
            // 
            this.KPPComboBox.FormattingEnabled = true;
            this.KPPComboBox.Items.AddRange(new object[] {
            "",
            "Механическая",
            "Автоматическая",
            "Вариатор"});
            this.KPPComboBox.Location = new System.Drawing.Point(446, 42);
            this.KPPComboBox.Name = "KPPComboBox";
            this.KPPComboBox.Size = new System.Drawing.Size(221, 30);
            this.KPPComboBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Тип КПП";
            // 
            // KuzovComboBox
            // 
            this.KuzovComboBox.FormattingEnabled = true;
            this.KuzovComboBox.Items.AddRange(new object[] {
            "",
            "Седан",
            "Универсал",
            "Хетчбэк",
            "Внедорожник"});
            this.KuzovComboBox.Location = new System.Drawing.Point(116, 79);
            this.KuzovComboBox.Name = "KuzovComboBox";
            this.KuzovComboBox.Size = new System.Drawing.Size(221, 30);
            this.KuzovComboBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Тип кузова";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Модель";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(116, 39);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(222, 28);
            this.ModelTextBox.TabIndex = 1;
            // 
            // HideButton
            // 
            this.HideButton.Location = new System.Drawing.Point(0, 0);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(110, 33);
            this.HideButton.TabIndex = 0;
            this.HideButton.Text = "Раскрыть";
            this.HideButton.UseVisualStyleBackColor = true;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // InfoPanel
            // 
            this.InfoPanel.AutoScroll = true;
            this.InfoPanel.BackColor = System.Drawing.Color.White;
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoPanel.Location = new System.Drawing.Point(303, 3);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(843, 423);
            this.InfoPanel.TabIndex = 2;
            this.InfoPanel.Resize += new System.EventHandler(this.InfoPanel_Resize);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.19669F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.80331F));
            this.tableLayoutPanel1.Controls.Add(this.InfoPanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.treeView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 190);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1149, 429);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел0";
            treeNode1.Text = "Автомобили";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView1.Size = new System.Drawing.Size(294, 423);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 619);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.FilrtPanel);
            this.Controls.Add(this.AuthPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.AuthPanel.ResumeLayout(false);
            this.AuthPanel.PerformLayout();
            this.FilrtPanel.ResumeLayout(false);
            this.FilrtPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AuthPanel;
        private System.Windows.Forms.Panel FilrtPanel;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Button AuthButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.Button HideButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.ComboBox KuzovComboBox;
        private System.Windows.Forms.ComboBox KPPComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.Button AdminPanelButton;
        private System.Windows.Forms.Button SelectedButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TreeView treeView1;
    }
}

