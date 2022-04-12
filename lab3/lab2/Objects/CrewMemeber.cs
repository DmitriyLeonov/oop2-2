using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lab3.Objects
{
    [Serializable]
    public class CrewMemeber
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "position")]
        public string Position { get; set; }
        [XmlElement(ElementName = "age")]
        public int Age { get; set; }
        [XmlElement(ElementName = "experience")]
        public int Experience { get; set; }
    }
}
