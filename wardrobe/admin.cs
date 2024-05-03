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
using System.Data.SqlClient;
using System.Windows.Forms;

namespace wardrobe
{
    public partial class admin : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        private readonly HeaderMouseMove _headerMouseMove = new HeaderMouseMove();
        
        
        
        private readonly DataBase _dataBase = new DataBase();
        public admin()
        {
            InitializeComponent();
            
            FormUtilities.CloseForm(this, "LB_close");
            FormUtilities.MinimizeForm(this, "LB_roll");

            SetTableSettings();
        }

        private void TB_login_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            _headerMouseMove.SetLastPoint(e);
        }

        private void header_MouseMove(object sender, MouseEventArgs e)
        {
            _headerMouseMove.MoveForm(e, this);
        }
        private void DGV_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGV_user.Columns[7].Index && e.RowIndex >= 0)
            {
                if (DGV_user.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    string idNumber = DGV_user.Rows[e.RowIndex].Cells[0].Value.ToString();
        
                    DataBase.openConnection();
                    const string query = @"DELETE FROM [wardrobe].[dbo].[reserved_numbers] WHERE id_number = @idNumber";
                    var sqlCommand = new SqlCommand(query, _dataBase.getConnection());
                    sqlCommand.Parameters.AddWithValue("@idNumber", idNumber);
                    var reader = sqlCommand.ExecuteNonQuery();
                    DataBase.closeConnection();
                    SetTableSettings();
                }
            }
        }

        
        private void SetTableSettings()
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Text = "Снять бронь"; // Текст кнопки
            buttonColumn.UseColumnTextForButtonValue = true;
            buttonColumn.DefaultCellStyle.ForeColor = GlobalColors.Txt; // Цвет текста кнопки
            buttonColumn.DefaultCellStyle.BackColor = GlobalColors.Dark; // Цвет фона кнопки
            

            DGV_user.RowHeadersVisible = false;
            DGV_user.ColumnHeadersVisible = false;
            DGV_user.ScrollBars = ScrollBars.Vertical;
            DGV_user.DefaultCellStyle.ForeColor = Color.White;
            var newColumn = new DataGridViewTextBoxColumn();
            DGV_user.Columns.Add(newColumn);

            for (var i = 1; i <= 7; i++)
            {
                if (i < 7)
                {
                    DGV_user.Columns.Add(new DataGridViewTextBoxColumn());
                }
                else
                {
                    DGV_user.Columns.Add(buttonColumn);
                }
            }
            
            DGV_user.Columns[0].Width = 210; // Устанавливаем ширину первой колонки
            DGV_user.Columns[1].Width = 160;
            DGV_user.Columns[2].Width = 160;
            DGV_user.Columns[3].Width = 160;
            DGV_user.Columns[4].Width = 200;
            DGV_user.Columns[5].Width = 230;
            DGV_user.Columns[6].Width = 250;
            
            DGV_user.Columns[7].Width = 180;
            
            
            foreach (DataGridViewColumn column in DGV_user.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            foreach (DataGridViewColumn column in DGV_user.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
            }
            
            foreach (DataGridViewRow row in DGV_user.Rows)
            {
                row.Resizable = DataGridViewTriState.False;
            }
            //Добавлеие
            DGV_user.Rows.Clear(); // Очистка таблицы перед заполнением новыми данными

            // Создаем необходимые столбцы в DataGridView
            DGV_user.Columns.Add("surname", "Фамилия");
            DGV_user.Columns.Add("name", "Имя");
            DGV_user.Columns.Add("middle_name", "Отчество");
            DGV_user.Columns.Add("id_number", "Номер");
            DGV_user.Columns.Add("start_date", "Дата начала");
            DGV_user.Columns.Add("last_date", "Дата окончания");
            DGV_user.Columns.Add("group_info", "Информация о группе");
            
            DataBase.openConnection();
            const string query = @"SELECT u.surname, u.name, u.middle_name, rn.id_number, rn.start_date, rn.last_date, 
                       CONCAT(g.name, '-', g.course, '', g.number) AS group_info
                FROM [wardrobe].[dbo].[reserved_numbers] rn 
                JOIN [wardrobe].[dbo].[users] u ON rn.id_user = u.id 
                JOIN [wardrobe].[dbo].[groups] g ON u.id = g.id 
                ORDER BY rn.id_number";
            var sqlCommand = new SqlCommand(query, _dataBase.getConnection());
            var reader = sqlCommand.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    // Добавляем данные в DataGridView
                    DGV_user.Rows.Add(reader["id_number"], reader["group_info"], reader["surname"], reader["name"], reader["middle_name"], reader["start_date"], reader["last_date"]);
                }
            }
            DGV_user.CellContentClick += DGV_user_CellContentClick;
            


            foreach (DataGridViewRow row in DGV_user.Rows)
            {
                row.Height = 80; // Устанавливаем высоту в пикселях
                row.DefaultCellStyle.BackColor = GlobalColors.Dark; // Устанавливаем цвет фона ячейки
            }
            reader.Close();
            DataBase.closeConnection();
        }


    }
}
