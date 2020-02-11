using System.Xml.Serialization;

namespace Oop
{
    public class Title
    {
        //[XmlElement]
        public string Value { get; set; }
        [XmlAttribute(AttributeName = "lang")]
        public Language Language { get; set; }
    }
}