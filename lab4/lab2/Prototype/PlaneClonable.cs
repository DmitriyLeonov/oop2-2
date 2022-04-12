using lab4.Builder;
using lab4.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Prototype
{
    internal class PlaneClonable : ICloneable
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
        public int NumberOfSeats { get; set; }
        public DateTime YearOfManufacture { get; set; }
        public int LoadCapacity { get; set; }
        public DateTime LastMaintenance { get; set; }

        public PlaneClonable(Plane plane)
        {
            Id = plane.Id;
            Type = plane.Type;
            Model = plane.Model;
            NumberOfSeats = plane.NumberOfSeats;
            LoadCapacity = plane.LoadCapacity;
            YearOfManufacture = plane.YearOfManufacture;
            LastMaintenance = plane.LastMaintenance;
        }

        public PlaneClonable(BuilderPlane plane)
        {
            Id = plane.Id;
            Type = plane.Type;
            Model = plane.Model;
            NumberOfSeats = plane.NumberOfSeats;
            LoadCapacity = plane.LoadCapacity;
            YearOfManufacture = plane.YearOfManufacture;
            LastMaintenance = plane.LastMaintenance;
        }

        public object Clone()
        {
            //var newType = Type.Clone();
            //var newModel = Model.Clone();
            
            //var newPlane = new PlaneClonable();
            //return newPlane;
            return MemberwiseClone();
        }
    }
}
