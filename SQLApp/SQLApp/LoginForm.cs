using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLApp
{
    public partial class LoginForm : Form
    {

        public static SqlConnectionStringBuilder SqlConnectionString;
        private DataGridView dataGridView1;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConBuilder.ConnectionStringBuilder.UserID = LoginField.Text;
            SqlConBuilder.ConnectionStringBuilder.Password = PassField.Text;

            if (SqlConBuilder.ConnectionTest() == true)
            {
                MessageBox.Show("Соединение установлено");
            }
            else
            {
                MessageBox.Show("Ошибка подключения");
            }
        }

        private void Login_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Result ResultForm = new Result();
            ResultForm.Show();
            




        }
        
    }
}
