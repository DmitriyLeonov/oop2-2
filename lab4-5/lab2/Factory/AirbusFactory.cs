using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Factory
{
    internal class AirbusFactory:PlaneFactory
    {
        private string[] type = new string[] { "Пассажирский", "Грузовой", "Военный" };
        private string[] model = new string[] { "Airbus A350", "Airbus A320", "Airbus A380" };
        public AirbusFactory()
        {
            Model = model[new Random().Next(0, 3)];
            Type = type[new Random().Next(0, 3)];
            NumberOfSeats = new Random().Next(4, 600);
            LoadCapacity = new Random().Next(100, 350);
            YearOfManufacture = DateTime.Now.AddDays(-(new Random().Next(200, 1300)));
            LastMaintenance = DateTime.Now.AddDays(-(new Random().Next(1, 199)));
        }
    }
}
