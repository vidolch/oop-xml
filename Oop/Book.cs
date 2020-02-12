using System;
using System.Xml.Serialization;

namespace Oop
{
    [XmlType(TypeName = "book")]
    public class Book
    {
        public Title Title { get; set; }
        [XmlElement(ElementName = "author")]
        public string Author { get; set; }
        [XmlElement(ElementName = "year")]
        public string Year { get; set; }
        [XmlElement(ElementName = "price")]
        public string Price { get; set; }
        [XmlAttribute(AttributeName = "category")]
        public string Category { get; set; }
    }
}