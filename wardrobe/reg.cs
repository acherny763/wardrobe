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
    public partial class Reg : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        private readonly HeaderMouseMove _headerMouseMove = new HeaderMouseMove();
        public Reg()
        {
            InitializeComponent();
            
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            
            TextBoxManipulation.AttachEnterEventToTextBoxes(this);
            TextBoxManipulation.ChangeColorPanel(this);
            
            StartPosition = FormStartPosition.CenterScreen;
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

        private void BTN_signUp_Click(object sender, EventArgs e)
        {
            var mainForm = new Form1();
            this.Hide();
            mainForm.Show();
        }

        private void BTN_registration_Click(object sender, EventArgs e)
        {
            if (CheckUser()) return;

            //DataBase.openConnection();
            
            var login = TB_log.Text;
            
            var firstName = TB_firstName.Text;
            var lastName = TB_lastName.Text;
            var patronymic = TB_patronymic.Text;
            
            var password = TB_password.Text;
            var rePassword = TB_rePassword.Text;
            
            var group = TB_group.Text;
            var course = TB_course.Text;
            var numberGroup = TB_numberGroup.Text;

            if (password != rePassword)
            {
                MessageBox.Show("Пароли не совпадают", "Неуспешно");
                return;
            }
            
            using (var connection = new SqlConnection(@"Data Source = DESKTOP-KSHLJ2B; Initial Catalog = wardrobe; Integrated Security = True"))
            {
                connection.Open();

                // Вставка данных в таблицу users
                const string queryInsertUser = @"
                INSERT INTO users (surname, name, middle_name) 
                VALUES (@LastName, @FirstName, @Patronymic);
                SELECT SCOPE_IDENTITY();"; // Получаем сгенерированный идентификатор

                using (var commandInsertUser = new SqlCommand(queryInsertUser, connection))
                {
                    commandInsertUser.Parameters.AddWithValue("@LastName", lastName);
                    commandInsertUser.Parameters.AddWithValue("@FirstName", firstName);
                    commandInsertUser.Parameters.AddWithValue("@Patronymic", patronymic);

                    // Получаем сгенерированный идентификатор пользователя
                    var userId = Convert.ToInt32(commandInsertUser.ExecuteScalar());

                    // Вставка данных в таблицу users_data
                    const string queryInsertUserData = @"
                    INSERT INTO users_data (id_user, login, password) 
                    VALUES (@UserId, @Login, @Password);";

                    using (var commandInsertUserData = new SqlCommand(queryInsertUserData, connection))
                    {
                        commandInsertUserData.Parameters.AddWithValue("@UserId", userId);
                        commandInsertUserData.Parameters.AddWithValue("@Login", login);
                        commandInsertUserData.Parameters.AddWithValue("@Password", password);

                        var rowsAffected = commandInsertUserData.ExecuteNonQuery();

                        if (rowsAffected == 1)
                        {
                            MessageBox.Show("Аккаунт создан успешно", "Успех");
                        
                        // Вставка данных в таблицу users_positions
                        const string queryInsertUserPosition = @"
                        INSERT INTO users_positions (id_user, id_position) 
                        VALUES (@UserId, @PositionId);";

                        using (var commandInsertUserPosition = new SqlCommand(queryInsertUserPosition, connection))
                        {
                            commandInsertUserPosition.Parameters.AddWithValue("@UserId", userId);
                            commandInsertUserPosition.Parameters.AddWithValue("@PositionId", 1); // Указываем id_position

                            rowsAffected = commandInsertUserPosition.ExecuteNonQuery();

                            if (rowsAffected == 1)
                            {
                                MessageBox.Show("Должность пользователя успешно добавлена", "Успех");
                                
                                // Получаем айдишник группы из таблицы groups
                                const string querySelectGroupId = @"
                                SELECT id
                                FROM groups
                                WHERE name = @GroupName AND course = @Course AND number = @NumberGroup;";

                                using (var commandSelectGroupId = new SqlCommand(querySelectGroupId, connection))
                                {
                                    commandSelectGroupId.Parameters.AddWithValue("@GroupName", group);
                                    commandSelectGroupId.Parameters.AddWithValue("@Course", course);
                                    commandSelectGroupId.Parameters.AddWithValue("@NumberGroup", numberGroup);

                                    var groupId = Convert.ToInt32(commandSelectGroupId.ExecuteScalar());

                                    // Вставка данных в таблицу students
                                    const string queryInsertStudent = @"
                                    INSERT INTO students (id_user, id_group, enrollment_date, expulsion_date) 
                                    VALUES (@UserId, @GroupId, '2021-09-01', '2024-08-31');";

                                    using (var commandInsertStudent = new SqlCommand(queryInsertStudent, connection))
                                    {
                                        commandInsertStudent.Parameters.AddWithValue("@UserId", userId);
                                        commandInsertStudent.Parameters.AddWithValue("@GroupId", groupId);

                                        rowsAffected = commandInsertStudent.ExecuteNonQuery();

                                        if (rowsAffected == 1)
                                        {
                                            MessageBox.Show("Студент успешно добавлен в группу", "Успех");
                                            var mainForm = new Form1();
                                            this.Hide();
                                            mainForm.Show();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Ошибка при добавлении студента в группу", "Ошибка");
                                        }
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ошибка при добавлении должности пользователя", "Ошибка");
                            }
                        }
                        }
                        else
                        {
                            MessageBox.Show("Ошибка при создании аккаунта", "Ошибка");
                        }
                    }
                }
            }
        }

        private bool CheckUser()
        {
            var login = TB_log.Text;
            var password = TB_password.Text;

            var adapter = new SqlDataAdapter();
            var table = new DataTable();
            var query = $"SELECT * FROM users_data where login = '{login}' and password = '{password}'";
            
            var sqlCommand = new SqlCommand(query, _dataBase.getConnection());

            adapter.SelectCommand = sqlCommand;
            adapter.Fill(table);

            if (table.Rows.Count <= 0) return false;
            MessageBox.Show("Акк не создан", "неуспех");
            return true;
        }
    }
}