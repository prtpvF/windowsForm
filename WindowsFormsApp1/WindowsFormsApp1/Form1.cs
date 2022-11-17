using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.passwordBox.AutoSize = false;
            this.passwordBox.Size = new Size(this.passwordBox.Size.Width, 48);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            this.closeButton.ForeColor = Color.White;
        }

      

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            this.closeButton.ForeColor = Color.Black;
        }

        Point lastPoint;

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            //значение из поля логина
            String loginUser = userBox.Text;
            //значение из поля пароля
            String passwordUser = passwordBox.Text;

            //для указания бд
            DB db = new DB();
            //таблица в который можем обращаться к каждой записи
            DataTable table = new DataTable();
            //выбирает даные из бд
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            // объект для выборки из бд                     //запрос в бд
            MySqlCommand comand = new MySqlCommand("SELECT * FROM `users` where `login`= @uL and `password` = @uP ", db.getConnection());
            //меняем заглушки на значения 
            comand.Parameters.Add("@uL", MySqlDbType.VarChar).Value=loginUser;
            comand.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passwordUser;

            adapter.SelectCommand = comand;
            //трансформируем внутрь объекта table
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                mainForm mainForm = new mainForm();
                mainForm.Show();
            }

            else
                MessageBox.Show("no");





        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            registrationForm registrationForm = new registrationForm();
            registrationForm.Show();
        }
    }
    }
