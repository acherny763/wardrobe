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

        public Form1()
        {
            InitializeComponent();

            TextBoxManipulation.AttachEnterEventToTextBoxes(this);
            TextBoxManipulation.ChangeColorPanel(this);

            FormUtilities.CloseForm(this, "LB_close");
            FormUtilities.MinimizeForm(this, "LB_roll");

            this.BackColor = GlobalColors.Bg;

            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            LB_header.ForeColor = GlobalColors.Txt;
            heading.ForeColor = GlobalColors.White;
            header.ForeColor = GlobalColors.Dark;
            StartPosition = FormStartPosition.CenterScreen;
        }

        public sealed override Color BackColor
        {
            get => base.BackColor;
            set => base.BackColor = value;
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
            
                var adapter = new SqlDataAdapter();
                var table = new DataTable();
            
                var query =
                    $"SELECT id_user, login, password FROM users_data WHERE login = '{login}' AND password = '{password}'";
            
                var sqlCommand = new SqlCommand(query, _dataBase.getConnection());
            
                adapter.SelectCommand = sqlCommand;
                adapter.Fill(table);
            
                if (table.Rows.Count == 1)
                {
                    var personaForm = new Persona();
                    this.Hide();
                    personaForm.Show();
                }
                else
                {
                    MessageBox.Show("Такого акканта не существует", "Неуспешно", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }

            if (!string.IsNullOrWhiteSpace(TB_login.Text) && !string.IsNullOrWhiteSpace(TB_pass.Text)) return;
            MessageBox.Show("Заполните все поля!");
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

        private void BTN_reg_Click(object sender, EventArgs e)
        {
            var regForm = new Reg();
            this.Hide();
            regForm.Show();
        }
    }
}
