using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "cmData")]
    public class CmData
    {
        [XmlElement(ElementName = "header")]
        public Header Header { get; set; }

        [XmlElement(ElementName = "managedObject")]
        public List<ManagedObject> ManagedObjects { get; set; }

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlText]
        public string Text { get; set; }
    }
}
