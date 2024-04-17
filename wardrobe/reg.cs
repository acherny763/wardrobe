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
    public partial class reg : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        private readonly HeaderMouseMove _headerMouseMove = new HeaderMouseMove();
        public reg()
        {
            InitializeComponent();
            AttachEnterEventToTextBoxes();
            ChangeColorPanel();
            StartPosition = FormStartPosition.CenterScreen;
        }
        
        private void AttachEnterEventToTextBoxes()
        {
            
            var textBoxes = this.Controls.OfType<TextBox>().ToArray();
            
            foreach (var textBox in textBoxes)
            {
                textBox.Leave += TextBox_Leave;
                textBox.Enter += TextBox_Enter;
                textBox.Enter += TextBox_Click;
            }
        }
        
        private void ClearColorState()
        {
            foreach (Control control in this.Controls)
            {
                switch (control)
                {
                    case Panel panel:
                        panel.BackColor = GlobalColors.LightBg;
                        break;
                    case TextBox textBox:
                        textBox.BackColor = GlobalColors.LightBg;
                        break;
                }
            }
        }
        
        private static void TextBox_Leave(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            if (textBox.Text != string.Empty) return;
            
            var textBoxText = textBox.Name;

            var labels = new
            {
                TB_log = "Логин",
                TB_lastName = "Фамилия",
                TB_firstName = "Имя",
                TB_patronymic = "Отчество",
                TB_password = "Пароль",
                TB_rePassword = "Повторите пароль",
                TB_group = "Группа",
                TB_course = "Курс",
                TB_numberGroup = "Номер группы",
            };
            
            textBox.Text = labels.GetType().GetProperty(textBoxText)?.GetValue(labels).ToString();
            textBox.ForeColor = GlobalColors.DarkTxt;

            switch (textBoxText)
            {
                case "TB_password":
                case "TB_rePassword":
                    textBox.PasswordChar = '\0';
                    break;
            }
        }

        private static void TextBox_Enter(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            var textBoxText = textBox.Name;
            
            var labels = new
            {
                TB_log = "Логин",
                TB_lastName = "Фамилия",
                TB_firstName = "Имя",
                TB_patronymic = "Отчество",
                TB_password = "Пароль",
                TB_rePassword = "Повторите пароль",
                TB_group = "Группа",
                TB_course = "Курс",
                TB_numberGroup = "Номер группы",
            };

            switch (textBoxText)
            {
                case "TB_password":
                case "TB_rePassword":
                    textBox.PasswordChar = '•';
                    break;
            }
            
            if (!string.IsNullOrWhiteSpace(textBox.Text) && textBox.Text != labels.GetType().GetProperty(textBoxText)?.GetValue(labels).ToString()) return;
            textBox.Text = string.Empty;
        }

        private void TextBox_Click(object sender, EventArgs e)
        {
            ClearColorState();
            
            var clickedTextBox = (TextBox)sender;
            var rawTextBoxName = clickedTextBox.Name;
            var TextBoxName = rawTextBoxName.Substring(3);
            var panels = this.Controls.OfType<Panel>().ToArray();

            foreach (var panel in panels)
            {
                var rawPanelName = panel.Name;
                var panelName = rawPanelName.Substring(3);
                
                if (panelName != TextBoxName) continue;
                
                panel.BackColor = GlobalColors.ActiveElem;
                clickedTextBox.BackColor = GlobalColors.ActiveElem;
                clickedTextBox.ForeColor = GlobalColors.White;
            }
        }
        
        private void ChangeColorPanel()
        {
            var panels = this.Controls.OfType<Panel>().ToArray();

            foreach (var panel in panels)
            {
                panel.BackColor = GlobalColors.LightBg;
                panel.Click += Panel_Click;
            }
        }
        
        private void Panel_Click(object sender, EventArgs e)
        {
            ClearColorState();
            
            var clickedPanel = (Panel)sender;
            var rawPanelName = clickedPanel.Name;
            var panelName = rawPanelName.Substring(3);
            var textBoxName = $"TB_{panelName}";
            var textBoxes = this.Controls.OfType<TextBox>().ToArray();

            foreach (var textBox in textBoxes)
            {
                if (textBox.Name != textBoxName) continue;
                
                textBox.Focus();
                clickedPanel.BackColor = GlobalColors.ActiveElem;
                textBox.BackColor = GlobalColors.ActiveElem;
                textBox.ForeColor = GlobalColors.White;
            }
            
        }

        private void reg_Load(object sender, EventArgs e)
        {
            FormUtilities.CloseForm(this, "LB_close");
            FormUtilities.MinimizeForm(this, "LB_roll");
        }

        private void header_MouseMove(object sender, MouseEventArgs e)
        {
            _headerMouseMove.MoveForm(e, this);
        }
        
        private void LB_header2_MouseMove(object sender, MouseEventArgs e)
        {
            _headerMouseMove.MoveForm(e, this);
        }

        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            _headerMouseMove.SetLastPoint(e);
        }

        private void LB_header2_MouseDown(object sender, MouseEventArgs e)
        {
            _headerMouseMove.SetLastPoint(e);
        }
    }
}