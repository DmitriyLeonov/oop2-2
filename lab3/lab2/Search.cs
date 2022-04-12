using lab3.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Search : Form
    {
        private List<Plane> planes = new List<Plane>();
        DataTable table = new DataTable();
        List<Plane> orderedPlanes = new List<Plane>();
        List<string> searchHistory = new List<string>();
        int currentSearch;
        public Search()
        {
            InitializeComponent();
            planes = Program.airport.planes;
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Авиакомпания", typeof(string));
            table.Columns.Add("Тип", typeof(string));
            table.Columns.Add("Модель", typeof(string));
            table.Columns.Add("Количество сидений", typeof(int));
            table.Columns.Add("Год выпуска", typeof(DateTime));
            table.Columns.Add("Грузоподъёмность", typeof(int));
            table.Columns.Add("Дата последнего Т. О.", typeof(DateTime));
            dataGridView1.DataSource = table;
            currentSearch = -1;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            table.Clear();
            Program.airport.searchResult.Clear();
            int count;
            searchHistory.Add(searchtextBox.Text);
            currentSearch++;
            Regex regex = new Regex(@"" + searchtextBox.Text);
            MatchCollection matches;
            foreach (var plane in planes)
            {
                count = 0;
                matches = regex.Matches(plane.Company);
                count += matches.Count;
                matches = regex.Matches(plane.Type);
                count += matches.Count;
                matches = regex.Matches(plane.LoadCapacity.ToString());
                count += matches.Count;
                matches = regex.Matches(plane.NumberOfSeats.ToString());
                count += matches.Count;
                if (count > 0)
                {
                    table.Rows.Add(plane.Id, plane.Company, plane.Type, plane.Model, plane.NumberOfSeats,
                        plane.YearOfManufacture, plane.LoadCapacity,
                        plane.LastMaintenance);
                    Program.airport.searchResult.Add(plane);
                }
            }
            dataGridView1.Refresh();
        }

        private void cleanStripLabel_Click(object sender, EventArgs e)
        {
            table.Clear();
        }

        private void deleteStripLabel_Click(object sender, EventArgs e)
        {
            searchtextBox.Text = "";
        }

        private void lastMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orderedPlanes = (from p in planes orderby p.LastMaintenance select p).ToList<Plane>();
            table.Clear();
            foreach (Plane plane in orderedPlanes)
            {
                table.Rows.Add(plane.Id, plane.Company, plane.Type, plane.Model, plane.NumberOfSeats,
                        plane.YearOfManufacture, plane.LoadCapacity,
                        plane.LastMaintenance);
            }
        }

        private void yearSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orderedPlanes = (from p in planes orderby p.YearOfManufacture select p).ToList<Plane>();
            table.Clear();
            foreach (Plane plane in orderedPlanes)
            {
                table.Rows.Add(plane.Id, plane.Company, plane.Type, plane.Model, plane.NumberOfSeats,
                        plane.YearOfManufacture, plane.LoadCapacity,
                        plane.LastMaintenance);
            }
        }

        private void backStripLabel_Click(object sender, EventArgs e)
        {
            if (currentSearch == searchHistory.Count)
                currentSearch--;
            if (currentSearch >= 0)
            {
                searchtextBox.Text = searchHistory.ElementAt(currentSearch);
                currentSearch--;
            }
        }

        private void forwardStripLabel_Click(object sender, EventArgs e)
        {
            if (currentSearch <= searchHistory.Count - 1 && currentSearch >= 0)
            {
                searchtextBox.Text = searchHistory.ElementAt(currentSearch);
                currentSearch++;
            }
            if (currentSearch < 0)
            {
                currentSearch = 0;
            }
        }
    }
}
