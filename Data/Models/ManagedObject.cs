using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "managedObject")]
    public class ManagedObject
    {
        [XmlElement(ElementName = "p")]
        public List<P> P { get; set; }

        [XmlElement(ElementName = "list")]
        public List List { get; set; }

        [XmlAttribute(AttributeName = "class")]
        public string Class { get; set; }

        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }

        [XmlAttribute(AttributeName = "distName")]
        public string DistName { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public int Id { get; set; }

        [XmlText]
        public string Text { get; set; }
    }
}
