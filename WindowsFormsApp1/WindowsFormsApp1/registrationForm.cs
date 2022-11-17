using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class registrationForm : Form
    {
        public registrationForm()
        {
            InitializeComponent();
            this.passwordBox.AutoSize = false;
            this.passwordBox.Size = new Size(this.passwordBox.Size.Width, 40);
            UserNameField.Text = "введите имя";
            SurnameField.Text = "введите фамилию";
        }

        private void close_buttonClick_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void registrationForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        Point lastPoint;

        private void registrationForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

      

        private void UserNameField_Enter(object sender, EventArgs e)
        {
            if(UserNameField.Text=="введите имя")
            UserNameField.Text = "";
        }

        private void SurnameField_Enter(object sender, EventArgs e)
        {
            if (SurnameField.Text == "введите фамилию")
                SurnameField.Text = "";
        }

        private void UserNameField_Leave(object sender, EventArgs e)
        {
            if(UserNameField.Text=="")
            UserNameField.Text = "введите имя";
        }

        private void SurnameField_Leave(object sender, EventArgs e)
        {
            if (SurnameField.Text == "")
                SurnameField.Text = "введите фамилию";
        }

        private void button_registration_Click(object sender, EventArgs e)
        {
            if (userBox.Text == "введите имя" )
            {
                MessageBox.Show("ошибка регистрации");
                return;
            }
            if (passwordBox.Text == "")
            {
                MessageBox.Show("ошибка регистрации");
                return;
            }
            if (UserNameField.Text == "")
            {
                MessageBox.Show("ошибка регистрации");
                return;
            }
            if (SurnameField.Text == "введите фамилию")
            {
                MessageBox.Show("ошибка регистрации");
                return;
            }

            if (isUserExists())
            
                return;
            



            DB db = new DB();
           
            //команда запроса в бд
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` ( `login`, `password`, `name`, `surname`) VALUES ( @login, @pas, @name, @surname)", db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = userBox.Text;
            command.Parameters.Add("@pas", MySqlDbType.VarChar).Value = passwordBox.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = UserNameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = SurnameField.Text;
            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                this.Hide();
                Form1 loginForm = new Form1();
                loginForm.Show();
            }
               
            else
                MessageBox.Show("ошибка");
            db.closeConnection();
            
        }
        public Boolean isUserExists()
        {
            DB db = new DB();
           
            DataTable table = new DataTable();
            
            MySqlDataAdapter adapter = new MySqlDataAdapter();

                       
            MySqlCommand comand = new MySqlCommand("SELECT * FROM `users` where `login`= @uL ", db.getConnection());
            
            comand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = userBox.Text;
            

            adapter.SelectCommand = comand;
            
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("пользователь с таким логином существует");
                return true;
            }
                
            else
             
            return false;

        }

        private void loginLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
