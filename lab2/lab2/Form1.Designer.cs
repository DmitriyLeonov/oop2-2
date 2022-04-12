namespace lab2
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
            ((System.ComponentModel.ISupportInitialize)(this.crewMemeberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewMemeberBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.passengerRadioButton.Location = new System.Drawing.Point(12, 126);
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
            this.CargoRadioButton.Location = new System.Drawing.Point(12, 156);
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
            this.militaryRadioButton.Location = new System.Drawing.Point(12, 186);
            this.militaryRadioButton.Name = "militaryRadioButton";
            this.militaryRadioButton.Size = new System.Drawing.Size(94, 24);
            this.militaryRadioButton.TabIndex = 3;
            this.militaryRadioButton.TabStop = true;
            this.militaryRadioButton.Text = "Военный";
            this.militaryRadioButton.UseVisualStyleBackColor = true;
            // 
            // seatsTextBox
            // 
            this.seatsTextBox.Location = new System.Drawing.Point(302, 123);
            this.seatsTextBox.Name = "seatsTextBox";
            this.seatsTextBox.Size = new System.Drawing.Size(250, 27);
            this.seatsTextBox.TabIndex = 5;
            this.seatsTextBox.TextChanged += new System.EventHandler(this.seatsTextBox_TextChanged);
            // 
            // loadTextBox
            // 
            this.loadTextBox.Location = new System.Drawing.Point(302, 189);
            this.loadTextBox.Name = "loadTextBox";
            this.loadTextBox.Size = new System.Drawing.Size(250, 27);
            this.loadTextBox.TabIndex = 7;
            this.loadTextBox.TextChanged += new System.EventHandler(this.loadTextBox_TextChanged);
            // 
            // crewСheckedListBox
            // 
            this.crewСheckedListBox.FormattingEnabled = true;
            this.crewСheckedListBox.Location = new System.Drawing.Point(12, 244);
            this.crewСheckedListBox.Name = "crewСheckedListBox";
            this.crewСheckedListBox.Size = new System.Drawing.Size(415, 246);
            this.crewСheckedListBox.TabIndex = 8;
            this.crewСheckedListBox.SelectedIndexChanged += new System.EventHandler(this.crewСheckedListBox_SelectedIndexChanged);
            // 
            // crewMemeberBindingSource
            // 
            this.crewMemeberBindingSource.DataSource = typeof(lab2.Objects.CrewMemeber);
            // 
            // maintenanceCalendar
            // 
            this.maintenanceCalendar.Location = new System.Drawing.Point(590, 283);
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
            this.label2.Location = new System.Drawing.Point(170, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Количество мест";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Год выпуска";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Грузоподъёмность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(590, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Дата последнего Т. О.";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(302, 155);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker.TabIndex = 19;
            // 
            // planeBindingSource
            // 
            this.planeBindingSource.DataSource = typeof(lab2.Objects.Plane);
            // 
            // crewMemeberBindingSource1
            // 
            this.crewMemeberBindingSource1.DataSource = typeof(lab2.Objects.CrewMemeber);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 530);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(908, 337);
            this.dataGridView1.TabIndex = 20;
            // 
            // Airport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 909);
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
            this.Name = "Airport";
            this.Text = "Аэропорт";
            this.Load += new System.EventHandler(this.Airport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crewMemeberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewMemeberBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}