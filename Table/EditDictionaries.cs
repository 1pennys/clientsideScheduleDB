using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
namespace Table
{
    public partial class EditDictionaries : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public EditDictionaries()
        {
            InitializeComponent();
            MaximizeBox = false;
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey700, Primary.Grey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            EditSchedule f1 = new EditSchedule();
            f1.Show();
            Visible = false;
        }

        private void EditDictionaries_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void EditDictionaries_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'timetableDataSet.rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.timetableDataSet.rooms);
            // TODO: This line of code loads data into the 'timetableDataSet.groups' table. You can move, or remove it, as needed.
            this.groupsTableAdapter.Fill(this.timetableDataSet.groups);
            // TODO: This line of code loads data into the 'timetableDataSet.teachers' table. You can move, or remove it, as needed.
            this.teachersTableAdapter.Fill(this.timetableDataSet.teachers);
            // TODO: This line of code loads data into the 'timetableDataSet.subjects' table. You can move, or remove it, as needed.
            this.subjectsTableAdapter.Fill(this.timetableDataSet.subjects);



        }

        private void EditDictionaries_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainMenu f2 = new MainMenu();
            this.Closed += (s, args) => this.Close();
            f2.Show();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                string sql = "INSERT INTO subjects VALUES (NULL, @subjectName)";
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add("@subjectName", MySqlDbType.VarChar).Value = SubjName.Text.ToString();
                int a = cmd.ExecuteNonQuery();
            }
            catch { MessageBox.Show("Поле не может быть пустым!"); }
            conn.Close();

            this.subjectsTableAdapter.Fill(this.timetableDataSet.subjects);

            SubjName.Clear();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            if (AddingMode.Checked == true)
            {
                try
                {
                    string sql = "INSERT INTO teachers VALUES (NULL, @Name, @Surname, @Patronymic)";
                    MySqlCommand cmd = conn.CreateCommand();
                    string sql1 = "INSERT INTO Teachers_has_Subjects VALUES (@IDteachers, @IDsubjects)";
                    MySqlCommand cmd1 = conn.CreateCommand();
                    cmd.CommandText = sql;
                    cmd1.CommandText = sql1;
                    if (teacherName.Text == string.Empty || teacherName.Text == string.Empty || teacherName.Text == string.Empty) { throw new Exception(); }
                    cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = teacherName.Text.ToString();
                    cmd.Parameters.Add("@Surname", MySqlDbType.VarChar).Value = TeacherSurname.Text.ToString();
                    cmd.Parameters.Add("@Patronymic", MySqlDbType.VarChar).Value = TeacherPatr.Text.ToString();
                    int a = cmd.ExecuteNonQuery();
                    this.teachersTableAdapter.Fill(this.timetableDataSet.teachers);
                    cmd1.Parameters.Add("@IDteachers", MySqlDbType.Int32).Value = dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value;
                    cmd1.Parameters.Add("@IDsubjects", MySqlDbType.Int32).Value = comboBoxSubjectForTeachers.SelectedValue;
                    cmd1.ExecuteNonQuery();
                }
                catch { MessageBox.Show("Поля не могут быть пустыми!"); }
                teacherName.Clear();
                TeacherSurname.Clear();
                TeacherPatr.Clear();
            }
            else
            {
                ////изменить препода
                string sql = "UPDATE teachers SET Name = @name, Surname = @Surname, Patronymic=@Patronymic WHERE idTeachers = @id";
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = teacherName.Text.ToString();
                cmd.Parameters.Add("@Surname", MySqlDbType.VarChar).Value = TeacherSurname.Text.ToString();
                cmd.Parameters.Add("@Patronymic", MySqlDbType.VarChar).Value = TeacherPatr.Text.ToString();
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = indexTeacher;
                cmd.ExecuteNonQuery();
                this.teachersTableAdapter.Fill(this.timetableDataSet.teachers);

                try
                {
                    ////добавить предмет преподу
                    string sql1 = "INSERT INTO Teachers_has_Subjects VALUES (@IDteachers, @IDsubjects)";
                    MySqlCommand cmd1 = conn.CreateCommand();
                    cmd1.CommandText = sql1;
                    cmd1.Parameters.Add("@IDteachers", MySqlDbType.Int32).Value = indexTeacher;
                    cmd1.Parameters.Add("@IDsubjects", MySqlDbType.Int32).Value = comboBoxSubjectForTeachers.SelectedValue;
                    cmd1.ExecuteNonQuery();
                }
                catch { MessageBox.Show("Поля не могут быть пустыми!"); }
            }

            conn.Close();

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "INSERT INTO `groups` (`nameOfGroup`) VALUES (@nameOfGroup)";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@nameOfGroup", MySqlDbType.VarChar).Value = GroupName.Text.ToString();
            int a = cmd.ExecuteNonQuery();
            conn.Close();


            this.groupsTableAdapter.Fill(this.timetableDataSet.groups);
            GroupName.Clear();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "INSERT INTO `rooms` (`NameOfRoom`) VALUES (@roomName);";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@roomName", MySqlDbType.VarChar).Value = RoomName.Text.ToString();
            int a = cmd.ExecuteNonQuery();
            conn.Close();
            this.roomsTableAdapter.Fill(this.timetableDataSet.rooms);
            RoomName.Clear();
        }
        public int indexTeacher;
        public int idOfSelectedItemInCM;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                int indexOfTeacher = Convert.ToInt32(row.Cells[0].Value);
                MySqlConnection conn = DBUtils.GetDBConnection();
                conn.Open();
                string sql = "SELECT subjectName FROM Subjects WHERE idSubjects = ANY (SELECT Subjects_idSubjects FROM Teachers_has_Subjects WHERE Teachers_idTeachers=@id) ";
                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = indexOfTeacher;
                MyDA.SelectCommand = cmd;
                DataTable table = new DataTable();
                MyDA.Fill(table);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;
                dataGridView5.DataSource = bSource;
                dataGridView5.Update();
                if (AddingMode.Checked == false)
                {

                    indexTeacher = indexOfTeacher;
                    teacherName.Text = row.Cells[1].Value.ToString();
                    TeacherSurname.Text = row.Cells[2].Value.ToString();
                    TeacherPatr.Text = row.Cells[3].Value.ToString();
                    if (dataGridView5 == null || dataGridView5.Rows.Count == 0)
                    {
                        conn.Close();
                    }
                    else
                    {
                        DataGridViewRow row1 = dataGridView5.Rows[0];
                        //populate the textbox from specific value of the coordinates of column and row.
                        string sql1 = "SELECT idSubjects FROM Subjects WHERE subjectName = @Name";
                        MySqlCommand cmd1 = conn.CreateCommand();
                        cmd1.CommandText = sql1;
                        cmd1.Parameters.Add("@Name", MySqlDbType.VarChar).Value = row1.Cells[0].Value.ToString();
                        int pid = Convert.ToInt32(cmd1.ExecuteScalar());
                        comboBoxSubjectForTeachers.SelectedIndex = pid - 1;
                        idOfSelectedItemInCM = pid - 1;
                        conn.Close();
                    }
                }
            }
        }

        private void EditMode_CheckedChanged(object sender, EventArgs e)
        {
            teacherName.Clear();
            TeacherSurname.Clear();
            TeacherPatr.Clear();
        }

        private void materialLabel8_Click(object sender, EventArgs e)
        {

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "DELETE FROM `teachers` WHERE(`idTeachers` = @id)";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = indexTeacher;
            int a = cmd.ExecuteNonQuery();
            this.teachersTableAdapter.Fill(this.timetableDataSet.teachers);
            conn.Close();

        }
    }
}
