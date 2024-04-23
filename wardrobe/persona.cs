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
            BTN_all.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BTN_all.Width, BTN_all.Height, 25, 25));
            BTN_free.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BTN_free.Width, BTN_free.Height, 25, 25));
            BTN_occupied.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BTN_occupied.Width, BTN_occupied.Height, 25, 25));
            BTN_1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BTN_1.Width, BTN_1.Height, 25, 25));
            BTN_7.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BTN_7.Width, BTN_7.Height, 25, 25));
            BTN_30.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BTN_30.Width, BTN_30.Height, 25, 25));
            
            BTN_all.Click += Button_Click;
            BTN_free.Click += Button_Click;
            BTN_occupied.Click += Button_Click;
            BTN_1.Click += Button_num_Click;
            BTN_7.Click += Button_num_Click;
            BTN_30.Click += Button_num_Click;
            
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

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            // Сбрасываем цвет всех кнопок
            BTN_all.BackColor = Color.FromArgb(27, 32, 38);
            BTN_free.BackColor = Color.FromArgb(27, 32, 38);
            BTN_occupied.BackColor = Color.FromArgb(27, 32, 38);

            // Устанавливаем цвет для нажатой кнопки
            clickedButton.BackColor = GlobalColors.Dark;
        }
        
        private void Button_num_Click(object sender, EventArgs e)
        {
            Button clickedButton_num = (Button)sender;

            // Сбрасываем цвет всех кнопок
            BTN_1.BackColor = Color.FromArgb(27, 32, 38);
            BTN_7.BackColor = Color.FromArgb(27, 32, 38);
            BTN_30.BackColor = Color.FromArgb(27, 32, 38);

            // Устанавливаем цвет для нажатой кнопки
            clickedButton_num.BackColor = GlobalColors.Dark;
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
 
        private void header_MouseDown_1(object sender, MouseEventArgs e)
        {
            _headerMouseMove.SetLastPoint(e);
        }

        private void header_MouseMove(object sender, MouseEventArgs e)
        {
            _headerMouseMove.MoveForm(e, this);
        }
    }
}
