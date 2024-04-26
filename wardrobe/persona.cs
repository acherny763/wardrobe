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
    public partial class Persona : Form
    {
        private readonly DataBase _dataBase = new DataBase();
        private readonly int _userId;

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

            //pictureBox1.Paint += new PaintEventHandler(pictureBox1_Paint);
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
            
            DGV_number.RowHeadersVisible = false;
            DGV_number.ColumnHeadersVisible = false;
            DGV_number.ScrollBars = ScrollBars.Vertical;
            
            var newColumn = new DataGridViewTextBoxColumn();

            DGV_number.Columns.Add(newColumn);
            
            for (int i = 1; i <= 5; i++)
            {
                DGV_number.Columns.Add(new DataGridViewTextBoxColumn());
            }
            
            var value = 1;
            for (var row = 0; row < 120; row++)
            {
                DGV_number.Rows.Add();
                for (var col = 0; col < 5; col++)
                {
                    DGV_number.Rows[row].Cells[col].Value = value;
                    value++;
                    
                    DataBase.openConnection();
                    var adapter = new SqlDataAdapter();
                    var table = new DataTable();
                    var query =
                        $"SELECT id_number FROM reserved_numbers where id_number={value}";
            
                    var sqlCommand = new SqlCommand(query, _dataBase.getConnection());
                        
                    adapter.SelectCommand = sqlCommand;
                    adapter.Fill(table);
                    if (table.Rows.Count == 1)
                    {
                        DGV_number.Rows[row].Cells[col].Style.ForeColor = GlobalColors.Blue; 
                    }
                    
                    
                    DataBase.closeConnection();
                }
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
        private void DGV_number_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null) return;
            
            DGV_number.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = GlobalColors.Dark;
            DGV_number.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = GlobalColors.White;
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
            DataBase.openConnection();
            
            var query =
                $"SELECT a.name FROM users a JOIN users_data b ON a.id = b.id_user WHERE b.id_user = @UserId";

            var sqlCommand = new SqlCommand(query, _dataBase.getConnection());
            sqlCommand.Parameters.AddWithValue("@UserId", _userId);
            var result = sqlCommand.ExecuteScalar();
            
            LB_userName.Text = result != null ? result.ToString() : "Имя не найдено";
            
            DataBase.closeConnection();
        }
    }
}
