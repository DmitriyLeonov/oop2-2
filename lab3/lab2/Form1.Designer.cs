namespace lab3
{
    partial class Airport
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.planeModel = new System.Windows.Forms.TextBox();
            this.passengerRadioButton = new System.Windows.Forms.RadioButton();
            this.CargoRadioButton = new System.Windows.Forms.RadioButton();
            this.militaryRadioButton = new System.Windows.Forms.RadioButton();
            this.seatsTextBox = new System.Windows.Forms.TextBox();
            this.loadTextBox = new System.Windows.Forms.TextBox();
            this.crewСheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.crewMemeberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maintenanceCalendar = new System.Windows.Forms.MonthCalendar();
            this.savePlaneButton = new System.Windows.Forms.Button();
            this.addCrewButton = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.writeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.planeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crewMemeberBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.countStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lastActionStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dateStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timeStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.seacrhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортироватьПоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стажToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.crewMemeberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewMemeberBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // planeModel
            // 
            this.planeModel.Location = new System.Drawing.Point(12, 63);
            this.planeModel.Name = "planeModel";
            this.planeModel.Size = new System.Drawing.Size(415, 27);
            this.planeModel.TabIndex = 0;
            this.planeModel.TextChanged += new System.EventHandler(this.planeModel_TextChanged);
            // 
            // passengerRadioButton
            // 
            this.passengerRadioButton.AutoSize = true;
            this.passengerRadioButton.Location = new System.Drawing.Point(10, 211);
            this.passengerRadioButton.Name = "passengerRadioButton";
            this.passengerRadioButton.Size = new System.Drawing.Size(132, 24);
            this.passengerRadioButton.TabIndex = 1;
            this.passengerRadioButton.TabStop = true;
            this.passengerRadioButton.Text = "Пассажирский\r\n";
            this.passengerRadioButton.UseVisualStyleBackColor = true;
            // 
            // CargoRadioButton
            // 
            this.CargoRadioButton.AutoSize = true;
            this.CargoRadioButton.Location = new System.Drawing.Point(10, 241);
            this.CargoRadioButton.Name = "CargoRadioButton";
            this.CargoRadioButton.Size = new System.Drawing.Size(95, 24);
            this.CargoRadioButton.TabIndex = 2;
            this.CargoRadioButton.TabStop = true;
            this.CargoRadioButton.Text = "Грузовой";
            this.CargoRadioButton.UseVisualStyleBackColor = true;
            // 
            // militaryRadioButton
            // 
            this.militaryRadioButton.AutoSize = true;
            this.militaryRadioButton.Location = new System.Drawing.Point(10, 271);
            this.militaryRadioButton.Name = "militaryRadioButton";
            this.militaryRadioButton.Size = new System.Drawing.Size(94, 24);
            this.militaryRadioButton.TabIndex = 3;
            this.militaryRadioButton.TabStop = true;
            this.militaryRadioButton.Text = "Военный";
            this.militaryRadioButton.UseVisualStyleBackColor = true;
            // 
            // seatsTextBox
            // 
            this.seatsTextBox.Location = new System.Drawing.Point(300, 208);
            this.seatsTextBox.Name = "seatsTextBox";
            this.seatsTextBox.Size = new System.Drawing.Size(250, 27);
            this.seatsTextBox.TabIndex = 5;
            this.seatsTextBox.TextChanged += new System.EventHandler(this.seatsTextBox_TextChanged);
            // 
            // loadTextBox
            // 
            this.loadTextBox.Location = new System.Drawing.Point(300, 274);
            this.loadTextBox.Name = "loadTextBox";
            this.loadTextBox.Size = new System.Drawing.Size(250, 27);
            this.loadTextBox.TabIndex = 7;
            this.loadTextBox.TextChanged += new System.EventHandler(this.loadTextBox_TextChanged);
            // 
            // crewСheckedListBox
            // 
            this.crewСheckedListBox.FormattingEnabled = true;
            this.crewСheckedListBox.Location = new System.Drawing.Point(12, 383);
            this.crewСheckedListBox.Name = "crewСheckedListBox";
            this.crewСheckedListBox.Size = new System.Drawing.Size(415, 246);
            this.crewСheckedListBox.TabIndex = 8;
            this.crewСheckedListBox.SelectedIndexChanged += new System.EventHandler(this.crewСheckedListBox_SelectedIndexChanged);
            // 
            // crewMemeberBindingSource
            // 
            this.crewMemeberBindingSource.DataSource = typeof(lab3.Objects.CrewMemeber);
            // 
            // maintenanceCalendar
            // 
            this.maintenanceCalendar.Location = new System.Drawing.Point(590, 383);
            this.maintenanceCalendar.MaxDate = new System.DateTime(2022, 3, 3, 0, 0, 0, 0);
            this.maintenanceCalendar.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.maintenanceCalendar.Name = "maintenanceCalendar";
            this.maintenanceCalendar.ShowToday = false;
            this.maintenanceCalendar.TabIndex = 9;
            // 
            // savePlaneButton
            // 
            this.savePlaneButton.Location = new System.Drawing.Point(590, 61);
            this.savePlaneButton.Name = "savePlaneButton";
            this.savePlaneButton.Size = new System.Drawing.Size(299, 29);
            this.savePlaneButton.TabIndex = 10;
            this.savePlaneButton.Text = "Добавить самолёт";
            this.savePlaneButton.UseVisualStyleBackColor = true;
            this.savePlaneButton.Click += new System.EventHandler(this.savePlaneButton_Click);
            // 
            // addCrewButton
            // 
            this.addCrewButton.Location = new System.Drawing.Point(590, 96);
            this.addCrewButton.Name = "addCrewButton";
            this.addCrewButton.Size = new System.Drawing.Size(299, 29);
            this.addCrewButton.TabIndex = 11;
            this.addCrewButton.Text = "Добавить члена экипажа";
            this.addCrewButton.UseVisualStyleBackColor = true;
            this.addCrewButton.Click += new System.EventHandler(this.addCrewButton_Click);
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(590, 131);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(299, 29);
            this.readButton.TabIndex = 12;
            this.readButton.Text = "Чтение информации из XML";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(590, 166);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(299, 29);
            this.writeButton.TabIndex = 13;
            this.writeButton.Text = "Запись информации в XML\r\n";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Модель самолёта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Количество мест";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Год выпуска";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Грузоподъёмность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(590, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Дата последнего Т. О.";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(300, 240);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker.TabIndex = 19;
            // 
            // planeBindingSource
            // 
            this.planeBindingSource.DataSource = typeof(lab3.Objects.Plane);
            // 
            // crewMemeberBindingSource1
            // 
            this.crewMemeberBindingSource1.DataSource = typeof(lab3.Objects.CrewMemeber);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 672);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(908, 337);
            this.dataGridView1.TabIndex = 20;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(447, 63);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(125, 27);
            this.idTextBox.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(447, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Id";
            // 
            // statusStrip
            // 
            this.statusStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countStripStatusLabel,
            this.lastActionStripStatusLabel2,
            this.dateStripStatusLabel,
            this.timeStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 1009);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(920, 22);
            this.statusStrip.TabIndex = 23;
            this.statusStrip.Text = "statusStrip1";
            // 
            // countStripStatusLabel
            // 
            this.countStripStatusLabel.Name = "countStripStatusLabel";
            this.countStripStatusLabel.Size = new System.Drawing.Size(0, 16);
            // 
            // lastActionStripStatusLabel2
            // 
            this.lastActionStripStatusLabel2.Name = "lastActionStripStatusLabel2";
            this.lastActionStripStatusLabel2.Size = new System.Drawing.Size(0, 16);
            // 
            // dateStripStatusLabel
            // 
            this.dateStripStatusLabel.Name = "dateStripStatusLabel";
            this.dateStripStatusLabel.Size = new System.Drawing.Size(0, 16);
            // 
            // timeStripStatusLabel
            // 
            this.timeStripStatusLabel.Name = "timeStripStatusLabel";
            this.timeStripStatusLabel.Size = new System.Drawing.Size(0, 16);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(920, 28);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seacrhToolStripMenuItem,
            this.сортироватьПоToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(65, 24);
            this.toolStripMenuItem1.Text = "Меню";
            // 
            // seacrhToolStripMenuItem
            // 
            this.seacrhToolStripMenuItem.Name = "seacrhToolStripMenuItem";
            this.seacrhToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.seacrhToolStripMenuItem.Text = "Поиск";
            this.seacrhToolStripMenuItem.Click += new System.EventHandler(this.seacrhToolStripMenuItem_Click);
            // 
            // сортироватьПоToolStripMenuItem
            // 
            this.сортироватьПоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem,
            this.стажToolStripMenuItem});
            this.сортироватьПоToolStripMenuItem.Name = "сортироватьПоToolStripMenuItem";
            this.сортироватьПоToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.сортироватьПоToolStripMenuItem.Text = "Сортировать по";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.ToolStripMenuItem.Text = "Год выпуска";
            this.ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // стажToolStripMenuItem
            // 
            this.стажToolStripMenuItem.Name = "стажToolStripMenuItem";
            this.стажToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.стажToolStripMenuItem.Text = "Дата последнего т.о.";
            this.стажToolStripMenuItem.Click += new System.EventHandler(this.стажToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Авиакомпания";
            // 
            // companyTextBox
            // 
            this.companyTextBox.Location = new System.Drawing.Point(12, 133);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(415, 27);
            this.companyTextBox.TabIndex = 26;
            // 
            // Airport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(932, 763);
            this.Controls.Add(this.companyTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.addCrewButton);
            this.Controls.Add(this.savePlaneButton);
            this.Controls.Add(this.maintenanceCalendar);
            this.Controls.Add(this.crewСheckedListBox);
            this.Controls.Add(this.loadTextBox);
            this.Controls.Add(this.seatsTextBox);
            this.Controls.Add(this.militaryRadioButton);
            this.Controls.Add(this.CargoRadioButton);
            this.Controls.Add(this.passengerRadioButton);
            this.Controls.Add(this.planeModel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Airport";
            this.Text = "Аэропорт";
            this.Load += new System.EventHandler(this.Airport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crewMemeberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewMemeberBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox planeModel;
        private RadioButton passengerRadioButton;
        private RadioButton CargoRadioButton;
        private RadioButton militaryRadioButton;
        private TextBox seatsTextBox;
        private TextBox loadTextBox;
        private CheckedListBox crewСheckedListBox;
        private MonthCalendar maintenanceCalendar;
        private Button savePlaneButton;
        private Button addCrewButton;
        private Button readButton;
        private Button writeButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private BindingSource crewMemeberBindingSource;
        private DateTimePicker dateTimePicker;
        private BindingSource planeBindingSource;
        private BindingSource crewMemeberBindingSource1;
        private DataGridView dataGridView1;
        private TextBox idTextBox;
        private Label label6;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel countStripStatusLabel;
        private ToolStripStatusLabel lastActionStripStatusLabel2;
        private ToolStripStatusLabel dateStripStatusLabel;
        private ToolStripStatusLabel timeStripStatusLabel;
        private System.Windows.Forms.Timer timer1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem seacrhToolStripMenuItem;
        private ToolStripMenuItem сортироватьПоToolStripMenuItem;
        private ToolStripMenuItem ToolStripMenuItem;
        private ToolStripMenuItem стажToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Label label7;
        private TextBox companyTextBox;
    }
}