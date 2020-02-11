using System.IO;
using System.Xml.Serialization;

namespace Oop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serializer = new XmlSerializer(typeof(Bookstore));

            using (var reader = new FileStream("bookstore.xml", FileMode.Open))
            {
                var bookstore = (Bookstore)serializer.Deserialize(reader);
            }
        }
    }
}
