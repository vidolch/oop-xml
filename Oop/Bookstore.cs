using System.Collections.Generic;
using System.Xml.Serialization;

namespace Oop
{
    [XmlRoot(ElementName = "bookstore")]
    public class Bookstore
    {
        [XmlElement(ElementName = "book")]
        public Book[] Books { get; set; }
    }
}