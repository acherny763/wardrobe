using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace wardrobe
{

    public partial class Form1 : Form
    {
        DataBase _dataBase = new DataBase();
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_log_Click(object sender, EventArgs e)
        {
            var login = TB_login.Text;
            var password = TB_pass.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string query = $"SELECT id_user, login, password FROM users_data WHERE login = '{login}' AND password = '{password}'";

            SqlCommand sqlCommand = new SqlCommand(query, _dataBase.getConnection());

            adapter.SelectCommand = sqlCommand;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 form1 = new Form1();
                this.Hide();
                form1.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Такого акканта не существует", "Неуспешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void TB_pass_TextChanged(object sender, EventArgs e)
        {
            TB_pass.PasswordChar = '*';
        }
    }
}
