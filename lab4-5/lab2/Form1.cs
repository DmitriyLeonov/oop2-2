using lab4.Builder;
using lab4.Factory;
using lab4.Objects;
using lab4.Prototype;
using System.Data;
using System.Globalization;

namespace lab4
{
    public partial class Airport : Form
    {
        DataTable table = new DataTable();
        private List<Plane> planes = new List<Plane>();
        public List<CrewMemeber> CrewMemebers = new List<CrewMemeber>();
        CaretakerPlanes planeHistory = new CaretakerPlanes();
        Plane allPlanes = new Plane();
        int planesCount = 0;
        Design design;
        public Airport()
        {
            Program.airport = this;
            InitializeComponent();
            table.Columns.Add("Id", typeof(string));
            table.Columns.Add("Тип", typeof(string));
            table.Columns.Add("Модель", typeof(string));
            table.Columns.Add("Количество сидений", typeof(int));
            table.Columns.Add("Год выпуска", typeof(DateTime));
            table.Columns.Add("Грузоподъёмность", typeof(int));
            table.Columns.Add("Дата последнего Т. О.", typeof(DateTime));
            dataGridView1.DataSource = table;
        }

        private void Airport_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            design = Design.GetInstance("Control", "Sitka Text", "ControlText");
            this.Font = new Font(design.Font, 9, FontStyle.Regular);
            this.BackColor = Color.FromName(design.Background);
            this.ForeColor = Color.FromName(design.TextColor);
        }

        private void writeButton_Click(object sender, EventArgs e)
        {
            if (planes != null)
                Serializer.Serialize(planes, "planes.xml");
            if(design != null)
                Serializer.Serialize(design, "design.xml");
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            //planes = Serializer.Deserialize<List<Plane>>("planes.xms");
            foreach (Plane plane in planes)
            {
                table.Rows.Add(plane.Id, plane.Type, plane.Model, plane.NumberOfSeats,
                        plane.YearOfManufacture, plane.LoadCapacity,
                        plane.LastMaintenance);
            }
            
        }

        private void AddBoeingFactory_Click(object sender, EventArgs e)
        {
            int number = 1;
            if (int.TryParse(numberTextBox.Text, out number))
            {
                for(int i = 0; i < number; i++)
                {
                    planesCount++;
                    var plane = new Plane(new BoeingFactory());
                    planes.Add(plane);
                    table.Rows.Add(plane.Id.ToString(), plane.Type, plane.Model, plane.NumberOfSeats,
                            plane.YearOfManufacture, plane.LoadCapacity,
                            plane.LastMaintenance);
                    allPlanes.planes.Add(plane);
                    planeHistory.History.Push(allPlanes.SaveState());
                }
            }
            else
            {
                MessageBox.Show("Введите верное значение");
            }
        }

        private void AddAirbusFactory_Click(object sender, EventArgs e)
        {
            int number = 1;
            if (int.TryParse(numberTextBox.Text, out number))
            {
                for (int i = 0; i < number; i++)
                {
                    planesCount++;
                    var plane = new Plane(new AirbusFactory());
                    planes.Add(plane);
                    table.Rows.Add(plane.Id.ToString(), plane.Type, plane.Model, plane.NumberOfSeats,
                            plane.YearOfManufacture, plane.LoadCapacity,
                            plane.LastMaintenance);
                    allPlanes.planes.Add(plane);
                    planeHistory.History.Push(allPlanes.SaveState());
                }
            }
            else
            {
                MessageBox.Show("Введите верное значение");
            }
        }

        private void AddPlaneBuilder_Click(object sender, EventArgs e)
        {
            int number = 1;
            if (int.TryParse(numberTextBox.Text, out number))
            {
                for (int i = 0; i < number; i++)
                {
                    planesCount++;
                    var plane = new BuilderPlane();
                    plane.PlaneModel().
                        PlaneType().
                        MaxLoad().
                        SeatsNumber().
                        Maintenance().
                        ManufactureYear();
                    //planes.Add(plane);
                    //table.Rows.Add(plane.Id.ToString(), plane.Type, plane.Model, plane.NumberOfSeats,
                    //        plane.YearOfManufacture, plane.LoadCapacity,
                    //        plane.LastMaintenance);
                }
            }
            else
            {
                MessageBox.Show("Введите верное значение");
            }
        }

        private void CloneMethod_Click(object sender, EventArgs e)
        {
            if(planes.Count == 0)
            {
                MessageBox.Show("Нет самолётов для клонирования");
            }
            else
            {
                int number = new Random().Next(0, planes.Count);
                var plane1 = new PlaneClonable((Plane)planes[number]);
                var plane2 = plane1.Clone() as PlaneClonable;
                table.Rows.Add(plane2.Id.ToString(), plane2.Type, plane2.Model, plane2.NumberOfSeats,
                            plane2.YearOfManufacture, plane2.LoadCapacity,
                            plane2.LastMaintenance);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            table.Rows.Clear();
        }

        private void Restore_Click(object sender, EventArgs e)
        {
            allPlanes.RestoreState(planeHistory.History.Pop());
            foreach(var plane in allPlanes.planes)
            {
                table.Rows.Add(plane.Id.ToString(), plane.Type, plane.Model, plane.NumberOfSeats,
                            plane.YearOfManufacture, plane.LoadCapacity,
                            plane.LastMaintenance);
            }
        }

        private void AddExpBoeing_Click(object sender, EventArgs e)
        {
            var plane = new ExperimentalPlane(new BoeingFactory());
            plane.SetType(plane);
            table.Rows.Add(plane.Id.ToString(), plane.Type, plane.Model, plane.NumberOfSeats,
                            plane.YearOfManufacture, plane.LoadCapacity,
                            plane.LastMaintenance);
            allPlanes.planes.Add(plane);
            planeHistory.History.Push(allPlanes.SaveState());
        }

        private void AddExpAirbus_Click(object sender, EventArgs e)
        {
            var plane = new ExperimentalPlane(new AirbusFactory());
            plane.SetType(plane);
            table.Rows.Add(plane.Id.ToString(), plane.Type, plane.Model, plane.NumberOfSeats,
                            plane.YearOfManufacture, plane.LoadCapacity,
                            plane.LastMaintenance);
            allPlanes.planes.Add(plane);
            planeHistory.History.Push(allPlanes.SaveState());
        }
    }
}