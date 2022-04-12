namespace lab4
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
            this.crewMemeberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.readButton = new System.Windows.Forms.Button();
            this.writeButton = new System.Windows.Forms.Button();
            this.planeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crewMemeberBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddBoeingFactory = new System.Windows.Forms.Button();
            this.AddAirbusFactory = new System.Windows.Forms.Button();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddPlaneBuilder = new System.Windows.Forms.Button();
            this.CloneMethod = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Restore = new System.Windows.Forms.Button();
            this.AddExpAirbus = new System.Windows.Forms.Button();
            this.AddExpBoeing = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.crewMemeberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewMemeberBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // crewMemeberBindingSource
            // 
            this.crewMemeberBindingSource.DataSource = typeof(lab4.Objects.CrewMemeber);
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(12, 150);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(333, 29);
            this.readButton.TabIndex = 12;
            this.readButton.Text = "Чтение информации из XML";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(12, 185);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(333, 29);
            this.writeButton.TabIndex = 13;
            this.writeButton.Text = "Запись информации в XML\r\n";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // planeBindingSource
            // 
            this.planeBindingSource.DataSource = typeof(lab4.Objects.Plane);
            // 
            // crewMemeberBindingSource1
            // 
            this.crewMemeberBindingSource1.DataSource = typeof(lab4.Objects.CrewMemeber);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(908, 422);
            this.dataGridView1.TabIndex = 20;
            // 
            // AddBoeingFactory
            // 
            this.AddBoeingFactory.Location = new System.Drawing.Point(12, 45);
            this.AddBoeingFactory.Name = "AddBoeingFactory";
            this.AddBoeingFactory.Size = new System.Drawing.Size(333, 29);
            this.AddBoeingFactory.TabIndex = 21;
            this.AddBoeingFactory.Text = "Добавит Boeing(фабрика)";
            this.AddBoeingFactory.UseVisualStyleBackColor = true;
            this.AddBoeingFactory.Click += new System.EventHandler(this.AddBoeingFactory_Click);
            // 
            // AddAirbusFactory
            // 
            this.AddAirbusFactory.Location = new System.Drawing.Point(12, 80);
            this.AddAirbusFactory.Name = "AddAirbusFactory";
            this.AddAirbusFactory.Size = new System.Drawing.Size(333, 29);
            this.AddAirbusFactory.TabIndex = 22;
            this.AddAirbusFactory.Text = "Добавить Airbus(фабрика)";
            this.AddAirbusFactory.UseVisualStyleBackColor = true;
            this.AddAirbusFactory.Click += new System.EventHandler(this.AddAirbusFactory_Click);
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(12, 12);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(91, 27);
            this.numberTextBox.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Количество генерируемых самолётов";
            // 
            // AddPlaneBuilder
            // 
            this.AddPlaneBuilder.Location = new System.Drawing.Point(12, 115);
            this.AddPlaneBuilder.Name = "AddPlaneBuilder";
            this.AddPlaneBuilder.Size = new System.Drawing.Size(333, 29);
            this.AddPlaneBuilder.TabIndex = 25;
            this.AddPlaneBuilder.Text = "Добавить самолёт (Builder)";
            this.AddPlaneBuilder.UseVisualStyleBackColor = true;
            this.AddPlaneBuilder.Click += new System.EventHandler(this.AddPlaneBuilder_Click);
            // 
            // CloneMethod
            // 
            this.CloneMethod.Location = new System.Drawing.Point(12, 220);
            this.CloneMethod.Name = "CloneMethod";
            this.CloneMethod.Size = new System.Drawing.Size(333, 29);
            this.CloneMethod.TabIndex = 26;
            this.CloneMethod.Text = "Клонирование";
            this.CloneMethod.UseVisualStyleBackColor = true;
            this.CloneMethod.Click += new System.EventHandler(this.CloneMethod_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(456, 45);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(417, 29);
            this.Delete.TabIndex = 27;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Restore
            // 
            this.Restore.Location = new System.Drawing.Point(456, 80);
            this.Restore.Name = "Restore";
            this.Restore.Size = new System.Drawing.Size(417, 29);
            this.Restore.TabIndex = 28;
            this.Restore.Text = "Восстановить";
            this.Restore.UseVisualStyleBackColor = true;
            this.Restore.Click += new System.EventHandler(this.Restore_Click);
            // 
            // AddExpAirbus
            // 
            this.AddExpAirbus.Location = new System.Drawing.Point(456, 115);
            this.AddExpAirbus.Name = "AddExpAirbus";
            this.AddExpAirbus.Size = new System.Drawing.Size(417, 29);
            this.AddExpAirbus.TabIndex = 29;
            this.AddExpAirbus.Text = "Добавить экспериментальный Airbus";
            this.AddExpAirbus.UseVisualStyleBackColor = true;
            this.AddExpAirbus.Click += new System.EventHandler(this.AddExpAirbus_Click);
            // 
            // AddExpBoeing
            // 
            this.AddExpBoeing.Location = new System.Drawing.Point(456, 150);
            this.AddExpBoeing.Name = "AddExpBoeing";
            this.AddExpBoeing.Size = new System.Drawing.Size(417, 29);
            this.AddExpBoeing.TabIndex = 30;
            this.AddExpBoeing.Text = "Добавить экспериментальный Boeing";
            this.AddExpBoeing.UseVisualStyleBackColor = true;
            this.AddExpBoeing.Click += new System.EventHandler(this.AddExpBoeing_Click);
            // 
            // Airport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(932, 730);
            this.Controls.Add(this.AddExpBoeing);
            this.Controls.Add(this.AddExpAirbus);
            this.Controls.Add(this.Restore);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.CloneMethod);
            this.Controls.Add(this.AddPlaneBuilder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.AddAirbusFactory);
            this.Controls.Add(this.AddBoeingFactory);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.readButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
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
        private Button readButton;
        private Button writeButton;
        private BindingSource crewMemeberBindingSource;
        private BindingSource planeBindingSource;
        private BindingSource crewMemeberBindingSource1;
        private DataGridView dataGridView1;
        private Button AddBoeingFactory;
        private Button AddAirbusFactory;
        private TextBox numberTextBox;
        private Label label1;
        private Button AddPlaneBuilder;
        private Button CloneMethod;
        private Button Delete;
        private Button Restore;
        private Button AddExpAirbus;
        private Button AddExpBoeing;
    }
}