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
        public string Year { get; set; }
        public string Price { get; set; }
        [XmlAttribute]
        public Category Category { get; set; }
        public void PrintInfo()
        {
            Console.WriteLine(Title.Value);
            Console.WriteLine(Author);
        }
    }
}