using lab3.Objects;
using System.Data;
using System.Globalization;

namespace lab3
{
    public partial class Airport : Form
    {
        DataTable table = new DataTable();
        public List<Plane> planes = new List<Plane>();
        public List<Plane> searchResult = new List<Plane>();
        public List<CrewMemeber> CrewMemebers = new List<CrewMemeber>();
        List<Plane> orderedPlanes = new List<Plane>();
        string lastAction = "";
        public Airport()
        {
            InitializeComponent();
            Program.airport = this;
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "d MMMM yyyy";
            dateTimePicker.ShowUpDown = true;
            dateTimePicker.MaxDate=DateTime.Today;
            dateTimePicker.MinDate = new DateTime(1903,12,17);
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Авиакомпания", typeof(string));
            table.Columns.Add("Тип", typeof(string));
            table.Columns.Add("Модель", typeof(string));
            table.Columns.Add("Количество сидений", typeof(int));
            table.Columns.Add("Год выпуска", typeof(DateTime));
            table.Columns.Add("Грузоподъёмность", typeof(int));
            table.Columns.Add("Дата последнего Т. О.", typeof(DateTime));
            dataGridView1.DataSource = table;
            this.loadTextBox.TextChanged += new System.EventHandler(this.loadTextBox_TextChanged);
            this.planeModel.TextChanged += new System.EventHandler(this.planeModel_TextChanged);
            this.seatsTextBox.TextChanged += new System.EventHandler(this.seatsTextBox_TextChanged);
            var dateLabel = new ToolStripLabel();
            var countLabel = new ToolStripLabel();
            var timeLabel = new ToolStripLabel();
            var lastActionLabel = new ToolStripLabel();
        }

        private void Airport_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            
            
            for (int i = 0; i < planes.Count; i++)
            {
                
            }
            
        }

        private void addCrewButton_Click(object sender, EventArgs e)
        {
            CrewForm crewForm = new CrewForm();
            crewForm.FormClosed += CrewForm_Closed;
            crewForm.ShowDialog();
            lastAction = "Добавление члена экипажа";
        }

        private void CrewForm_Closed(object sender, FormClosedEventArgs e)
        {
            crewСheckedListBox.Items.Clear();
            foreach(var item in CrewMemebers)
            {
                crewСheckedListBox.Items.Add(item.Name);
            }
            crewСheckedListBox.Refresh();
        }

        private void savePlaneButton_Click(object sender, EventArgs e)
        {
            try
            {
                Plane plane = new Plane();
                if(planeModel.Text == "") { 
                    throw new Exception("Введите модель самолёта"); 
                }
                plane.Model = planeModel.Text;
                if (passengerRadioButton.Checked)
                {
                    plane.Type = passengerRadioButton.Text;
                }
                else if (CargoRadioButton.Checked)
                {
                    plane.Type = CargoRadioButton.Text;
                }
                else if (CargoRadioButton.Checked)
                {
                    plane.Type = CargoRadioButton.Text;
                }
                else
                {
                    throw new Exception("Выберите тип самолёта");
                }
                plane.Company = companyTextBox.Text;
                plane.NumberOfSeats = int.Parse(seatsTextBox.Text);
                if (maintenanceCalendar.SelectionStart > DateTime.Now ||
                    maintenanceCalendar.SelectionStart < dateTimePicker.Value)
                {
                    throw new Exception("Неверно введена дата обслуживания");
                }
                plane.LastMaintenance = maintenanceCalendar.SelectionStart;
                var crew = crewСheckedListBox.CheckedItems;
                List<CrewMemeber> crews = new List<CrewMemeber>();
                foreach (CrewMemeber item in CrewMemebers)
                {
                    if (crew.Contains(item.Name))
                    {
                        crews.Add(item);
                    }
                }
                plane.Id = int.Parse(idTextBox.Text);
                plane.Crew = crews;
                plane.YearOfManufacture = dateTimePicker.Value;
                plane.LoadCapacity = int.Parse(loadTextBox.Text);
                planes.Add(plane);
                table.Rows.Add(plane.Id, plane.Company, plane.Type, plane.Model, plane.NumberOfSeats,
                        plane.YearOfManufacture, plane.LoadCapacity,
                        plane.LastMaintenance);
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = string.Empty;
                    }
                }
                lastAction = "Добавление самолёта";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void writeButton_Click(object sender, EventArgs e)
        {
            Serializer.Serialize(planes, "planes.xml");
            Serializer.Serialize(CrewMemebers, "crew.xml");
            lastAction = "Запись в файл";
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            table.Rows.Clear();
            crewСheckedListBox.Items.Clear();
            planes = Serializer.Deserialize<List<Plane>>("planes.xml");
            CrewMemebers = Serializer.Deserialize<List<CrewMemeber>>("crew.xml");
            foreach (Plane plane in planes)
            {
                table.Rows.Add(plane.Id, plane.Company, plane.Type, plane.Model, plane.NumberOfSeats,
                        plane.YearOfManufacture, plane.LoadCapacity,
                        plane.LastMaintenance);
            }
            foreach(CrewMemeber crew in CrewMemebers)
            {
                crewСheckedListBox.Items.Add(crew.Name);
            }
            lastAction = "Чтение из файла";
        }

