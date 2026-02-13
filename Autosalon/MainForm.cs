using Autosalon.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace Autosalon
{
    public struct Car
    {
        public string name;
        public string kuzov;
        public string kpp;
        public int price;
        public PictureBox pic;
        public Label lbl;

        public Car(string _name, string _kuzov, string _kpp, int _price)
        {
            name = _name;
            kuzov = _kuzov;
            kpp = _kpp;
            price = _price;
            pic = new PictureBox();
            pic.Tag = name;
            try
            {
                pic.Load("http://127.0.0.1/autosalon/image/" + name + ".jpg");
            }
            catch (Exception) { }
            lbl = new Label();
            lbl.Text = name;
        }
    }

    public partial class MainForm : Form
    {
        public static List<Car> cars = new List<Car>();
        public static string nameUser = "";
        public static string user_id = "";
        bool isAdmin = false;

        public MainForm()
        {
            InitializeComponent();            

            FilrtPanel.Height = HideButton.Height;
            HelloLabel.Visible = false;
            AdminPanelButton.Visible = false;
            SelectedButton.Visible = false;

            CarsUC carsUC = new CarsUC();
            carsUC.Dock = DockStyle.Fill;
            InfoPanel.Controls.Clear();
            InfoPanel.Controls.Add(carsUC);            
        }
       
        private void HideButton_Click(object sender, EventArgs e)
        {
            if (FilrtPanel.Height == HideButton.Height)
            {
                FilrtPanel.Height = 115;
                HideButton.Text = "Скрыть";
            }
            else
            {
                FilrtPanel.Height = HideButton.Height;
                HideButton.Text = "Раскрыть";
            }
        }
        
        private void InfoPanel_Resize(object sender, EventArgs e)
        {
            FindButton_Click(null, null);
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            int x = 20;
            int y = 20;
            for (int i = 0; i < cars.Count; i++)
            {
                cars[i].pic.Visible = true;
                cars[i].lbl.Visible = true;

                if(ModelTextBox.Text != "" && !cars[i].name.Contains(ModelTextBox.Text))
                {
                    cars[i].pic.Visible = false;
                    cars[i].lbl.Visible = false;
                }
                
                if (KuzovComboBox.Text != "" && KuzovComboBox.Text != cars[i].kuzov)
                {
                    cars[i].pic.Visible = false;
                    cars[i].lbl.Visible = false;
                }

                if (KPPComboBox.Text != "" && KPPComboBox.Text != cars[i].kpp)
                {
                    cars[i].pic.Visible = false;
                    cars[i].lbl.Visible = false;
                }

                if (cars[i].pic.Visible)
                {
                    cars[i].pic.Location = new Point(x, y);
                    cars[i].lbl.Location = new Point(x, y+180);

                    x += 250;
                    if (x + 230 > InfoPanel.Width)
                    {
                        x = 20;
                        y += 230;
                    }
                }
            }
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            RegForm reg = new RegForm();
            reg.ShowDialog();
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            List<string> users_list = SQLClass.mySelect("SELECT id, name, family, login, password, admin FROM users");
            
            for (int i=0; i<users_list.Count; i+=6) 
            {                
                if(LoginTextBox.Text == users_list[i+3] && PasTextBox.Text == users_list[i+4])
                {
                    nameUser = users_list[i+1] + " " + users_list[i+2];
                    user_id = users_list[i];
                    isAdmin = (users_list[i+5] == "1");
                    break;
                }
            }
            if(AuthButton.Text == "Выйти")
            {
                AuthPanel.Controls.Clear();
                AuthPanel.Controls.Add(label2);
                AuthPanel.Controls.Add(LoginTextBox);
                AuthPanel.Controls.Add(label3);
                AuthPanel.Controls.Add(PasTextBox);
                AuthPanel.Controls.Add(AuthButton);
                AuthPanel.Controls.Add(RegButton);
                HelloLabel.Visible = false;
                AdminPanelButton.Visible = false;
                AuthButton.Text = "Войти";
                LoginTextBox.Text = "";
                PasTextBox.Text = "";
                nameUser = "";
                isAdmin = false;
                CarsUC carsUC = new CarsUC();
                carsUC.Dock = DockStyle.Fill;
                InfoPanel.Controls.Clear();
                InfoPanel.Controls.Add(carsUC);
                SelectedForm.cars_selected.Clear();
            }
            else
            {
                if(nameUser != "")
                {
                    AuthPanel.Controls.Clear();
                    AuthPanel.Controls.Add(HelloLabel);
                    AuthPanel.Controls.Add(AuthButton);
                    AuthPanel.Controls.Add(AdminPanelButton);
                    AdminPanelButton.Visible = isAdmin;
                    HelloLabel.Text = "Вы авторизовались как " + nameUser;
                    HelloLabel.Visible = true;
                    AuthButton.Text = "Выйти";
                    AuthPanel.Controls.Add(SelectedButton);
                    SelectedButton.Visible = true;
                }
                else
                {
                    MessageBox.Show("Введен неверный логин/пароль");
                }
            }
            

        }

        private void AdminPanelButton_Click(object sender, EventArgs e)
        {
            СhoiceForm form = new СhoiceForm();
            form.ShowDialog();
        }

        private void SelectedButton_Click(object sender, EventArgs e)
        {
            SelectedForm selected = new SelectedForm();
            selected.Dock = DockStyle.Fill;
            InfoPanel.Controls.Clear();
            InfoPanel.Controls.Add(selected);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            List<string> cars_list = SQLClass.mySelect("SELECT id, name FROM cars");
            for(int i=0; i<cars_list.Count; i+=2)
            {
                TreeNode node0 = new TreeNode(cars_list[i+1]);
                node0.Tag = cars_list[i+1];
                treeView1.Nodes[0].Nodes.Add(node0);

                List<string> compl_list = SQLClass.mySelect("SELECT id, name FROM complect WHERE car_id = '" + cars_list[i] + "'");
                for(int j = 0; j < compl_list.Count; j += 2)
                {
                    TreeNode node1 = new TreeNode(compl_list[j+1]);
                    node1.Tag = compl_list[j];
                    node0.Nodes.Add(node1);
                }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node.Level == 0)
            {
                CarsUC carsUC = new CarsUC();
                carsUC.Dock = DockStyle.Fill;
                InfoPanel.Controls.Clear();
                InfoPanel.Controls.Add(carsUC);
            }
            else if(e.Node.Level == 1)
            {
                for (int i = 0; i < MainForm.cars.Count; i++)
                {
                    if (e.Node.Tag.ToString() == MainForm.cars[i].pic.Tag.ToString())
                    {
                        PersForm pers = new PersForm(MainForm.cars[i]);
                        pers.Dock = DockStyle.Fill;
                        InfoPanel.Controls.Clear();
                        InfoPanel.Controls.Add(pers);
                    }
                }
            }
            else if(e.Node.Level == 2)
            {
                ToolForm toolUC = new ToolForm(e.Node.Tag.ToString());
                toolUC.Dock = DockStyle.Fill;
                InfoPanel.Controls.Clear();
                InfoPanel.Controls.Add(toolUC);
            }
        }
    }
}
