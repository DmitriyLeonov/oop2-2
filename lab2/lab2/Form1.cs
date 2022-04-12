using lab2.Objects;
using System.Data;
using System.Globalization;

namespace lab2
{
    public partial class Airport : Form
    {
        DataTable table = new DataTable();
        private List<Plane> planes = new List<Plane>();
        public List<CrewMemeber> CrewMemebers = new List<CrewMemeber>();
        public Airport()
        {
            Program.airport = this;
            InitializeComponent();
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "d MMMM yyyy";
            dateTimePicker.ShowUpDown = true;
            dateTimePicker.MaxDate=DateTime.Today;
            dateTimePicker.MinDate = new DateTime(1903,12,17);
            table.Columns.Add("Id", typeof(int));
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
                plane.Crew = crews;
                plane.YearOfManufacture = dateTimePicker.Value;
                plane.LoadCapacity = int.Parse(loadTextBox.Text);
                planes.Add(plane);
                table.Rows.Add(plane.Id, plane.Type, plane.Model, plane.NumberOfSeats,
                        plane.YearOfManufacture, plane.LoadCapacity,
                        plane.LastMaintenance);
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = string.Empty;
                    }
                }
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
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            planes = Serializer.Deserialize<List<Plane>>("planes.xml");
            CrewMemebers = Serializer.Deserialize<List<CrewMemeber>>("crew.xml");
            foreach (Plane plane in planes)
            {
                table.Rows.Add(plane.Id, plane.Type, plane.Model, plane.NumberOfSeats,
                        plane.YearOfManufacture, plane.LoadCapacity,
                        plane.LastMaintenance);
            }
            foreach(CrewMemeber crew in CrewMemebers)
            {
                crewСheckedListBox.Items.Add(crew.Name);
            }
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
    }
}