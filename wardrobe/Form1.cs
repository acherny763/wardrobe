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
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace wardrobe
{

    public partial class Form1 : Form
    {
        private readonly DataBase _dataBase = new DataBase();
        
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        
        private readonly HeaderMouseMove _headerMouseMove = new HeaderMouseMove();
        
        private void Form1_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
        
        public Form1()
        {
            InitializeComponent();

            this.BackColor = GlobalColors.bg;
            this.Shown += Form1_Shown;
            
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            
            LB_header.ForeColor = GlobalColors.txt;
            heading.ForeColor = GlobalColors.white;
            header.ForeColor = GlobalColors.dark;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ClearTextBox()
        {
            if (TB_pass.Focused && TB_pass.Text == "Пароль")
            {
                TB_pass.Text = "";
                TB_pass.ForeColor = GlobalColors.white;
                TB_pass.PasswordChar = '*';
            }

            if (TB_login.Focused && TB_login.Text == "Логин")
            {
                TB_login.Text = "";
                TB_login.ForeColor = GlobalColors.white;
            }
        }
        private void TB_login_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }
        
        private void TB_login_TextChanged(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void TB_pass_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void BTN_log_Click(object sender, EventArgs e)
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
            }
            else
            {
                MessageBox.Show("Такого акканта не существует", "Неуспешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TB_pass_Enter(object sender, EventArgs e)
        {
            TB_pass.BackColor = GlobalColors.activeElem;
            textBox2.BackColor = GlobalColors.activeElem;
            
            ClearTextBox();
        }

        private void TB_login_Enter(object sender, EventArgs e)
        {
            TB_login.BackColor = GlobalColors.activeElem;
            textBox1.BackColor = GlobalColors.activeElem;
            
            ClearTextBox();
        }

        private void TB_login_Leave(object sender, EventArgs e)
        {
            if (TB_login.Text == "")
            {
                TB_login.Text = "Логин";
                TB_login.ForeColor = GlobalColors.darkTxt;
            }
            
            TB_login.BackColor = GlobalColors.lightBg;
            textBox1.BackColor = GlobalColors.lightBg;
        }

        private void TB_pass_Leave(object sender, EventArgs e)
        {
            if (TB_pass.Text == "")
            {
                TB_pass.Text = "Пароль";
                TB_pass.ForeColor = GlobalColors.darkTxt;
                TB_pass.PasswordChar = '\0';
            }
            
            TB_pass.BackColor = GlobalColors.lightBg;
            textBox2.BackColor = GlobalColors.lightBg;
        }

        private void LB_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void LB_roll_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void panelSignIn_MouseMove(object sender, MouseEventArgs e)
        {
            _headerMouseMove.MoveForm(e, this);
        }
        
        private void panelSignIn_MouseDown(object sender, MouseEventArgs e)
        {
            _headerMouseMove.SetLastPoint(e);
        }
        
        private void LB_header_MouseMove(object sender, MouseEventArgs e)
        {
            _headerMouseMove.MoveForm(e, this);
        }

        private void LB_header_MouseDown(object sender, MouseEventArgs e)
        {
            _headerMouseMove.SetLastPoint(e);
        }
    }
}
