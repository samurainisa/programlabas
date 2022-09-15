using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static WindowsFormsApp3.Lango;

namespace WindowsFormsApp3
{

        [XmlRoot("languages")]
        public class Languages
        {
            [XmlElement("lang")]
            public List<Lang> Langs { get; set; }
        }
}
