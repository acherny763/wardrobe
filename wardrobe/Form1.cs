using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            //this.Shown += Form1_Shown;
            
            InitializeComponent();

            this.BackColor = GlobalColors.Bg;

            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            sheathLogin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, sheathLogin.Width, sheathLogin.Height, 24, 24));
            sheathPassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, sheathPassword.Width, sheathPassword.Height, 24, 24));
            TB_login.KeyPress += TB_login_KeyPress;

            LB_header.ForeColor = GlobalColors.Txt;
            heading.ForeColor = GlobalColors.White;
            header.ForeColor = GlobalColors.Dark;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ClearTextBox()
        {
            if (TB_login.Focused && TB_login.Text == "Логин")
            {
                TB_login.Text = "";
                TB_login.ForeColor = GlobalColors.White;
            }
            
            if (TB_pass.Focused && TB_pass.Text == "Пароль")
            {
                TB_pass.Text = "";
                TB_pass.ForeColor = GlobalColors.White;
                TB_pass.PasswordChar = '*';
            }
        }
        private void TB_login_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void TB_pass_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void BTN_log_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TB_login.Text) ||
                string.IsNullOrWhiteSpace(TB_pass.Text) ||
                TB_login.Text.Equals("Логин", StringComparison.OrdinalIgnoreCase) ||
                TB_pass.Text.Equals("Пароль", StringComparison.OrdinalIgnoreCase)
               )
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                var login = TB_login.Text;
                var password = TB_pass.Text;

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();

                string query =
                    $"SELECT id_user, login, password FROM users_data WHERE login = '{login}' AND password = '{password}'";

                SqlCommand sqlCommand = new SqlCommand(query, _dataBase.getConnection());

                adapter.SelectCommand = sqlCommand;
                adapter.Fill(table);

                if (table.Rows.Count == 1)
                {
                    MessageBox.Show("Вы успешно вошли!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Такого акканта не существует", "Неуспешно", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }
        private static void TB_login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
        private void TB_pass_Enter(object sender, EventArgs e)
        {
            ClearTextBox();
            
            TB_pass.BackColor = GlobalColors.ActiveElem;
            sheathPassword.BackColor = GlobalColors.ActiveElem;
            pictureBox2.BackColor = GlobalColors.ActiveElem;
        }

        private void TB_login_Enter(object sender, EventArgs e)
        {
            ClearTextBox();
            
            TB_login.BackColor = GlobalColors.ActiveElem;
            sheathLogin.BackColor = GlobalColors.ActiveElem;
            pictureBox1.BackColor = GlobalColors.ActiveElem;
        }

        private void TB_login_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TB_login.Text))
            {
                TB_login.Text = "Логин";
                TB_login.ForeColor = GlobalColors.DarkTxt;
            }
            
            TB_login.BackColor = GlobalColors.LightBg;
            sheathLogin.BackColor = GlobalColors.LightBg;
            pictureBox1.BackColor = GlobalColors.LightBg;
        }

        private void TB_pass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TB_pass.Text))
            {
                TB_pass.Text = "Пароль";
                TB_pass.ForeColor = GlobalColors.DarkTxt;
                TB_pass.PasswordChar = '\0';
            }
            
            TB_pass.BackColor = GlobalColors.LightBg;
            sheathPassword.BackColor = GlobalColors.LightBg;
            pictureBox2.BackColor = GlobalColors.LightBg;
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

        private void sheathLogin_Click(object sender, EventArgs e)
        {
            TB_login.Focus();
        }

        private void sheathPassword_Click(object sender, EventArgs e)
        {
            TB_pass.Focus();
        }
    }
}
