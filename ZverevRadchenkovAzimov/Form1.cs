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

namespace ZverevRadchenkovAzimov
{
    public partial class login_user : Form
    {
        DataBase dataBase = new DataBase();
        public login_user()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void login_user_Load(object sender, EventArgs e)
        {
            textBox_name.PasswordChar = '*';
            textBox_surname.PasswordChar = '*';
            textBox_name.MaxLength = 50;
            textBox_surname.MaxLength = 50;
        }

        private void login_Click(object sender, EventArgs e)
        {

        }

        private void login_name_Click(object sender, EventArgs e)
        {

        }

        private void login_surname_Click(object sender, EventArgs e)
        {

        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_surname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            var login_name = textBox_name.Text;
            var login_surname = textBox_surname.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable(); 

            string querystring = $"select id, login, password from register where login ='{login_name}' and password ='{login_surname}'";
            SqlCommand command = new SqlCommand(querystring, dataBase.GetConnection()); 

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1) 
            {
                MessageBox.Show("Вы успешно вошли!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridView dtg = new DataGridView();
                dtg.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Такого аккаунта не существует!", "Аккаунта нет!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
