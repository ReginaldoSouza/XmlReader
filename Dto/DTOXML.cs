using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlReader.Dto
{
    public class DTOXML
    {
        public string Element { get; set; } = "";
        public string Value { get; set; } = "";
        public string EndElement { get; set; } = "";
        public string Path { get; set; } = "";
    }
}
