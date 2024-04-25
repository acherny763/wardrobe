using System;
using System.Linq;
using System.Windows.Forms;

namespace wardrobe
{
    #region Работа с событиями Enter, Leave у TextBox элементов + placeholders
    public static class TextBoxManipulation
    {
        public static void AttachEnterEventToTextBoxes(Control ctrl)
        {
            var textBoxes = ctrl.Controls.OfType<TextBox>().ToArray();
            
            foreach (var textBox in textBoxes)
            {
                textBox.Leave += TextBox_Leave;
                textBox.Enter += TextBox_Enter;
                textBox.Enter += TextBox_Click;
            }
        }
        
        private static void ClearColorState(Control ctrl)
        {
            foreach (Control control in ctrl.Controls)
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
                TB_login = "Логин",
                TB_pass = "Пароль",
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
                case "TB_pass":
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
                TB_login = "Логин",
                TB_pass = "Пароль",
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
                case "TB_pass":
                case "TB_password":
                case "TB_rePassword":
                    textBox.PasswordChar = '•';
                    break;
            }
            
            if (!string.IsNullOrWhiteSpace(textBox.Text) && textBox.Text != labels.GetType().GetProperty(textBoxText)?.GetValue(labels).ToString()) return;
            textBox.Text = string.Empty;
        }
        
        private static void TextBox_Click(object sender, EventArgs e)
        {
            ClearColorState(((Control)sender).Parent);
            
            var clickedTextBox = (TextBox)sender;
            var rawTextBoxName = clickedTextBox.Name;
            var textBoxName = rawTextBoxName.Substring(3);
            var panels = ((Control)sender).Parent.Controls.OfType<Panel>().ToArray();

            foreach (var panel in panels)
            {
                var rawPanelName = panel.Name;
                var panelName = rawPanelName.Substring(3);
                
                if (panelName != textBoxName) continue;
                
                panel.BackColor = GlobalColors.ActiveElem;
                clickedTextBox.BackColor = GlobalColors.ActiveElem;
                clickedTextBox.ForeColor = GlobalColors.White;
            }
        }

        public static void ChangeColorPanel(Control ctrl)
        {
            var panels = ctrl.Controls.OfType<Panel>().ToArray();

            foreach (var panel in panels)
            {
                panel.BackColor = GlobalColors.LightBg;
                panel.Click += Panel_Click;
            }
        }
        
        private static void Panel_Click(object sender, EventArgs e)
        {
            ClearColorState(((Control)sender).Parent);
            
            var clickedPanel = (Panel)sender;
            var rawPanelName = clickedPanel.Name;
            var panelName = rawPanelName.Substring(3);
            var textBoxName = $"TB_{panelName}";
            var textBoxes = ((Control)sender).Parent.Controls.OfType<TextBox>().ToArray();

            foreach (var textBox in textBoxes)
            {
                if (textBox.Name != textBoxName) continue;
                
                textBox.Focus();
                clickedPanel.BackColor = GlobalColors.ActiveElem;
                textBox.BackColor = GlobalColors.ActiveElem;
                textBox.ForeColor = GlobalColors.White;
            }
            
        }
    }
    
    #endregion
}