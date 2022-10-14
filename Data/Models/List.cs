using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "list")]
    public class List
    {
        [XmlElement(ElementName = "p")]
        public List<string> P { get; set; }

        [XmlElement(ElementName = "item")]
        public List<Item> Items { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlText]
        public string Text { get; set; }
    }
}
