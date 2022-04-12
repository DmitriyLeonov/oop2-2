using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lab2.Objects
{
    [Serializable]
    public class Plane
    {
        public static int id = 0;
        [XmlElement(ElementName ="id")]
        public int Id { get; set ; }
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
        [XmlArray("Crew")]
        [XmlArrayItem("crewmember")]
        public List<CrewMemeber> Crew { get; set; }

        public Plane()
        {
            id++;
            Id = id;
        }
    }
}
