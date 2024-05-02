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
    public partial class Persona : Form
    {
        private readonly DataBase _dataBase = new DataBase();
        private readonly int _userId;
        private string _clickedCellValue;
        private bool _isCellFree = false;
        private int _countDays = 1;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        private readonly HeaderMouseMove _headerMouseMove = new HeaderMouseMove();
        
        public Persona(int userId)
        {
            _userId = userId;
            InitializeComponent();
            SetTableSettings();

            StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = GlobalColors.Bg;
            
            FormUtilities.CloseForm(this, "LB_close");
            FormUtilities.MinimizeForm(this, "LB_roll");

            PN_countDays.BackColor = GlobalColors.LightBg;
            PN_countDays.Width = 360;
            BTN_7.BackColor = GlobalColors.LightBg;
            BTN_30.BackColor = GlobalColors.LightBg;
            
            
            this.FormBorderStyle = FormBorderStyle.None;
            
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            BTN_all.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BTN_all.Width, BTN_all.Height, 25, 25));
            BTN_free.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BTN_free.Width, BTN_free.Height, 25, 25));
            BTN_occupied.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BTN_occupied.Width, BTN_occupied.Height, 25, 25));
            BTN_1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BTN_1.Width, BTN_1.Height, 25, 25));
            BTN_7.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BTN_7.Width, BTN_7.Height, 25, 25));
            BTN_30.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BTN_30.Width, BTN_30.Height, 25, 25));
            PN_countDays.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PN_countDays.Width, PN_countDays.Height, 25, 25));
            
            BTN_all.Click += Button_Click;
            BTN_free.Click += Button_Click;
            BTN_occupied.Click += Button_Click;

            BTN_1.Click += Button_num_Click;
            BTN_7.Click += Button_num_Click;
            BTN_30.Click += Button_num_Click;
            
            BTN_reserve.Text = LB_userNum.Text == "—" ? "Снять бронь" : "Забронировать";

            FillDataGridViewFromDatabase("SELECT id FROM numbers");
        }

        public sealed override Color BackColor
        {
            get => base.BackColor;
            set => base.BackColor = value;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var clickedButton = (Button)sender;
            
            BTN_all.BackColor = GlobalColors.Bg;
            BTN_free.BackColor = GlobalColors.Bg;
            BTN_occupied.BackColor = GlobalColors.Bg;
            
            clickedButton.BackColor = GlobalColors.LightBg;
        }
        
        private void Button_num_Click(object sender, EventArgs e)
        {
            var clickedButtonNum = (Button)sender;
            
            BTN_1.BackColor = GlobalColors.LightBg;
            BTN_7.BackColor = GlobalColors.LightBg;
            BTN_30.BackColor = GlobalColors.LightBg;
            
            clickedButtonNum.BackColor = GlobalColors.Dark;
        }

        private void SetTableSettings()
        {
            DGV_number.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, DGV_number.Width, DGV_number.Height, 24, 24));
            DGV_number.CellFormatting += DGV_number_CellFormatting;
            DGV_number.CellClick += DGV_number_CellClick;
            
            
            DGV_number.RowHeadersVisible = false;
            DGV_number.ColumnHeadersVisible = false;
            DGV_number.ScrollBars = ScrollBars.Vertical;
            
            var newColumn = new DataGridViewTextBoxColumn();
            
            DGV_number.Columns.Add(newColumn);
            
            for (var i = 1; i <= 5; i++)
            {
                DGV_number.Columns.Add(new DataGridViewTextBoxColumn());
            }
            
            foreach (DataGridViewColumn column in DGV_number.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            
            foreach (DataGridViewColumn column in DGV_number.Columns)
            {
                column.Width = 71;
            }
            
            foreach (DataGridViewRow row in DGV_number.Rows)
            {
                row.Height = 60; 
            }
            
            foreach (DataGridViewColumn column in DGV_number.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
            }
            
            foreach (DataGridViewRow row in DGV_number.Rows)
            {
                row.Resizable = DataGridViewTriState.False;
            }
        }
        private void FillDataGridViewFromDatabase(string query)
        {
            DGV_number.Rows.Clear(); // Очистка таблицы перед заполнением новыми данными

            for (var i = 1; i <= 5; i++)
            {
                DGV_number.Columns.Add(new DataGridViewTextBoxColumn());
            }

            DataBase.openConnection();

            var sqlCommand = new SqlCommand(query, _dataBase.getConnection());
            var reader = sqlCommand.ExecuteReader();

            if (reader.HasRows)
            {
                var columnIndex = 0; // Индекс текущей ячейки в строке
                var row = new DataGridViewRow(); // Создаем одну строку перед циклом
                row.CreateCells(DGV_number);

                while (reader.Read())
                {
                    var value = reader.GetInt32(0);
                    row.Cells[columnIndex].Value = value; // Добавляем значение в текущую ячейку строки
                    
                    row.Cells[columnIndex].Style.BackColor = GlobalColors.Dark;

                    columnIndex++;

                    if (columnIndex == 5)
                    {
                        DGV_number.Rows.Add(row); // Добавляем заполненную строку в таблицу
                        row = new DataGridViewRow(); // Создаем новую строку для следующих 5 чисел
                        row.CreateCells(DGV_number);
                        
                        columnIndex = 0; // Сбрасываем индекс столбца
                    }
                }

                // Добавляем оставшиеся ячейки, если их число не кратно 5
                if (columnIndex > 0)
                {
                    for (var i = columnIndex; i < 5; i++)
                    {
                        row.Cells[i].Style.BackColor = GlobalColors.Dark;
                        row.Cells[i].ReadOnly = true; 
                        
                    }
                    
                    DGV_number.Rows.Add(row);
                }

                SetTableSettings();
            }

            reader.Close();
            DataBase.closeConnection();
        }

        private void DGV_number_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cell = DGV_number.Rows[e.RowIndex].Cells[e.ColumnIndex];
            
            _isCellFree = cell.Style.BackColor != GlobalColors.LightBg;
            
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                _clickedCellValue = Convert.ToString(cell.Value);
            }
        }
        
        private void DGV_number_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var cell = DGV_number.Rows[e.RowIndex].Cells[e.ColumnIndex];
            
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.RowIndex >= DGV_number.Rows.Count) return;
            
            if (cell?.Value == null) return;
            
            if (!int.TryParse(cell.Value.ToString(), out var value)) return;
            
            DataBase.openConnection();
            var query = $"SELECT id_number FROM reserved_numbers where id_number = {value}";
            var sqlCommand = new SqlCommand(query, _dataBase.getConnection());
            var result = sqlCommand.ExecuteScalar();

            if (result != null)
            {
                cell.Style.ForeColor = GlobalColors.DarkTxt;
                cell.Style.BackColor = GlobalColors.LightBg;

                cell.ReadOnly = true;
            }
            else
            {
                cell.Style.ForeColor = GlobalColors.White;
                cell.Style.BackColor = GlobalColors.Dark;
            }

            DataBase.closeConnection();
        }
       
       
        
        private void header_MouseDown_1(object sender, MouseEventArgs e)
        {
            _headerMouseMove.SetLastPoint(e);
        }

        private void header_MouseMove(object sender, MouseEventArgs e)
        {
            _headerMouseMove.MoveForm(e, this);
        }

        private void LB_header_MouseDown(object sender, MouseEventArgs e)
        {
            _headerMouseMove.SetLastPoint(e);
        }

        private void LB_header_MouseMove(object sender, MouseEventArgs e)
        {
            _headerMouseMove.MoveForm(e, this);
        }

        private void Persona_Load(object sender, EventArgs e)
        {
            NumbersDataLoad();
        }

        private void NumbersDataLoad()
        {
            try
            {
                DataBase.openConnection();

                const string query = @"SELECT 
                a.name,
                r.id_number,
                r.last_date
            FROM 
                users a 
            JOIN 
                users_data b ON a.id = b.id_user 
            LEFT JOIN 
                reserved_numbers r ON r.id_user = a.id
            WHERE 
                b.id_user = @UserId";

                var sqlCommand = new SqlCommand(query, _dataBase.getConnection());
                sqlCommand.Parameters.AddWithValue("@UserId", _userId);
        
                using (var reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (!reader.IsDBNull(reader.GetOrdinal("id_number")))
                        {
                            LB_userNum.Text = reader["id_number"].ToString();
                            LB_userNum.ForeColor = GlobalColors.White;
                        }
                        else
                        {
                            LB_userNum.Text = "—";
                            LB_userNum.ForeColor = GlobalColors.White;
                        }

                        LB_userName.Text = reader["name"].ToString();
                        
                        if (!reader.IsDBNull(reader.GetOrdinal("last_date")))
                        {
                            var lastDate = DateTime.Parse(reader["last_date"].ToString());
                            LB_userExpire.Text = lastDate.ToString("d MMMM, HH:mm");
                            LB_userExpire.ForeColor = GlobalColors.White;
                        }
                        else
                        {
                            LB_userExpire.Text = "—";
                            LB_userExpire.ForeColor = GlobalColors.White;
                        }
                    }
                    else
                    {
                        LB_userName.Text = "Имя не найдено";
                        LB_userNum.Text = "—";
                        LB_userExpire.Text = "—";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
            }
            finally
            {
                DataBase.closeConnection();
            }
        }

        private void BTN_all_Click(object sender, EventArgs e)
        {
            
            FillDataGridViewFromDatabase("SELECT id FROM numbers");
        }

        private void BTN_occupied_Click(object sender, EventArgs e)
        {
            FillDataGridViewFromDatabase("SELECT id_number FROM reserved_numbers");
        }

        private void BTN_free_Click(object sender, EventArgs e)
        {
            FillDataGridViewFromDatabase("SELECT id FROM numbers WHERE id NOT IN (SELECT id_number FROM reserved_numbers)");
        }

        private void BTN_1_Click(object sender, EventArgs e)
        {
            _countDays = 1;
        }

        private void BTN_7_Click(object sender, EventArgs e)
        {
            _countDays = 7;
        }

        private void BTN_30_Click(object sender, EventArgs e)
        {
            _countDays = 30;
        }
        
        private void BTN_reserve_Click(object sender, EventArgs e)
        {
            switch (BTN_reserve.Text)
            {
                case "Забронировать":
                {
                    var cellValue = _clickedCellValue ?? "1";

                    var startDate = DateTime.Now;
                    var lastDate = DateTime.Today.AddDays(_countDays).AddHours(8).AddMinutes(0).AddSeconds(0);
            
                    startDate = startDate.AddMilliseconds(-startDate.Millisecond);
                    lastDate = lastDate.AddMilliseconds(-lastDate.Millisecond);
            
                    try
                    {
                        DataBase.openConnection();
                        using (var command = new SqlCommand("INSERT INTO reserved_numbers (id_number, id_user, start_date, last_date) VALUES (@id_number, @id_user, @start_date, @last_date)", _dataBase.getConnection()))
                        {
                            command.Parameters.AddWithValue("@id_number", cellValue);
                            command.Parameters.AddWithValue("@id_user", _userId);
                            command.Parameters.AddWithValue("@start_date", startDate);
                            command.Parameters.AddWithValue("@last_date", lastDate);
                            command.ExecuteNonQuery();
                        }

                        NumbersDataLoad();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при бронировании номера: {ex.Message}");
                    }
                    finally
                    {
                        BTN_reserve.Text = "Снять бронь";
                        DataBase.closeConnection();
                    }
                
                    BTN_reserve.Text = "Снять бронь";
                    break;
                }
                case "Снять бронь" when BTN_reserve.Text != "Снять бронь":
                    return;
                case "Снять бронь":
                    try
                    {
                        DataBase.openConnection();
                        using (var command = new SqlCommand("DELETE FROM reserved_numbers WHERE id_user = @id_user", _dataBase.getConnection()))
                        {
                            command.Parameters.AddWithValue("@id_user", _userId);
                            command.ExecuteNonQuery();
                        }
            
                        NumbersDataLoad();
                        BTN_reserve.Text = "Забронировать";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при удалении забронированного номера: {ex.Message}");
                    }
                    finally
                    {
                        DataBase.closeConnection();
                    }
                
                    BTN_reserve.Text = "Забронировать";
                    break;
            }
        }

        private void BTN_signUp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
