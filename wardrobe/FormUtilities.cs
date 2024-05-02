using System;
using System.Windows.Forms;

namespace wardrobe
{
    public static class FormUtilities
    {
        public static void CloseForm(Form form, string buttonName)
        {
            var controls = form.Controls.Find(buttonName, true);

            if (controls.Length > 0 && controls[0] is Label closeButton)
            {
                closeButton.Click += (sender, e) => Application.Exit();
            }
            else
            {
                MessageBox.Show($"Кнопка с именем '{buttonName}' не найдена на форме.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public static void MinimizeForm(Form form, string buttonName)
        {
            var controls = form.Controls.Find(buttonName, true);
            
            if (controls.Length > 0 && controls[0] is Label minimizeButton)
            {
                minimizeButton.Click += (sender, e) => form.WindowState = FormWindowState.Minimized;
            }
            else
            {
                MessageBox.Show($"Кнопка с именем '{buttonName}' не найдена на форме.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}