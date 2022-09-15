using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsFormsApp3
{
    public static class Lango
    {

        [XmlRoot("lang")]
        public class Lang
        {
            [XmlAttribute("name")]
            public string Name { get; set; }
            [XmlElement("appeared")]
            public string Appeared { get; set; }
            [XmlElement("creator")]
            public string Creator { get; set; }
            public override string ToString()
            {
                return $"{nameof(Appeared)}:{Appeared}; " +
                       $"{nameof(Creator)}:{Creator}; " +
                       $"{nameof(Name)}:{Name}; ";
            }
        }
    }
}
