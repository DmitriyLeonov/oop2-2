using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lab3.Objects
{
    [Serializable]
    public class Plane
    {
        [Required]
        [Id]
        [XmlElement(ElementName ="id")]
        public int Id { get; set ; }
        [Required]
        [StringLength(20, MinimumLength = 3)]
        [XmlElement(ElementName = "company")]
        public string Company { get; set ; }
        [Required]
        [XmlElement(ElementName = "type")]
        public string Type { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3)]

        [XmlElement(ElementName = "model")]
        public string Model { get; set; }
        [Required]
        [Range(1, 700)]
        [XmlElement(ElementName = "numberofseats")]
        public int NumberOfSeats { get; set; }
        [Required]
        [XmlElement(ElementName = "yearofmanufacture")]
        public DateTime YearOfManufacture { get; set; }
        [Required]
        [Range(1, 400)]
        [XmlElement(ElementName = "loadcapacity")]
        public int LoadCapacity { get; set; }
        [Required]
        [XmlElement(ElementName = "lastmaintenance")]
        public DateTime LastMaintenance { get; set; }
        [Required]
        [XmlArray("Crew")]
        [XmlArrayItem("crewmember")]
        public List<CrewMemeber> Crew { get; set; }
    }
}
