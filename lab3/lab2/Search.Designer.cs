namespace lab3
{
    partial class Search
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.searchStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.yearSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastMaintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.deleteStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.forwardStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.backStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchStripLabel,
            this.toolStripDropDownButton1,
            this.cleanStripLabel,
            this.deleteStripLabel,
            this.forwardStripLabel,
            this.backStripLabel});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(800, 27);
            this.toolStrip.Stretch = true;
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // searchStripLabel
            // 
            this.searchStripLabel.Name = "searchStripLabel";
            this.searchStripLabel.Size = new System.Drawing.Size(52, 24);
            this.searchStripLabel.Text = "Поиск";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yearSortToolStripMenuItem,
            this.lastMaintenanceToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // yearSortToolStripMenuItem
            // 
            this.yearSortToolStripMenuItem.Name = "yearSortToolStripMenuItem";
            this.yearSortToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.yearSortToolStripMenuItem.Text = "По году выпуска";
            this.yearSortToolStripMenuItem.Click += new System.EventHandler(this.yearSortToolStripMenuItem_Click);
            // 
            // lastMaintenanceToolStripMenuItem
            // 
            this.lastMaintenanceToolStripMenuItem.Name = "lastMaintenanceToolStripMenuItem";
            this.lastMaintenanceToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.lastMaintenanceToolStripMenuItem.Text = "По дате последнего т.о.";
            this.lastMaintenanceToolStripMenuItem.Click += new System.EventHandler(this.lastMaintenanceToolStripMenuItem_Click);
            // 
            // cleanStripLabel
            // 
            this.cleanStripLabel.Name = "cleanStripLabel";
            this.cleanStripLabel.Size = new System.Drawing.Size(73, 24);
            this.cleanStripLabel.Text = "Очистить";
            this.cleanStripLabel.Click += new System.EventHandler(this.cleanStripLabel_Click);
            // 
            // deleteStripLabel
            // 
            this.deleteStripLabel.Name = "deleteStripLabel";
            this.deleteStripLabel.Size = new System.Drawing.Size(65, 24);
            this.deleteStripLabel.Text = "Удалить";
            this.deleteStripLabel.Click += new System.EventHandler(this.deleteStripLabel_Click);
            // 
            // forwardStripLabel
            // 
            this.forwardStripLabel.Name = "forwardStripLabel";
            this.forwardStripLabel.Size = new System.Drawing.Size(60, 24);
            this.forwardStripLabel.Text = "Вперед";
            this.forwardStripLabel.Click += new System.EventHandler(this.forwardStripLabel_Click);
            // 
            // backStripLabel
            // 
            this.backStripLabel.Name = "backStripLabel";
            this.backStripLabel.Size = new System.Drawing.Size(51, 24);
            this.backStripLabel.Text = "Назад";
            this.backStripLabel.Click += new System.EventHandler(this.backStripLabel_Click);
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(12, 49);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(661, 27);
            this.searchtextBox.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 327);
            this.dataGridView1.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(679, 49);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(94, 29);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.toolStrip);
            this.Name = "Search";
            this.Text = "Search";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip;
        private ToolStripLabel searchStripLabel;
        private ToolStripLabel cleanStripLabel;
        private ToolStripLabel deleteStripLabel;
        private ToolStripLabel forwardStripLabel;
        private ToolStripLabel backStripLabel;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem yearSortToolStripMenuItem;
        private ToolStripMenuItem lastMaintenanceToolStripMenuItem;
        private TextBox searchtextBox;
        private DataGridView dataGridView1;
        private Button searchButton;
    }
}