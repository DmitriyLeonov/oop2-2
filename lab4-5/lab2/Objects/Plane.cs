using lab4.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lab4.Objects
{
    [Serializable]
    public class Plane
    {
        [XmlElement(ElementName ="id")]
        public Guid Id { get; set ; }
        [XmlElement(ElementName = "type")]
        public string Type { get; set; }
        [XmlElement(ElementName = "model")]
        public string Model { get; set; }
        [XmlElement(ElementName = "numberofseats")]
        public int NumberOfSeats { get; set; }
        [XmlElement(ElementName = "yearofmanufacture")]
        public DateTime YearOfManufacture { get; set; }
        [XmlElement(ElementName = "loadcapacity")]
        public int LoadCapacity { get; set; }
        [XmlElement(ElementName = "lastmaintenance")]
        public DateTime LastMaintenance { get; set; }
        public Plane()
        {

        }

        public Plane (PlaneFactory factory)
        {
            Id = Guid.NewGuid();
            Type = factory.Type;
            Model = factory.Model;
            NumberOfSeats = factory.NumberOfSeats;
            YearOfManufacture = factory.YearOfManufacture;
            LastMaintenance = factory.LastMaintenance;
            LoadCapacity = factory.LoadCapacity;
        }

        public List<Plane> planes = new List<Plane>();
        public void RestoreState(MementoPlaneList planeList)
        {
            planes = planeList.planes;
        }
        public MementoPlaneList SaveState()
        {
            return new MementoPlaneList(planes);
        }
    }
}
