using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Factory
{
    public abstract class PlaneFactory
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public int NumberOfSeats { get; set; }
        public DateTime YearOfManufacture { get; set; }
        public int LoadCapacity { get; set; }
        public DateTime LastMaintenance { get; set; }
    }
}