        private void planeModel_TextChanged(object sender, EventArgs e)
        {
            if(planeModel.Text.Length > 4 || planeModel.Text.Length == 0){
                planeModel.BackColor = Color.White;
            }
            else
            {
                planeModel.BackColor = Color.Red;
            }
        }

        private void seatsTextBox_TextChanged(object sender, EventArgs e)
        {
            int seats = 1;
            if (int.TryParse(seatsTextBox.Text,out seats))
            {
                if(seats > 1000 || seats <= 0)
                {
                    seatsTextBox.BackColor = Color.Red;
                }
                else { 
                    seatsTextBox.BackColor = Color.White;
                }
            }
            else
            {
                seatsTextBox.BackColor = Color.Red;
            }
        }

        private void loadTextBox_TextChanged(object sender, EventArgs e)
        {
            int load = 0;
            if (int.TryParse(loadTextBox.Text, out load))
            {
                if (load > 380 || load < 0)
                {
                    loadTextBox.BackColor = Color.Red;
                }
                else
                {
                    loadTextBox.BackColor = Color.White;
                }
            }
            else
            {
                loadTextBox.BackColor = Color.Red;
            }
        }

        private void crewСheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countStripStatusLabel.Text = planes.Count.ToString();
            lastActionStripStatusLabel2.Text = lastAction;
            dateStripStatusLabel.Text = DateTime.Now.ToLongDateString();
            timeStripStatusLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tv 1.0\nЛеонов Дмитрий");
        }

        private void seacrhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.ShowDialog();
            lastAction = "Поиск";
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orderedPlanes = (from p in planes orderby p.YearOfManufacture select p).ToList<Plane>();
            table.Clear();
            foreach (Plane plane in orderedPlanes)
            {
                table.Rows.Add(plane.Id, plane.Company, plane.Type, plane.Model, plane.NumberOfSeats,
                        plane.YearOfManufacture, plane.LoadCapacity,
                        plane.LastMaintenance);
            }
            lastAction = "Сортировка по году выпустка";
        }

        private void стажToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orderedPlanes = (from p in planes orderby p.LastMaintenance select p).ToList<Plane>();
            table.Clear();
            foreach (Plane plane in orderedPlanes)
            {
                table.Rows.Add(plane.Id, plane.Company, plane.Type, plane.Model, plane.NumberOfSeats,
                        plane.YearOfManufacture, plane.LoadCapacity,
                        plane.LastMaintenance);
            }
            lastAction = "Сортировка по дате последнего т.о.";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Serializer.Serialize(orderedPlanes, "orderedPlanes.xml");
            lastAction = "Сохранение сортированных самолётов";
        }
    }
}