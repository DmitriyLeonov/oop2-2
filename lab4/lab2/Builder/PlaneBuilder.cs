using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Builder
{
    public static class PlaneBuilder
    {
        public static BuilderPlane PlaneType(this BuilderPlane plane)
        {
            string[] type = new string[] { "Пассажирский", "Грузовой", "Военный" };
            plane.Type = type[new Random().Next(0, 3)];
            return plane;
        }

        public static BuilderPlane PlaneModel(this BuilderPlane plane)
        {
            string[] model = new string[] { "Boeing 747", "Boeing 737", "Boeing 787", "Airbus A350", "Airbus A320", "Airbus A380" };
            plane.Model = model[new Random().Next(0, 6)];
            return plane;
        }

        public static BuilderPlane SeatsNumber(this BuilderPlane plane)
        {
            plane.NumberOfSeats = new Random().Next(4, 600);
            return plane;
        }

        public static BuilderPlane MaxLoad(this BuilderPlane plane)
        {
            plane.LoadCapacity = new Random().Next(100, 350);
            return plane;
        }

        public static BuilderPlane ManufactureYear(this BuilderPlane plane)
        {
            plane.YearOfManufacture = DateTime.Now.AddDays(-(new Random().Next(200, 1300)));
            return plane;
        }

        public static BuilderPlane Maintenance(this BuilderPlane plane)
        {
            plane.LastMaintenance = DateTime.Now.AddDays(-(new Random().Next(1, 199)));
            return plane;
        }
    }
}