using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "p")]
    public class P
    {
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlText]
        public string Text { get; set; }
    }
}
