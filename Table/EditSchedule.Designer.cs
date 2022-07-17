using System;
using System.Windows.Forms;

namespace Table
{
    partial class EditSchedule
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSchedule));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timetableDataSet = new Table.timetableDataSet();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.AddingMode = new MaterialSkin.Controls.MaterialCheckBox();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.teacherPatr = new System.Windows.Forms.TextBox();
            this.teacherName = new System.Windows.Forms.TextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.subjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.a1a1a1 = new System.Windows.Forms.TextBox();
            this.a1a1a2 = new System.Windows.Forms.TextBox();
            this.a1a1a4 = new System.Windows.Forms.TextBox();
            this.a1a1a3 = new System.Windows.Forms.TextBox();
            this.a1a2a3 = new System.Windows.Forms.TextBox();
            this.a1a2a4 = new System.Windows.Forms.TextBox();
            this.a1a2a2 = new System.Windows.Forms.TextBox();
            this.a1a2a1 = new System.Windows.Forms.TextBox();
            this.a1a3a3 = new System.Windows.Forms.TextBox();
            this.a1a3a4 = new System.Windows.Forms.TextBox();
            this.a1a3a2 = new System.Windows.Forms.TextBox();
            this.a1a3a1 = new System.Windows.Forms.TextBox();
            this.a1a4a3 = new System.Windows.Forms.TextBox();
            this.a1a4a4 = new System.Windows.Forms.TextBox();
            this.a1a4a2 = new System.Windows.Forms.TextBox();
            this.a1a4a1 = new System.Windows.Forms.TextBox();
            this.a1a5a3 = new System.Windows.Forms.TextBox();
            this.a1a5a4 = new System.Windows.Forms.TextBox();
            this.a1a5a2 = new System.Windows.Forms.TextBox();
            this.a1a5a1 = new System.Windows.Forms.TextBox();
            this.a1a6a3 = new System.Windows.Forms.TextBox();
            this.a1a6a4 = new System.Windows.Forms.TextBox();
            this.a1a6a2 = new System.Windows.Forms.TextBox();
            this.a1a6a1 = new System.Windows.Forms.TextBox();
            this.a2a6a3 = new System.Windows.Forms.TextBox();
            this.a2a6a4 = new System.Windows.Forms.TextBox();
            this.a2a6a2 = new System.Windows.Forms.TextBox();
            this.a2a6a1 = new System.Windows.Forms.TextBox();
            this.a2a5a3 = new System.Windows.Forms.TextBox();
            this.a2a5a4 = new System.Windows.Forms.TextBox();
            this.a2a5a2 = new System.Windows.Forms.TextBox();
            this.a2a5a1 = new System.Windows.Forms.TextBox();
            this.a2a4a3 = new System.Windows.Forms.TextBox();
            this.a2a4a4 = new System.Windows.Forms.TextBox();
            this.a2a4a2 = new System.Windows.Forms.TextBox();
            this.a2a4a1 = new System.Windows.Forms.TextBox();
            this.a2a3a3 = new System.Windows.Forms.TextBox();
            this.a2a3a4 = new System.Windows.Forms.TextBox();
            this.a2a3a2 = new System.Windows.Forms.TextBox();
            this.a2a3a1 = new System.Windows.Forms.TextBox();
            this.a2a2a3 = new System.Windows.Forms.TextBox();
            this.a2a2a4 = new System.Windows.Forms.TextBox();
            this.a2a2a2 = new System.Windows.Forms.TextBox();
            this.a2a2a1 = new System.Windows.Forms.TextBox();
            this.a2a1a3 = new System.Windows.Forms.TextBox();
            this.a2a1a4 = new System.Windows.Forms.TextBox();
            this.a2a1a2 = new System.Windows.Forms.TextBox();
            this.a2a1a1 = new System.Windows.Forms.TextBox();
            this.groupsTableAdapter = new Table.timetableDataSetTableAdapters.groupsTableAdapter();
            this.subjectsTableAdapter = new Table.timetableDataSetTableAdapters.subjectsTableAdapter();
            this.teachersTableAdapter = new Table.timetableDataSetTableAdapters.teachersTableAdapter();
            this.roomsTableAdapter = new Table.timetableDataSetTableAdapters.roomsTableAdapter();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDataSet)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 22);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // iconButton3
            // 
            this.iconButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButton3.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 25;
            this.iconButton3.Location = new System.Drawing.Point(686, 2);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(22, 22);
            this.iconButton3.TabIndex = 4;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton1.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(736, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(22, 22);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconButton2.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 20;
            this.iconButton2.Location = new System.Drawing.Point(711, 2);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(22, 22);
            this.iconButton2.TabIndex = 3;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Location = new System.Drawing.Point(0, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(765, 51);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.comboBox1.DataSource = this.groupsBindingSource;
            this.comboBox1.DisplayMember = "nameOfGroup";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboBox1.Location = new System.Drawing.Point(-1, -1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "idGroups";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "groups";
            this.groupsBindingSource.DataSource = this.timetableDataSet;
            // 
            // timetableDataSet
            // 
            this.timetableDataSet.DataSetName = "timetableDataSet";
            this.timetableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.label13.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(662, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 21);
            this.label13.TabIndex = 19;
            this.label13.Text = "Суббота";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.label12.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(535, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 21);
            this.label12.TabIndex = 18;
            this.label12.Text = "Пятница";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.label11.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(410, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 21);
            this.label11.TabIndex = 17;
            this.label11.Text = "Четверг";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.label10.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(289, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 21);
            this.label10.TabIndex = 16;
            this.label10.Text = "Среда";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.label9.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(155, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "Вторник";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.label14.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(9, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 21);
            this.label14.TabIndex = 20;
            this.label14.Text = "Понедельник";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.BackColor = System.Drawing.Color.White;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(0, 200);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(765, 1);
            this.materialLabel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(127, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1, 256);
            this.label2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(254, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1, 256);
            this.label1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(381, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1, 256);
            this.label3.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(508, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1, 256);
            this.label4.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(635, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1, 256);
            this.label5.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.panel4.Controls.Add(this.iconButton5);
            this.panel4.Controls.Add(this.AddingMode);
            this.panel4.Controls.Add(this.iconButton4);
            this.panel4.Controls.Add(this.teacherPatr);
            this.panel4.Controls.Add(this.teacherName);
            this.panel4.Controls.Add(this.comboBox4);
            this.panel4.Controls.Add(this.comboBox3);
            this.panel4.Controls.Add(this.comboBox2);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.splitter1);
            this.panel4.Location = new System.Drawing.Point(-1, 328);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(765, 174);
            this.panel4.TabIndex = 18;
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButton5.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton5.IconSize = 50;
            this.iconButton5.Location = new System.Drawing.Point(687, 19);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(50, 50);
            this.iconButton5.TabIndex = 16;
            this.iconButton5.UseVisualStyleBackColor = false;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // AddingMode
            // 
            this.AddingMode.AutoSize = true;
            this.AddingMode.Depth = 0;
            this.AddingMode.Font = new System.Drawing.Font("Roboto", 10F);
            this.AddingMode.Location = new System.Drawing.Point(585, 135);
            this.AddingMode.Margin = new System.Windows.Forms.Padding(0);
            this.AddingMode.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AddingMode.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddingMode.Name = "AddingMode";
            this.AddingMode.Ripple = true;
            this.AddingMode.Size = new System.Drawing.Size(157, 30);
            this.AddingMode.TabIndex = 15;
            this.AddingMode.Text = "Режим добавления";
            this.AddingMode.UseVisualStyleBackColor = true;
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.iconButton4.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton4.IconSize = 50;
            this.iconButton4.Location = new System.Drawing.Point(687, 75);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(50, 50);
            this.iconButton4.TabIndex = 14;
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // teacherPatr
            // 
            this.teacherPatr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.teacherPatr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teacherPatr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.teacherPatr.Location = new System.Drawing.Point(410, 89);
            this.teacherPatr.Name = "teacherPatr";
            this.teacherPatr.ReadOnly = true;
            this.teacherPatr.Size = new System.Drawing.Size(100, 25);
            this.teacherPatr.TabIndex = 12;
            // 
            // teacherName
            // 
            this.teacherName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.teacherName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teacherName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.teacherName.Location = new System.Drawing.Point(305, 89);
            this.teacherName.Name = "teacherName";
            this.teacherName.ReadOnly = true;
            this.teacherName.Size = new System.Drawing.Size(100, 25);
            this.teacherName.TabIndex = 11;
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.comboBox4.DataSource = this.roomsBindingSource;
            this.comboBox4.DisplayMember = "NameOfRoom";
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboBox4.Location = new System.Drawing.Point(540, 89);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 28);
            this.comboBox4.TabIndex = 10;
            this.comboBox4.ValueMember = "idRooms";
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "rooms";
            this.roomsBindingSource.DataSource = this.timetableDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboBox3.Location = new System.Drawing.Point(200, 89);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 28);
            this.comboBox3.TabIndex = 9;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.comboBox2.DataSource = this.subjectsBindingSource;
            this.comboBox2.DisplayMember = "subjectName";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboBox2.Location = new System.Drawing.Point(50, 89);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.ValueMember = "idSubjects";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // subjectsBindingSource
            // 
            this.subjectsBindingSource.DataMember = "subjects";
            this.subjectsBindingSource.DataSource = this.timetableDataSet;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(556, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Аудитория";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(292, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Преподаватель";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(73, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Предмет";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 174);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "teachers";
            this.teachersBindingSource.DataSource = this.timetableDataSet;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.BackColor = System.Drawing.Color.White;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(0, 328);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(765, 1);
            this.materialLabel2.TabIndex = 19;
            // 
            // a1a1a1
            // 
            this.a1a1a1.AccessibleName = "txtRaspisanie";
            this.a1a1a1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a1a1a1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a1a1a1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a1a1a1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a1a1a1.Location = new System.Drawing.Point(12, 84);
            this.a1a1a1.Multiline = true;
            this.a1a1a1.Name = "a1a1a1";
            this.a1a1a1.ReadOnly = true;
            this.a1a1a1.Size = new System.Drawing.Size(100, 20);
            this.a1a1a1.TabIndex = 20;
            // 
            // a1a1a2
            // 
            this.a1a1a2.AccessibleName = "txtRaspisanie";
            this.a1a1a2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a1a1a2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a1a1a2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a1a1a2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a1a1a2.Location = new System.Drawing.Point(12, 110);
            this.a1a1a2.Multiline = true;
            this.a1a1a2.Name = "a1a1a2";
            this.a1a1a2.ReadOnly = true;
            this.a1a1a2.Size = new System.Drawing.Size(100, 20);
            this.a1a1a2.TabIndex = 21;
            // 
            // a1a1a4
            // 
            this.a1a1a4.AccessibleName = "txtRaspisanie";
            this.a1a1a4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a1a1a4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a1a1a4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a1a1a4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a1a1a4.Location = new System.Drawing.Point(12, 162);
            this.a1a1a4.Multiline = true;
            this.a1a1a4.Name = "a1a1a4";
            this.a1a1a4.ReadOnly = true;
            this.a1a1a4.Size = new System.Drawing.Size(100, 20);
            this.a1a1a4.TabIndex = 22;
            // 
            // a1a1a3
            // 
            this.a1a1a3.AccessibleName = "txtRaspisanie";
            this.a1a1a3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a1a1a3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a1a1a3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a1a1a3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a1a1a3.Location = new System.Drawing.Point(12, 136);
            this.a1a1a3.Multiline = true;
            this.a1a1a3.Name = "a1a1a3";
            this.a1a1a3.ReadOnly = true;
            this.a1a1a3.Size = new System.Drawing.Size(100, 20);
            this.a1a1a3.TabIndex = 23;
            // 
            // a1a2a3
            // 
            this.a1a2a3.AccessibleName = "txtRaspisanie";
            this.a1a2a3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a1a2a3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a1a2a3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a1a2a3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a1a2a3.Location = new System.Drawing.Point(141, 136);
            this.a1a2a3.Multiline = true;
            this.a1a2a3.Name = "a1a2a3";
            this.a1a2a3.ReadOnly = true;
            this.a1a2a3.Size = new System.Drawing.Size(100, 20);
            this.a1a2a3.TabIndex = 27;
            // 
            // a1a2a4
            // 
            this.a1a2a4.AccessibleName = "txtRaspisanie";
            this.a1a2a4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a1a2a4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a1a2a4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a1a2a4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a1a2a4.Location = new System.Drawing.Point(141, 162);
            this.a1a2a4.Multiline = true;
            this.a1a2a4.Name = "a1a2a4";
            this.a1a2a4.ReadOnly = true;
            this.a1a2a4.Size = new System.Drawing.Size(100, 20);
            this.a1a2a4.TabIndex = 26;
            // 
            // a1a2a2
            // 
            this.a1a2a2.AccessibleName = "txtRaspisanie";
            this.a1a2a2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a1a2a2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a1a2a2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a1a2a2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a1a2a2.Location = new System.Drawing.Point(141, 110);
            this.a1a2a2.Multiline = true;
            this.a1a2a2.Name = "a1a2a2";
            this.a1a2a2.ReadOnly = true;
            this.a1a2a2.Size = new System.Drawing.Size(100, 20);
            this.a1a2a2.TabIndex = 25;
            // 
            // a1a2a1
            // 
            this.a1a2a1.AccessibleName = "txtRaspisanie";
            this.a1a2a1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a1a2a1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a1a2a1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a1a2a1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a1a2a1.Location = new System.Drawing.Point(141, 84);
            this.a1a2a1.Multiline = true;
            this.a1a2a1.Name = "a1a2a1";
            this.a1a2a1.ReadOnly = true;
            this.a1a2a1.Size = new System.Drawing.Size(100, 20);
            this.a1a2a1.TabIndex = 24;
            // 
            // a1a3a3
            // 
            this.a1a3a3.AccessibleName = "txtRaspisanie";
            this.a1a3a3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a1a3a3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a1a3a3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a1a3a3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a1a3a3.Location = new System.Drawing.Point(268, 136);
            this.a1a3a3.Multiline = true;
            this.a1a3a3.Name = "a1a3a3";
            this.a1a3a3.ReadOnly = true;
            this.a1a3a3.Size = new System.Drawing.Size(100, 20);
            this.a1a3a3.TabIndex = 31;
            // 
            // a1a3a4
            // 
            this.a1a3a4.AccessibleName = "txtRaspisanie";
            this.a1a3a4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a1a3a4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a1a3a4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a1a3a4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a1a3a4.Location = new System.Drawing.Point(268, 162);
            this.a1a3a4.Multiline = true;
            this.a1a3a4.Name = "a1a3a4";
            this.a1a3a4.ReadOnly = true;
            this.a1a3a4.Size = new System.Drawing.Size(100, 20);
            this.a1a3a4.TabIndex = 30;
            // 
            // a1a3a2
            // 
            this.a1a3a2.AccessibleName = "txtRaspisanie";
            this.a1a3a2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a1a3a2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a1a3a2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a1a3a2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a1a3a2.Location = new System.Drawing.Point(268, 110);
            this.a1a3a2.Multiline = true;
            this.a1a3a2.Name = "a1a3a2";
            this.a1a3a2.ReadOnly = true;
            this.a1a3a2.Size = new System.Drawing.Size(100, 20);
            this.a1a3a2.TabIndex = 29;
            // 
            // a1a3a1
            // 
            this.a1a3a1.AccessibleName = "txtRaspisanie";
            this.a1a3a1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a1a3a1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a1a3a1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a1a3a1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a1a3a1.Location = new System.Drawing.Point(268, 84);
            this.a1a3a1.Multiline = true;
            this.a1a3a1.Name = "a1a3a1";
            this.a1a3a1.ReadOnly = true;
            this.a1a3a1.Size = new System.Drawing.Size(100, 20);
            this.a1a3a1.TabIndex = 28;
            // 
            // a1a4a3
            // 
            this.a1a4a3.AccessibleName = "txtRaspisanie";
            this.a1a4a3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a1a4a3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a1a4a3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a1a4a3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a1a4a3.Location = new System.Drawing.Point(394, 136);
            this.a1a4a3.Multiline = true;
            this.a1a4a3.Name = "a1a4a3";
            this.a1a4a3.ReadOnly = true;
            this.a1a4a3.Size = new System.Drawing.Size(100, 20);
            this.a1a4a3.TabIndex = 35;
            // 
            // a1a4a4
            // 
            this.a1a4a4.AccessibleName = "txtRaspisanie";
            this.a1a4a4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a1a4a4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a1a4a4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a1a4a4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a1a4a4.Location = new System.Drawing.Point(394, 162);
            this.a1a4a4.Multiline = true;
            this.a1a4a4.Name = "a1a4a4";
            this.a1a4a4.ReadOnly = true;
            this.a1a4a4.Size = new System.Drawing.Size(100, 20);
            this.a1a4a4.TabIndex = 34;
            // 
            // a1a4a2
            // 
            this.a1a4a2.AccessibleName = "txtRaspisanie";
            this.a1a4a2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a1a4a2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a1a4a2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a1a4a2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a1a4a2.Location = new System.Drawing.Point(394, 110);
            this.a1a4a2.Multiline = true;
            this.a1a4a2.Name = "a1a4a2";
            this.a1a4a2.ReadOnly = true;
            this.a1a4a2.Size = new System.Drawing.Size(100, 20);
            this.a1a4a2.TabIndex = 33;
            // 
            // a1a4a1
            // 
            this.a1a4a1.AccessibleName = "txtRaspisanie";
            this.a1a4a1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a1a4a1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a1a4a1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a1a4a1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a1a4a1.Location = new System.Drawing.Point(394, 84);
            this.a1a4a1.Multiline = true;
            this.a1a4a1.Name = "a1a4a1";
            this.a1a4a1.ReadOnly = true;
            this.a1a4a1.Size = new System.Drawing.Size(100, 20);
            this.a1a4a1.TabIndex = 32;
            // 
            // a1a5a3
            // 
            this.a1a5a3.AccessibleName = "txtRaspisanie";
            this.a1a5a3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a1a5a3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a1a5a3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a1a5a3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a1a5a3.Location = new System.Drawing.Point(521, 136);
            this.a1a5a3.Multiline = true;
            this.a1a5a3.Name = "a1a5a3";
            this.a1a5a3.ReadOnly = true;
            this.a1a5a3.Size = new System.Drawing.Size(100, 20);
            this.a1a5a3.TabIndex = 39;
            // 
            // a1a5a4
            // 
            this.a1a5a4.AccessibleName = "txtRaspisanie";
            this.a1a5a4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a1a5a4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a1a5a4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a1a5a4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a1a5a4.Location = new System.Drawing.Point(521, 162);
            this.a1a5a4.Multiline = true;
            this.a1a5a4.Name = "a1a5a4";
            this.a1a5a4.ReadOnly = true;
            this.a1a5a4.Size = new System.Drawing.Size(100, 20);
            this.a1a5a4.TabIndex = 38;
            // 
            // a1a5a2
            // 
            this.a1a5a2.AccessibleName = "txtRaspisanie";
            this.a1a5a2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a1a5a2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a1a5a2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a1a5a2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a1a5a2.Location = new System.Drawing.Point(521, 110);
            this.a1a5a2.Multiline = true;
            this.a1a5a2.Name = "a1a5a2";
            this.a1a5a2.ReadOnly = true;
            this.a1a5a2.Size = new System.Drawing.Size(100, 20);
            this.a1a5a2.TabIndex = 37;
            // 
            // a1a5a1
            // 
            this.a1a5a1.AccessibleName = "txtRaspisanie";
            this.a1a5a1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a1a5a1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a1a5a1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a1a5a1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a1a5a1.Location = new System.Drawing.Point(521, 84);
            this.a1a5a1.Multiline = true;
            this.a1a5a1.Name = "a1a5a1";
            this.a1a5a1.ReadOnly = true;
            this.a1a5a1.Size = new System.Drawing.Size(100, 20);
            this.a1a5a1.TabIndex = 36;
            // 
            // a1a6a3
            // 
            this.a1a6a3.AccessibleName = "txtRaspisanie";
            this.a1a6a3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a1a6a3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a1a6a3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a1a6a3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a1a6a3.Location = new System.Drawing.Point(650, 136);
            this.a1a6a3.Multiline = true;
            this.a1a6a3.Name = "a1a6a3";
            this.a1a6a3.ReadOnly = true;
            this.a1a6a3.Size = new System.Drawing.Size(100, 20);
            this.a1a6a3.TabIndex = 43;
            // 
            // a1a6a4
            // 
            this.a1a6a4.AccessibleName = "txtRaspisanie";
            this.a1a6a4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a1a6a4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a1a6a4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a1a6a4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a1a6a4.Location = new System.Drawing.Point(650, 162);
            this.a1a6a4.Multiline = true;
            this.a1a6a4.Name = "a1a6a4";
            this.a1a6a4.ReadOnly = true;
            this.a1a6a4.Size = new System.Drawing.Size(100, 20);
            this.a1a6a4.TabIndex = 42;
            // 
            // a1a6a2
            // 
            this.a1a6a2.AccessibleName = "txtRaspisanie";
            this.a1a6a2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a1a6a2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a1a6a2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a1a6a2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a1a6a2.Location = new System.Drawing.Point(650, 110);
            this.a1a6a2.Multiline = true;
            this.a1a6a2.Name = "a1a6a2";
            this.a1a6a2.ReadOnly = true;
            this.a1a6a2.Size = new System.Drawing.Size(100, 20);
            this.a1a6a2.TabIndex = 41;
            // 
            // a1a6a1
            // 
            this.a1a6a1.AccessibleName = "txtRaspisanie";
            this.a1a6a1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a1a6a1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a1a6a1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a1a6a1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a1a6a1.Location = new System.Drawing.Point(650, 84);
            this.a1a6a1.Multiline = true;
            this.a1a6a1.Name = "a1a6a1";
            this.a1a6a1.ReadOnly = true;
            this.a1a6a1.Size = new System.Drawing.Size(100, 20);
            this.a1a6a1.TabIndex = 40;
            // 
            // a2a6a3
            // 
            this.a2a6a3.AccessibleName = "txtRaspisanie";
            this.a2a6a3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a2a6a3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a2a6a3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a2a6a3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a2a6a3.Location = new System.Drawing.Point(651, 261);
            this.a2a6a3.Multiline = true;
            this.a2a6a3.Name = "a2a6a3";
            this.a2a6a3.ReadOnly = true;
            this.a2a6a3.Size = new System.Drawing.Size(100, 20);
            this.a2a6a3.TabIndex = 67;
            // 
            // a2a6a4
            // 
            this.a2a6a4.AccessibleName = "txtRaspisanie";
            this.a2a6a4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a2a6a4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a2a6a4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a2a6a4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a2a6a4.Location = new System.Drawing.Point(651, 287);
            this.a2a6a4.Multiline = true;
            this.a2a6a4.Name = "a2a6a4";
            this.a2a6a4.ReadOnly = true;
            this.a2a6a4.Size = new System.Drawing.Size(100, 20);
            this.a2a6a4.TabIndex = 66;
            // 
            // a2a6a2
            // 
            this.a2a6a2.AccessibleName = "txtRaspisanie";
            this.a2a6a2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a2a6a2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a2a6a2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a2a6a2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a2a6a2.Location = new System.Drawing.Point(651, 235);
            this.a2a6a2.Multiline = true;
            this.a2a6a2.Name = "a2a6a2";
            this.a2a6a2.ReadOnly = true;
            this.a2a6a2.Size = new System.Drawing.Size(100, 20);
            this.a2a6a2.TabIndex = 65;
            // 
            // a2a6a1
            // 
            this.a2a6a1.AccessibleName = "txtRaspisanie";
            this.a2a6a1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a2a6a1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a2a6a1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a2a6a1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a2a6a1.Location = new System.Drawing.Point(651, 209);
            this.a2a6a1.Multiline = true;
            this.a2a6a1.Name = "a2a6a1";
            this.a2a6a1.ReadOnly = true;
            this.a2a6a1.Size = new System.Drawing.Size(100, 20);
            this.a2a6a1.TabIndex = 64;
            // 
            // a2a5a3
            // 
            this.a2a5a3.AccessibleName = "txtRaspisanie";
            this.a2a5a3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a2a5a3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a2a5a3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a2a5a3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a2a5a3.Location = new System.Drawing.Point(522, 261);
            this.a2a5a3.Multiline = true;
            this.a2a5a3.Name = "a2a5a3";
            this.a2a5a3.ReadOnly = true;
            this.a2a5a3.Size = new System.Drawing.Size(100, 20);
            this.a2a5a3.TabIndex = 63;
            // 
            // a2a5a4
            // 
            this.a2a5a4.AccessibleName = "txtRaspisanie";
            this.a2a5a4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a2a5a4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a2a5a4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a2a5a4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a2a5a4.Location = new System.Drawing.Point(522, 287);
            this.a2a5a4.Multiline = true;
            this.a2a5a4.Name = "a2a5a4";
            this.a2a5a4.ReadOnly = true;
            this.a2a5a4.Size = new System.Drawing.Size(100, 20);
            this.a2a5a4.TabIndex = 62;
            // 
            // a2a5a2
            // 
            this.a2a5a2.AccessibleName = "txtRaspisanie";
            this.a2a5a2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a2a5a2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a2a5a2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a2a5a2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a2a5a2.Location = new System.Drawing.Point(522, 235);
            this.a2a5a2.Multiline = true;
            this.a2a5a2.Name = "a2a5a2";
            this.a2a5a2.ReadOnly = true;
            this.a2a5a2.Size = new System.Drawing.Size(100, 20);
            this.a2a5a2.TabIndex = 61;
            // 
            // a2a5a1
            // 
            this.a2a5a1.AccessibleName = "txtRaspisanie";
            this.a2a5a1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a2a5a1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a2a5a1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a2a5a1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a2a5a1.Location = new System.Drawing.Point(522, 209);
            this.a2a5a1.Multiline = true;
            this.a2a5a1.Name = "a2a5a1";
            this.a2a5a1.ReadOnly = true;
            this.a2a5a1.Size = new System.Drawing.Size(100, 20);
            this.a2a5a1.TabIndex = 60;
            // 
            // a2a4a3
            // 
            this.a2a4a3.AccessibleName = "txtRaspisanie";
            this.a2a4a3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a2a4a3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a2a4a3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a2a4a3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a2a4a3.Location = new System.Drawing.Point(395, 261);
            this.a2a4a3.Multiline = true;
            this.a2a4a3.Name = "a2a4a3";
            this.a2a4a3.ReadOnly = true;
            this.a2a4a3.Size = new System.Drawing.Size(100, 20);
            this.a2a4a3.TabIndex = 59;
            // 
            // a2a4a4
            // 
            this.a2a4a4.AccessibleName = "txtRaspisanie";
            this.a2a4a4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a2a4a4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a2a4a4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a2a4a4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a2a4a4.Location = new System.Drawing.Point(395, 287);
            this.a2a4a4.Multiline = true;
            this.a2a4a4.Name = "a2a4a4";
            this.a2a4a4.ReadOnly = true;
            this.a2a4a4.Size = new System.Drawing.Size(100, 20);
            this.a2a4a4.TabIndex = 58;
            // 
            // a2a4a2
            // 
            this.a2a4a2.AccessibleName = "txtRaspisanie";
            this.a2a4a2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a2a4a2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a2a4a2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a2a4a2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a2a4a2.Location = new System.Drawing.Point(395, 235);
            this.a2a4a2.Multiline = true;
            this.a2a4a2.Name = "a2a4a2";
            this.a2a4a2.ReadOnly = true;
            this.a2a4a2.Size = new System.Drawing.Size(100, 20);
            this.a2a4a2.TabIndex = 57;
            // 
            // a2a4a1
            // 
            this.a2a4a1.AccessibleName = "txtRaspisanie";
            this.a2a4a1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a2a4a1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a2a4a1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a2a4a1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a2a4a1.Location = new System.Drawing.Point(395, 209);
            this.a2a4a1.Multiline = true;
            this.a2a4a1.Name = "a2a4a1";
            this.a2a4a1.ReadOnly = true;
            this.a2a4a1.Size = new System.Drawing.Size(100, 20);
            this.a2a4a1.TabIndex = 56;
            // 
            // a2a3a3
            // 
            this.a2a3a3.AccessibleName = "txtRaspisanie";
            this.a2a3a3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a2a3a3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a2a3a3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a2a3a3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a2a3a3.Location = new System.Drawing.Point(269, 261);
            this.a2a3a3.Multiline = true;
            this.a2a3a3.Name = "a2a3a3";
            this.a2a3a3.ReadOnly = true;
            this.a2a3a3.Size = new System.Drawing.Size(100, 20);
            this.a2a3a3.TabIndex = 55;
            // 
            // a2a3a4
            // 
            this.a2a3a4.AccessibleName = "txtRaspisanie";
            this.a2a3a4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a2a3a4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a2a3a4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a2a3a4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a2a3a4.Location = new System.Drawing.Point(269, 287);
            this.a2a3a4.Multiline = true;
            this.a2a3a4.Name = "a2a3a4";
            this.a2a3a4.ReadOnly = true;
            this.a2a3a4.Size = new System.Drawing.Size(100, 20);
            this.a2a3a4.TabIndex = 54;
            // 
            // a2a3a2
            // 
            this.a2a3a2.AccessibleName = "txtRaspisanie";
            this.a2a3a2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a2a3a2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a2a3a2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a2a3a2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a2a3a2.Location = new System.Drawing.Point(269, 235);
            this.a2a3a2.Multiline = true;
            this.a2a3a2.Name = "a2a3a2";
            this.a2a3a2.ReadOnly = true;
            this.a2a3a2.Size = new System.Drawing.Size(100, 20);
            this.a2a3a2.TabIndex = 53;
            // 
            // a2a3a1
            // 
            this.a2a3a1.AccessibleName = "txtRaspisanie";
            this.a2a3a1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a2a3a1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a2a3a1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a2a3a1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a2a3a1.Location = new System.Drawing.Point(269, 209);
            this.a2a3a1.Multiline = true;
            this.a2a3a1.Name = "a2a3a1";
            this.a2a3a1.ReadOnly = true;
            this.a2a3a1.Size = new System.Drawing.Size(100, 20);
            this.a2a3a1.TabIndex = 52;
            // 
            // a2a2a3
            // 
            this.a2a2a3.AccessibleName = "txtRaspisanie";
            this.a2a2a3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a2a2a3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a2a2a3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a2a2a3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a2a2a3.Location = new System.Drawing.Point(142, 261);
            this.a2a2a3.Multiline = true;
            this.a2a2a3.Name = "a2a2a3";
            this.a2a2a3.ReadOnly = true;
            this.a2a2a3.Size = new System.Drawing.Size(100, 20);
            this.a2a2a3.TabIndex = 51;
            // 
            // a2a2a4
            // 
            this.a2a2a4.AccessibleName = "txtRaspisanie";
            this.a2a2a4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a2a2a4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a2a2a4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a2a2a4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a2a2a4.Location = new System.Drawing.Point(142, 287);
            this.a2a2a4.Multiline = true;
            this.a2a2a4.Name = "a2a2a4";
            this.a2a2a4.ReadOnly = true;
            this.a2a2a4.Size = new System.Drawing.Size(100, 20);
            this.a2a2a4.TabIndex = 50;
            // 
            // a2a2a2
            // 
            this.a2a2a2.AccessibleName = "txtRaspisanie";
            this.a2a2a2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a2a2a2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a2a2a2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a2a2a2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a2a2a2.Location = new System.Drawing.Point(142, 235);
            this.a2a2a2.Multiline = true;
            this.a2a2a2.Name = "a2a2a2";
            this.a2a2a2.ReadOnly = true;
            this.a2a2a2.Size = new System.Drawing.Size(100, 20);
            this.a2a2a2.TabIndex = 49;
            // 
            // a2a2a1
            // 
            this.a2a2a1.AccessibleName = "txtRaspisanie";
            this.a2a2a1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a2a2a1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a2a2a1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a2a2a1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a2a2a1.Location = new System.Drawing.Point(142, 209);
            this.a2a2a1.Multiline = true;
            this.a2a2a1.Name = "a2a2a1";
            this.a2a2a1.ReadOnly = true;
            this.a2a2a1.Size = new System.Drawing.Size(100, 20);
            this.a2a2a1.TabIndex = 48;
            // 
            // a2a1a3
            // 
            this.a2a1a3.AccessibleName = "txtRaspisanie";
            this.a2a1a3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a2a1a3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a2a1a3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a2a1a3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a2a1a3.Location = new System.Drawing.Point(13, 261);
            this.a2a1a3.Multiline = true;
            this.a2a1a3.Name = "a2a1a3";
            this.a2a1a3.ReadOnly = true;
            this.a2a1a3.Size = new System.Drawing.Size(100, 20);
            this.a2a1a3.TabIndex = 47;
            // 
            // a2a1a4
            // 
            this.a2a1a4.AccessibleName = "txtRaspisanie";
            this.a2a1a4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a2a1a4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a2a1a4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a2a1a4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a2a1a4.Location = new System.Drawing.Point(13, 287);
            this.a2a1a4.Multiline = true;
            this.a2a1a4.Name = "a2a1a4";
            this.a2a1a4.ReadOnly = true;
            this.a2a1a4.Size = new System.Drawing.Size(100, 20);
            this.a2a1a4.TabIndex = 46;
            // 
            // a2a1a2
            // 
            this.a2a1a2.AccessibleName = "txtRaspisanie";
            this.a2a1a2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a2a1a2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a2a1a2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a2a1a2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a2a1a2.Location = new System.Drawing.Point(13, 235);
            this.a2a1a2.Multiline = true;
            this.a2a1a2.Name = "a2a1a2";
            this.a2a1a2.ReadOnly = true;
            this.a2a1a2.Size = new System.Drawing.Size(100, 20);
            this.a2a1a2.TabIndex = 45;
            // 
            // a2a1a1
            // 
            this.a2a1a1.AccessibleName = "txtRaspisanie";
            this.a2a1a1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.a2a1a1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.a2a1a1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a2a1a1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.a2a1a1.Location = new System.Drawing.Point(13, 209);
            this.a2a1a1.Multiline = true;
            this.a2a1a1.Name = "a2a1a1";
            this.a2a1a1.ReadOnly = true;
            this.a2a1a1.Size = new System.Drawing.Size(100, 20);
            this.a2a1a1.TabIndex = 44;
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // subjectsTableAdapter
            // 
            this.subjectsTableAdapter.ClearBeforeFill = true;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(0, 48);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(765, 1);
            this.materialLabel3.TabIndex = 68;
            // 
            // EditSchedule
            // 
            this.AccessibleName = "";
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(765, 500);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.a2a6a3);
            this.Controls.Add(this.a2a6a4);
            this.Controls.Add(this.a2a6a2);
            this.Controls.Add(this.a2a6a1);
            this.Controls.Add(this.a2a5a3);
            this.Controls.Add(this.a2a5a4);
            this.Controls.Add(this.a2a5a2);
            this.Controls.Add(this.a2a5a1);
            this.Controls.Add(this.a2a4a3);
            this.Controls.Add(this.a2a4a4);
            this.Controls.Add(this.a2a4a2);
            this.Controls.Add(this.a2a4a1);
            this.Controls.Add(this.a2a3a3);
            this.Controls.Add(this.a2a3a4);
            this.Controls.Add(this.a2a3a2);
            this.Controls.Add(this.a2a3a1);
            this.Controls.Add(this.a2a2a3);
            this.Controls.Add(this.a2a2a4);
            this.Controls.Add(this.a2a2a2);
            this.Controls.Add(this.a2a2a1);
            this.Controls.Add(this.a2a1a3);
            this.Controls.Add(this.a2a1a4);
            this.Controls.Add(this.a2a1a2);
            this.Controls.Add(this.a2a1a1);
            this.Controls.Add(this.a1a6a3);
            this.Controls.Add(this.a1a6a4);
            this.Controls.Add(this.a1a6a2);
            this.Controls.Add(this.a1a6a1);
            this.Controls.Add(this.a1a5a3);
            this.Controls.Add(this.a1a5a4);
            this.Controls.Add(this.a1a5a2);
            this.Controls.Add(this.a1a5a1);
            this.Controls.Add(this.a1a4a3);
            this.Controls.Add(this.a1a4a4);
            this.Controls.Add(this.a1a4a2);
            this.Controls.Add(this.a1a4a1);
            this.Controls.Add(this.a1a3a3);
            this.Controls.Add(this.a1a3a4);
            this.Controls.Add(this.a1a3a2);
            this.Controls.Add(this.a1a3a1);
            this.Controls.Add(this.a1a2a3);
            this.Controls.Add(this.a1a2a4);
            this.Controls.Add(this.a1a2a2);
            this.Controls.Add(this.a1a2a1);
            this.Controls.Add(this.a1a1a3);
            this.Controls.Add(this.a1a1a4);
            this.Controls.Add(this.a1a1a2);
            this.Controls.Add(this.a1a1a1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(765, 500);
            this.Name = "EditSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditSchedule_FormClosing);
            this.Load += new System.EventHandler(this.EditSchedule_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDataSet)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Panel panel2;
        private ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private Splitter splitter1;
        private TextBox teacherPatr;
        private TextBox teacherName;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private Label label8;
        private Label label7;
        private Label label6;
       
        private FontAwesome.Sharp.IconButton iconButton4;
        private TextBox a1a1a1;
        private TextBox a1a1a2;
        private TextBox a1a1a4;
        private TextBox a1a1a3;
        private TextBox a1a2a3;
        private TextBox a1a2a4;
        private TextBox a1a2a2;
        private TextBox a1a2a1;
        private TextBox a1a3a3;
        private TextBox a1a3a4;
        private TextBox a1a3a2;
        private TextBox a1a3a1;
        private TextBox a1a4a3;
        private TextBox a1a4a4;
        private TextBox a1a4a2;
        private TextBox a1a4a1;
        private TextBox a1a5a3;
        private TextBox a1a5a4;
        private TextBox a1a5a2;
        private TextBox a1a5a1;
        private TextBox a1a6a3;
        private TextBox a1a6a4;
        private TextBox a1a6a2;
        private TextBox a1a6a1;
        private TextBox a2a6a3;
        private TextBox a2a6a4;
        private TextBox a2a6a2;
        private TextBox a2a6a1;
        private TextBox a2a5a3;
        private TextBox a2a5a4;
        private TextBox a2a5a2;
        private TextBox a2a5a1;
        private TextBox a2a4a3;
        private TextBox a2a4a4;
        private TextBox a2a4a2;
        private TextBox a2a4a1;
        private TextBox a2a3a3;
        private TextBox a2a3a4;
        private TextBox a2a3a2;
        private TextBox a2a3a1;
        private TextBox a2a2a3;
        private TextBox a2a2a4;
        private TextBox a2a2a2;
        private TextBox a2a2a1;
        private TextBox a2a1a3;
        private TextBox a2a1a4;
        private TextBox a2a1a2;
        private TextBox a2a1a1;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label14;
        private timetableDataSet timetableDataSet;
        private BindingSource groupsBindingSource;
        private timetableDataSetTableAdapters.groupsTableAdapter groupsTableAdapter;
        private BindingSource subjectsBindingSource;
        private timetableDataSetTableAdapters.subjectsTableAdapter subjectsTableAdapter;
        private BindingSource teachersBindingSource;
        private timetableDataSetTableAdapters.teachersTableAdapter teachersTableAdapter;
        private BindingSource roomsBindingSource;
        private timetableDataSetTableAdapters.roomsTableAdapter roomsTableAdapter;
        private MaterialSkin.Controls.MaterialCheckBox AddingMode;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private FontAwesome.Sharp.IconButton iconButton5;
    }
}

