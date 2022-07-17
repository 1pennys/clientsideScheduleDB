using Table.Properties;
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Collections;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;
using System.Threading;
using System.Diagnostics;

using MaterialSkin;
using MySql.Data.MySqlClient;

namespace Table
{

    public partial class EditSchedule : Form
    {

        public EditSchedule()
        {

            InitializeComponent();
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.panel1.MouseMove += new MouseEventHandler(panel1_MouseMove);
            this.SetStyle(ControlStyles.ResizeRedraw, true);

        }

        private const int cGrip = 16;
        private const int cCaption = 32;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
;
            }
            base.WndProc(ref m);
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                iconButton2.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        Regex regex = new Regex("^a[1-2]+a[1-6]+a[1-4]+$");
        private void SetupClickEvents(Control container)
        {
            foreach (Control control in container.Controls)
            {
                control.Click += Control_Clicks;
            }
        }
        public int weekClicked, dayClicked, lessonClicked;
        public bool clickedLessonEmpty = true;
        public string textBoxClicked;
        private void Control_Clicks(object sender, EventArgs e)
        {
            Control control = (Control)sender;   // Sender gives you which control is clicked.
            textBoxClicked = control.Name.ToString();

            if (regex.IsMatch(textBoxClicked))
            {
                TextBox myTextBox = (TextBox)this.GetControlByName(this, textBoxClicked);
                if (myTextBox.Text == string.Empty) { clickedLessonEmpty = true; } else { clickedLessonEmpty = false; }
                TextBoxWasClicked();
            }

        }
        private void TextBoxWasClicked()
        {
            string textBoxClickedForTrim = textBoxClicked.Replace("a", ",");
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            comboBox2.Visible = true;
            comboBox3.Visible = true;
            comboBox4.Visible = true;
            teacherName.Visible = true;
            teacherPatr.Visible = true;
            iconButton4.Visible = true;
            textBoxClickedForTrim = textBoxClickedForTrim.Remove(0, 1);
            string[] tokens = textBoxClickedForTrim.Split(',');
            int[] convertedItems = Array.ConvertAll<string, int>(tokens, int.Parse);
            weekClicked = convertedItems[0];
            dayClicked = convertedItems[1];
            lessonClicked = convertedItems[2];
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditDictionaries f2 = new EditDictionaries();
            this.Closed += (s, args) => this.Close();
            f2.Show();
        }
        public void RelocationNormal()
        {
            iconButton5.Location = new Point(1800, 170);
            AddingMode.Location = new Point(1700, 250);
            iconButton4.Location = new Point(1710, 170);
            comboBox2.Location = new Point(100, 185);
            comboBox2.Size = new Size(300, 21);
            comboBox3.Location = new Point(480, 185);
            comboBox3.Size = new Size(250, 21);
            comboBox4.Location = new Point(1340, 185);
            comboBox4.Size = new Size(300, 21);
            teacherName.Location = new Point(745, 185);
            teacherName.Size = new Size(250, 20);
            teacherPatr.Location = new Point(1010, 185);
            teacherPatr.Size = new Size(250, 20);
            label6.Location = new Point(212, 160);
            label7.Location = new Point(807, 160);
            label8.Location = new Point(1445, 160);
            label2.Location = new Point(320, 73);
            label2.Size = new Size(1, 640);
            label1.Location = new Point(640, 73);
            label1.Size = new Size(1, 640);
            label3.Location = new Point(960, 73);
            label3.Size = new Size(1, 640);
            label4.Location = new Point(1280, 73);
            label4.Size = new Size(1, 640);
            label5.Location = new Point(1600, 73);
            label5.Size = new Size(1, 640);
            materialLabel1.Location = new Point(0, 393);
            materialLabel2.Location = new Point(0, 713);
            panel4.Location = new Point(0, 714);
            panel4.Size = new Size(1920, 366);
            label14.Location = new Point(106, 51);
            label9.Location = new Point(445, 51);
            label10.Location = new Point(771, 51);
            label11.Location = new Point(1085, 51);
            label12.Location = new Point(1403, 51);
            label13.Location = new Point(1724, 51);
            //first week, monday
            a1a1a1.Location = new Point(20, 89);
            a1a1a1.Size = new Size(280, 60);
            a1a1a2.Location = new Point(20, 165);
            a1a1a2.Size = new Size(280, 60);
            a1a1a3.Location = new Point(20, 241);
            a1a1a3.Size = new Size(280, 60);
            a1a1a4.Location = new Point(20, 317);
            a1a1a4.Size = new Size(280, 60);
            //first week, tuesday
            a1a2a1.Location = new Point(340, 89);
            a1a2a1.Size = new Size(280, 60);
            a1a2a2.Location = new Point(340, 165);
            a1a2a2.Size = new Size(280, 60);
            a1a2a3.Location = new Point(340, 241);
            a1a2a3.Size = new Size(280, 60);
            a1a2a4.Location = new Point(340, 317);
            a1a2a4.Size = new Size(280, 60);
            //first week, wednesday
            a1a3a1.Location = new Point(660, 89);
            a1a3a1.Size = new Size(280, 60);
            a1a3a2.Location = new Point(660, 165);
            a1a3a2.Size = new Size(280, 60);
            a1a3a3.Location = new Point(660, 241);
            a1a3a3.Size = new Size(280, 60);
            a1a3a4.Location = new Point(660, 317);
            a1a3a4.Size = new Size(280, 60);
            //first week, thursday
            a1a4a1.Location = new Point(980, 89);
            a1a4a1.Size = new Size(280, 60);
            a1a4a2.Location = new Point(980, 165);
            a1a4a2.Size = new Size(280, 60);
            a1a4a3.Location = new Point(980, 241);
            a1a4a3.Size = new Size(280, 60);
            a1a4a4.Location = new Point(980, 317);
            a1a4a4.Size = new Size(280, 60);
            //first week, friday
            a1a5a1.Location = new Point(1300, 89);
            a1a5a1.Size = new Size(280, 60);
            a1a5a2.Location = new Point(1300, 165);
            a1a5a2.Size = new Size(280, 60);
            a1a5a3.Location = new Point(1300, 241);
            a1a5a3.Size = new Size(280, 60);
            a1a5a4.Location = new Point(1300, 317);
            a1a5a4.Size = new Size(280, 60);
            //first week, saturday
            a1a6a1.Location = new Point(1620, 89);
            a1a6a1.Size = new Size(280, 60);
            a1a6a2.Location = new Point(1620, 165);
            a1a6a2.Size = new Size(280, 60);
            a1a6a3.Location = new Point(1620, 241);
            a1a6a3.Size = new Size(280, 60);
            a1a6a4.Location = new Point(1620, 317);
            a1a6a4.Size = new Size(280, 60);
            //second week, monday
            a2a1a1.Location = new Point(20, 409);
            a2a1a1.Size = new Size(280, 60);
            a2a1a2.Location = new Point(20, 485);
            a2a1a2.Size = new Size(280, 60);
            a2a1a3.Location = new Point(20, 561);
            a2a1a3.Size = new Size(280, 60);
            a2a1a4.Location = new Point(20, 637);
            a2a1a4.Size = new Size(280, 60);
            //second week, tuesday
            a2a2a1.Location = new Point(340, 409);
            a2a2a1.Size = new Size(280, 60);
            a2a2a2.Location = new Point(340, 485);
            a2a2a2.Size = new Size(280, 60);
            a2a2a3.Location = new Point(340, 561);
            a2a2a3.Size = new Size(280, 60);
            a2a2a4.Location = new Point(340, 637);
            a2a2a4.Size = new Size(280, 60);
            //second week, wednesday
            a2a3a1.Location = new Point(660, 409);
            a2a3a1.Size = new Size(280, 60);
            a2a3a2.Location = new Point(660, 485);
            a2a3a2.Size = new Size(280, 60);
            a2a3a3.Location = new Point(660, 561);
            a2a3a3.Size = new Size(280, 60);
            a2a3a4.Location = new Point(660, 637);
            a2a3a4.Size = new Size(280, 60);
            //second week, thursday
            a2a4a1.Location = new Point(980, 409);
            a2a4a1.Size = new Size(280, 60);
            a2a4a2.Location = new Point(980, 485);
            a2a4a2.Size = new Size(280, 60);
            a2a4a3.Location = new Point(980, 561);
            a2a4a3.Size = new Size(280, 60);
            a2a4a4.Location = new Point(980, 637);
            a2a4a4.Size = new Size(280, 60);
            //second week, friday
            a2a5a1.Location = new Point(1300, 409);
            a2a5a1.Size = new Size(280, 60);
            a2a5a2.Location = new Point(1300, 485);
            a2a5a2.Size = new Size(280, 60);
            a2a5a3.Location = new Point(1300, 561);
            a2a5a3.Size = new Size(280, 60);
            a2a5a4.Location = new Point(1300, 637);
            a2a5a4.Size = new Size(280, 60);
            //second week, saturday
            a2a6a1.Location = new Point(1620, 409);
            a2a6a1.Size = new Size(280, 60);
            a2a6a2.Location = new Point(1620, 485);
            a2a6a2.Size = new Size(280, 60);
            a2a6a3.Location = new Point(1620, 561);
            a2a6a3.Size = new Size(280, 60);
            a2a6a4.Location = new Point(1620, 637);
            a2a6a4.Size = new Size(280, 60);
        }
        public void RelocationMax()
        {
            iconButton5.Location = new Point(687, 19);
            AddingMode.Location = new Point(585, 135);
            iconButton4.Location = new Point(687, 75);
            comboBox2.Location = new Point(50, 89);
            comboBox2.Size = new Size(121, 21);
            comboBox3.Location = new Point(200, 89);
            comboBox3.Size = new Size(100, 21);
            comboBox4.Location = new Point(540, 89);
            comboBox4.Size = new Size(121, 21);
            teacherName.Location = new Point(305, 89);
            teacherName.Size = new Size(100, 20);
            teacherPatr.Location = new Point(410, 89);
            teacherPatr.Size = new Size(100, 20);
            label6.Location = new Point(73, 64);
            label7.Location = new Point(292, 64);
            label8.Location = new Point(556, 64);
            label2.Location = new Point(127, 73);
            label2.Size = new Size(1, 256);
            label1.Location = new Point(254, 73);
            label1.Size = new Size(1, 256);
            label3.Location = new Point(381, 73);
            label3.Size = new Size(1, 256);
            label4.Location = new Point(508, 73);
            label4.Size = new Size(1, 256);
            label5.Location = new Point(635, 73);
            label5.Size = new Size(1, 256);
            materialLabel1.Location = new Point(0, 200);
            materialLabel2.Location = new Point(0, 328);
            panel4.Location = new Point(0, 329);
            panel4.Size = new Size(765, 174);
            label14.Location = new Point(9, 51);
            label9.Location = new Point(155, 51);
            label10.Location = new Point(289, 51);
            label11.Location = new Point(410, 51);
            label12.Location = new Point(535, 51);
            label13.Location = new Point(662, 51);
            //first week, monday
            a1a1a1.Location = new Point(14, 83);
            a1a1a1.Size = new Size(100, 20);
            a1a1a2.Location = new Point(14, 112);
            a1a1a2.Size = new Size(100, 20);
            a1a1a3.Location = new Point(14, 141);
            a1a1a3.Size = new Size(100, 20);
            a1a1a4.Location = new Point(14, 170);
            a1a1a4.Size = new Size(100, 20);
            //first week, tuesday
            a1a2a1.Location = new Point(141, 83);
            a1a2a1.Size = new Size(100, 20);
            a1a2a2.Location = new Point(141, 112);
            a1a2a2.Size = new Size(100, 20);
            a1a2a3.Location = new Point(141, 141);
            a1a2a3.Size = new Size(100, 20);
            a1a2a4.Location = new Point(141, 170);
            a1a2a4.Size = new Size(100, 20);
            //first week, wednesday
            a1a3a1.Location = new Point(268, 83);
            a1a3a1.Size = new Size(100, 20);
            a1a3a2.Location = new Point(268, 112);
            a1a3a2.Size = new Size(100, 20);
            a1a3a3.Location = new Point(268, 141);
            a1a3a3.Size = new Size(100, 20);
            a1a3a4.Location = new Point(268, 170);
            a1a3a4.Size = new Size(100, 20);
            //first week, thursday
            a1a4a1.Location = new Point(395, 83);
            a1a4a1.Size = new Size(100, 20);
            a1a4a2.Location = new Point(395, 112);
            a1a4a2.Size = new Size(100, 20);
            a1a4a3.Location = new Point(395, 141);
            a1a4a3.Size = new Size(100, 20);
            a1a4a4.Location = new Point(395, 170);
            a1a4a4.Size = new Size(100, 20);
            //first week, friday
            a1a5a1.Location = new Point(522, 83);
            a1a5a1.Size = new Size(100, 20);
            a1a5a2.Location = new Point(522, 112);
            a1a5a2.Size = new Size(100, 20);
            a1a5a3.Location = new Point(522, 141);
            a1a5a3.Size = new Size(100, 20);
            a1a5a4.Location = new Point(522, 170);
            a1a5a4.Size = new Size(100, 20);
            //first week, saturday
            a1a6a1.Location = new Point(649, 83);
            a1a6a1.Size = new Size(100, 20);
            a1a6a2.Location = new Point(649, 112);
            a1a6a2.Size = new Size(100, 20);
            a1a6a3.Location = new Point(649, 141);
            a1a6a3.Size = new Size(100, 20);
            a1a6a4.Location = new Point(649, 170);
            a1a6a4.Size = new Size(100, 20);
            //second week, monday
            a2a1a1.Location = new Point(14, 211);
            a2a1a1.Size = new Size(100, 20);
            a2a1a2.Location = new Point(14, 240);
            a2a1a2.Size = new Size(100, 20);
            a2a1a3.Location = new Point(14, 269);
            a2a1a3.Size = new Size(100, 20);
            a2a1a4.Location = new Point(14, 298);
            a2a1a4.Size = new Size(100, 20);
            //second week, tuesday
            a2a2a1.Location = new Point(141, 211);
            a2a2a1.Size = new Size(100, 20);
            a2a2a2.Location = new Point(141, 240);
            a2a2a2.Size = new Size(100, 20);
            a2a2a3.Location = new Point(141, 269);
            a2a2a3.Size = new Size(100, 20);
            a2a2a4.Location = new Point(141, 298);
            a2a2a4.Size = new Size(100, 20);
            //second week, wednesday
            a2a3a1.Location = new Point(268, 211);
            a2a3a1.Size = new Size(100, 20);
            a2a3a2.Location = new Point(268, 240);
            a2a3a2.Size = new Size(100, 20);
            a2a3a3.Location = new Point(268, 269);
            a2a3a3.Size = new Size(100, 20);
            a2a3a4.Location = new Point(268, 298);
            a2a3a4.Size = new Size(100, 20);
            //second week, thursday
            a2a4a1.Location = new Point(395, 211);
            a2a4a1.Size = new Size(100, 20);
            a2a4a2.Location = new Point(395, 240);
            a2a4a2.Size = new Size(100, 20);
            a2a4a3.Location = new Point(395, 269);
            a2a4a3.Size = new Size(100, 20);
            a2a4a4.Location = new Point(395, 298);
            a2a4a4.Size = new Size(100, 20);
            //second week, friday
            a2a5a1.Location = new Point(522, 211);
            a2a5a1.Size = new Size(100, 20);
            a2a5a2.Location = new Point(522, 240);
            a2a5a2.Size = new Size(100, 20);
            a2a5a3.Location = new Point(522, 269);
            a2a5a3.Size = new Size(100, 20);
            a2a5a4.Location = new Point(522, 298);
            a2a5a4.Size = new Size(100, 20);
            //second week, saturday
            a2a6a1.Location = new Point(649, 211);
            a2a6a1.Size = new Size(100, 20);
            a2a6a2.Location = new Point(649, 240);
            a2a6a2.Size = new Size(100, 20);
            a2a6a3.Location = new Point(649, 269);
            a2a6a3.Size = new Size(100, 20);
            a2a6a4.Location = new Point(649, 298);
            a2a6a4.Size = new Size(100, 20);
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Normal)
            {
                iconButton2.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
                WindowState = FormWindowState.Maximized;
                RelocationNormal();

            }
            else if (WindowState == FormWindowState.Maximized)
            {
                iconButton2.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
                WindowState = FormWindowState.Normal;
                RelocationMax();
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void EditSchedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Вы действительно хотите выйти?",
                               "EditDictionaries",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information) == DialogResult.OK)
                    Environment.Exit(0);
                else
                    e.Cancel = true; // to don't close form is user change his mind
            }
        }

        private void EditSchedule_Load(object sender, EventArgs e)
        {
            SetupClickEvents(this);
            // TODO: This line of code loads data into the 'timetableDataSet.rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.timetableDataSet.rooms);
            // TODO: This line of code loads data into the 'timetableDataSet.teachers' table. You can move, or remove it, as needed.
            this.teachersTableAdapter.Fill(this.timetableDataSet.teachers);
            // TODO: This line of code loads data into the 'timetableDataSet.subjects' table. You can move, or remove it, as needed.
            this.subjectsTableAdapter.Fill(this.timetableDataSet.subjects);
            // TODO: This line of code loads data into the 'timetableDataSet.groups' table. You can move, or remove it, as needed.
            this.groupsTableAdapter.Fill(this.timetableDataSet.groups);
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            teacherName.Visible = false;
            teacherPatr.Visible = false;
            iconButton4.Visible = false;
            fillScheduleFromDB();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "SELECT Name, Patronymic FROM teachers WHERE idTeachers=@Surname";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@Surname", MySqlDbType.Int32).Value = Convert.ToInt32(comboBox3.SelectedValue);
            MySqlDataReader reader = cmd.ExecuteReader();
            string textForName = "", textForPatr = "";
            while (reader.Read())
            {
                // элементы массива [] - это значения столбцов из запроса SELECT
                textForName = reader[0].ToString();
                textForPatr = reader[1].ToString();
            }
            reader.Close();
            conn.Close();
            teacherName.Text = textForName;
            teacherPatr.Text = textForPatr;
        }


        public Control GetControlByName(Control ParentCntl, string NameToSearch)
        {
            if (ParentCntl.Name == NameToSearch)
                return ParentCntl;

            foreach (Control ChildCntl in ParentCntl.Controls)
            {
                Control ResultCntl = GetControlByName(ChildCntl, NameToSearch);
                if (ResultCntl != null)
                    return ResultCntl;
            }
            return null;
        }

        public void insertLesson(MySqlConnection conn)
        {
            string sql = "INSERT INTO lesson VALUES (@idWeek, @idDay, @classesNumber, @idGroups, @idSubjects, @idTeachers, @idRooms)";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@idWeek", MySqlDbType.Int32).Value = weekClicked;
            cmd.Parameters.Add("@idDay", MySqlDbType.Int32).Value = dayClicked;
            cmd.Parameters.Add("@classesNumber", MySqlDbType.Int32).Value = lessonClicked;
            cmd.Parameters.Add("@idGroups", MySqlDbType.Int32).Value = Convert.ToInt32(comboBox1.SelectedValue);
            cmd.Parameters.Add("@idSubjects", MySqlDbType.Int32).Value = Convert.ToInt32(comboBox2.SelectedValue);
            cmd.Parameters.Add("@idTeachers", MySqlDbType.Int32).Value = Convert.ToInt32(comboBox3.SelectedValue);
            cmd.Parameters.Add("@idRooms", MySqlDbType.Int32).Value = Convert.ToInt32(comboBox4.SelectedValue);
            int a = cmd.ExecuteNonQuery();
        }
        public void showAddedLesson(MySqlConnection conn)
        {
            string sql = "SELECT idSubjects, idTeachers, idRooms FROM lesson WHERE idGroups=@idGroups AND idWeek=@idWeek AND idDay=@idDay AND classesNumber=@classNumber";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@idGroups", MySqlDbType.Int32).Value = Convert.ToInt32(comboBox1.SelectedValue);
            cmd.Parameters.Add("@idWeek", MySqlDbType.Int32).Value = weekClicked;
            cmd.Parameters.Add("@idDay", MySqlDbType.Int32).Value = dayClicked;
            cmd.Parameters.Add("@classNumber", MySqlDbType.Int32).Value = lessonClicked;
            MySqlDataReader reader = cmd.ExecuteReader();
            int addedSubj = -1, addedTeacher = -1, addedRoom = -1;
            while (reader.Read())
            {
                // элементы массива [] - это значения столбцов из запроса SELECT
                addedSubj = Convert.ToInt32(reader[0]);
                addedTeacher = Convert.ToInt32(reader[1]);
                addedRoom = Convert.ToInt32(reader[2]);
            }
            reader.Close();
            //////////////////////////////////////////////////////////////////////
            string sql2 = "SELECT subjectName FROM subjects WHERE idSubjects=@addedSubj UNION SELECT Surname FROM teachers WHERE idTeachers=@addedTeacher UNION" +
                " SELECT Name FROM teachers WHERE idTeachers=@addedTeacher UNION SELECT Patronymic FROM teachers WHERE idTeachers=@addedTeacher UNION" +
                " SELECT NameOfRoom FROM rooms WHERE idRooms=@addedRoom";
            MySqlCommand cmd2 = conn.CreateCommand();
            cmd2.CommandText = sql2;
            cmd2.Parameters.Add("@addedSubj", MySqlDbType.Int32).Value = addedSubj;
            cmd2.Parameters.Add("@addedTeacher", MySqlDbType.Int32).Value = addedTeacher;
            cmd2.Parameters.Add("@addedRoom", MySqlDbType.Int32).Value = addedRoom;
            MySqlDataReader reader2 = cmd2.ExecuteReader();
            string finalLessonView = "";
            while (reader2.HasRows)
            {
                int i = 0;
                while (reader2.Read())
                {
                    finalLessonView += reader2.GetString(0);
                    if (i == 0) { finalLessonView += "\r\nПрепод. "; }
                    if (i == 1) { finalLessonView += " "; }
                    if (i == 2) { finalLessonView += " "; }
                    if (i == 3) { finalLessonView += "\r\nАудитория: "; }
                    i++;
                }
                reader2.NextResult();
            }
            reader2.Close();
            doSomething(finalLessonView);
        }
        private void iconButton4_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            if (AddingMode.Checked == true && clickedLessonEmpty == true)
            {
                try
                {
                    insertLesson(conn);
                }
                catch { MessageBox.Show("Ощибка в добавлении. Выберите пару."); }
                try
                {
                  //  showAddedLesson(conn);
                }
                catch { MessageBox.Show("Ощибка в отображении"); }
            }
            else if (AddingMode.Checked == true && clickedLessonEmpty == false)
            {
                MessageBox.Show("В это время уже стоит пара, попробуйте выйти из режима добавления");
            }
            else if (AddingMode.Checked == false && clickedLessonEmpty == true)
            {
                MessageBox.Show("Вы не можете отредактировать пустую пару, попробуйте перейти в режим добавления");
            }
            else
            {
                try
                {
                    updateLesson(conn);
                }
                catch { MessageBox.Show("Ощибка в изменении. Попробуйте выбрать преподавателя"); }
            }
            dayClicked = -1;
            weekClicked = -1;
            lessonClicked = -1;
            fillScheduleFromDB();
            conn.Close();
        }

        public List<int> weeks = new List<int>();
        public List<int> days = new List<int>();
        public List<int> lessons = new List<int>();
        public List<int> subjects = new List<int>();
        public List<int> teachers = new List<int>();
        public List<int> rooms = new List<int>();

        public void updateLesson(MySqlConnection conn)
        {
            ////изменить урок
            string sql = "UPDATE lesson SET idSubjects = @Subjects, idTeachers = @Teachers, idRooms=@Rooms WHERE idGroups=@idGroups AND idWeek=@idWeek AND idDay=@idDay AND classesNumber=@classNumber";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@Subjects", MySqlDbType.Int32).Value = Convert.ToInt32(comboBox2.SelectedValue);
            cmd.Parameters.Add("@Teachers", MySqlDbType.Int32).Value = Convert.ToInt32(comboBox3.SelectedValue);
            cmd.Parameters.Add("@Rooms", MySqlDbType.Int32).Value = Convert.ToInt32(comboBox4.SelectedValue);
            cmd.Parameters.Add("@idGroups", MySqlDbType.Int32).Value = Convert.ToInt32(comboBox1.SelectedValue);
            cmd.Parameters.Add("@idWeek", MySqlDbType.Int32).Value = weekClicked;
            cmd.Parameters.Add("@idDay", MySqlDbType.Int32).Value = dayClicked;
            cmd.Parameters.Add("@classNumber", MySqlDbType.Int32).Value = lessonClicked;
            cmd.ExecuteNonQuery();
            string sql2 = "SELECT subjectName FROM subjects WHERE idSubjects=@addedSubj UNION SELECT Surname FROM teachers WHERE idTeachers=@addedTeacher UNION" +
        " SELECT Name FROM teachers WHERE idTeachers=@addedTeacher UNION SELECT Patronymic FROM teachers WHERE idTeachers=@addedTeacher UNION" +
        " SELECT NameOfRoom FROM rooms WHERE idRooms=@addedRoom";
            MySqlCommand cmd2 = conn.CreateCommand();
            cmd2.CommandText = sql2;
            cmd2.Parameters.Add("@addedSubj", MySqlDbType.Int32).Value = Convert.ToInt32(comboBox2.SelectedValue);
            cmd2.Parameters.Add("@addedTeacher", MySqlDbType.Int32).Value = Convert.ToInt32(comboBox3.SelectedValue);
            cmd2.Parameters.Add("@addedRoom", MySqlDbType.Int32).Value = Convert.ToInt32(comboBox4.SelectedValue);
            MySqlDataReader reader2 = cmd2.ExecuteReader();
            string finalLessonView = "";
            while (reader2.HasRows)
            {
                int i = 0;
                while (reader2.Read())
                {
                    finalLessonView += reader2.GetString(0);
                    if (i == 0) { finalLessonView += "\r\nПрепод. "; }
                    if (i == 1) { finalLessonView += " "; }
                    if (i == 2) { finalLessonView += " "; }
                    if (i == 3) { finalLessonView += "\r\nАудитория: "; }
                    i++;
                }
                reader2.NextResult();
            }
            reader2.Close();
            doSomething(finalLessonView);

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            for (int i = 1; i < 3; i++)
            {
                for (int j = 1; j < 7; j++)
                {
                    for (int z = 1; z < 5; z++)
                    {
                        string neededTextBox = "a" + i.ToString() + "a" + j.ToString() + "a" + z.ToString();
                        TextBox myTextBox = (TextBox)this.GetControlByName(this, neededTextBox);
                        myTextBox.Text = string.Empty;
                    }
                }
            }
            fillScheduleFromDB();
        }
        public void fillScheduleFromDB()
        {
            weeks.Clear();
            days.Clear();
            lessons.Clear();
            subjects.Clear();
            teachers.Clear();
            rooms.Clear();
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "SELECT idWeek, idDay, classesNumber, idSubjects, idTeachers, idRooms FROM lesson WHERE idGroups=@groups";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@groups", MySqlDbType.Int32).Value = Convert.ToInt32(comboBox1.SelectedValue);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                // элементы массива [] - это значения столбцов из запроса SELECT
                weeks.Add(Convert.ToInt32(reader[0]));
                days.Add(Convert.ToInt32(reader[1]));
                lessons.Add(Convert.ToInt32(reader[2]));
                subjects.Add(Convert.ToInt32(reader[3]));
                teachers.Add(Convert.ToInt32(reader[4]));
                rooms.Add(Convert.ToInt32(reader[5]));
            }
            reader.Close();
            //////////////////////////////////////////////////////////////////////
            string sql2 = "SELECT subjectName FROM subjects WHERE idSubjects=@Subj UNION SELECT Surname FROM teachers WHERE idTeachers=@Teacher UNION" +
                " SELECT Name FROM teachers WHERE idTeachers=@Teacher UNION SELECT Patronymic FROM teachers WHERE idTeachers=@Teacher UNION" +
                " SELECT NameOfRoom FROM rooms WHERE idRooms=@Room";
            MySqlCommand cmd2 = conn.CreateCommand();
            cmd2.CommandText = sql2;
            for (int i = 0; i < weeks.Count; i++)
            {
                cmd2.Parameters.Add("@Subj", MySqlDbType.Int32).Value = subjects[i];
                cmd2.Parameters.Add("@Teacher", MySqlDbType.Int32).Value = teachers[i];
                cmd2.Parameters.Add("@Room", MySqlDbType.Int32).Value = rooms[i];
                MySqlDataReader reader2 = cmd2.ExecuteReader();
                string finalLessonView = "";
                while (reader2.HasRows)
                {
                    int z = 0;
                    while (reader2.Read())
                    {
                        finalLessonView += reader2.GetString(0);
                        if (z == 0) { finalLessonView += "\r\nПрепод. "; }
                        if (z == 1) { finalLessonView += " "; }
                        if (z == 2) { finalLessonView += " "; }
                        if (z == 3) { finalLessonView += "\r\nАудитория: "; }
                        z++;
                    }
                    reader2.NextResult();
                }
                reader2.Close();
                cmd2.Parameters.Clear();
                string neededTextBox = "a" + weeks[i].ToString() + "a" + days[i].ToString() + "a" + lessons[i].ToString();
                TextBox myTextBox = (TextBox)this.GetControlByName(this, neededTextBox);
                myTextBox.Text = finalLessonView;//заполнить данными
            }
            conn.Close();

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            try
            {
                string neededTextBox = "a" + weekClicked.ToString() + "a" + dayClicked.ToString() + "a" + lessonClicked.ToString();
                TextBox myTextBox = (TextBox)this.GetControlByName(this, neededTextBox);
                if (myTextBox == null) { MessageBox.Show("Выберите урок, который нужно удалить"); } else { myTextBox.Text = string.Empty; }

            }
            catch (NullReferenceException) { MessageBox.Show("Выберите урок, который нужно удалить"); }
            try
            {
                MySqlConnection conn = DBUtils.GetDBConnection();
                conn.Open();
                string sql = "DELETE FROM `lesson` WHERE idGroups = @id AND idWeek=@week AND idDay=@day AND classesNumber=@lesson";
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = Convert.ToInt32(comboBox1.SelectedValue);
                cmd.Parameters.Add("@week", MySqlDbType.Int32).Value = weekClicked;
                cmd.Parameters.Add("@day", MySqlDbType.Int32).Value = dayClicked;
                cmd.Parameters.Add("@lesson", MySqlDbType.Int32).Value = lessonClicked;
                int a = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch { MessageBox.Show("Ошибка удаления из БД"); }
        }

        public void doSomething(string arg)
        {
            TextBox myTextBox = (TextBox)this.GetControlByName(this, textBoxClicked);
            myTextBox.Text = arg;//заполнить данными
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string query = "SELECT idTeachers, Surname FROM teachers WHERE idTeachers = ANY (SELECT Teachers_idTeachers FROM Teachers_has_Subjects WHERE Subjects_idSubjects =@id)";
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = Convert.ToInt32(comboBox2.SelectedValue);
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "teachers");
            comboBox3.DisplayMember = "Surname";
            comboBox3.ValueMember = "idTeachers";
            comboBox3.DataSource = ds.Tables["teachers"];
            conn.Close();
        }
    }
}
