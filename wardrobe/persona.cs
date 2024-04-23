using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace wardrobe
{
    public partial class persona : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        private readonly HeaderMouseMove _headerMouseMove = new HeaderMouseMove();
        // Подписываемся на событие CellPainting для DataGridView
        public persona()
        {
            InitializeComponent();
            setTableSettings();
            //pictureBox1.Paint += new PaintEventHandler(pictureBox1_Paint);
            FormUtilities.CloseForm(this, "LB_close");
            FormUtilities.MinimizeForm(this, "LB_roll");
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Создаем объект Graphics из элемента PictureBox
            Graphics g = e.Graphics;

            // Создаем перо для рисования линии
            Pen pen = new Pen(Color.Black);

            // Рисуем линию от точки (10, 10) до точки (200, 200)
            g.DrawLine(pen, 10, 10, 200, 200);

            // Освобождаем ресурсы
            pen.Dispose();
            g.Dispose();
        }

        public void setTableSettings()
        {
            DGV_number.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, DGV_number.Width, DGV_number.Height, 24, 24));
            DGV_number.CellFormatting += DGV_number_CellFormatting;
            // Настраиваем свойства DataGridView
            
            DGV_number.RowHeadersVisible = false;
            DGV_number.ColumnHeadersVisible = false;
            DGV_number.ScrollBars = ScrollBars.Vertical;
            

            // Создаем новый столбец
            DataGridViewTextBoxColumn newColumn = new DataGridViewTextBoxColumn();
            
    
            // Добавляем новый столбец в DataGridView
            DGV_number.Columns.Add(newColumn);

            // Добавляем 5 столбцов
            for (int i = 1; i <= 5; i++)
            {
                DGV_number.Columns.Add(new DataGridViewTextBoxColumn());
            }

            // Заполняем таблицу данными
            int value = 1;
            for (int row = 0; row < 120; row++) // Всего 120 строк для чисел от 1 до 600
            {
                DGV_number.Rows.Add();
                for (int col = 0; col < 5; col++)
                {
                    DGV_number.Rows[row].Cells[col].Value = value;
                    value++;
                }
            }
            foreach (DataGridViewColumn column in DGV_number.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            /*foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.Padding = new Padding(8,  8, 8, 8); // Величина отступов: слева, сверху, справа, снизу
            }*/
            // Устанавливаем ширину для каждого столбца
            foreach (DataGridViewColumn column in DGV_number.Columns)
            {
                column.Width = 71; // Устанавливаем ширину столбца в пикселях
            }

            // Устанавливаем высоту для каждой строки
            foreach (DataGridViewRow row in DGV_number.Rows)
            {
                row.Height = 60; // Устанавливаем высоту строки в пикселях
            }
            // Запрещаем изменение ширины столбцов пользователем
            foreach (DataGridViewColumn column in DGV_number.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
            }

            // Запрещаем изменение высоты строк пользователем
            foreach (DataGridViewRow row in DGV_number.Rows)
            {
                row.Resizable = DataGridViewTriState.False;
            }
            
        }
        private void DGV_number_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null)
            {
                
                DGV_number.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = GlobalColors.Dark;
                DGV_number.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.White;
            }
        }
      
        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            _headerMouseMove.SetLastPoint(e);
        }

        private void header_MouseMove_1(object sender, MouseEventArgs e)
        {
            _headerMouseMove.MoveForm(e, this);
        }
    }
}
