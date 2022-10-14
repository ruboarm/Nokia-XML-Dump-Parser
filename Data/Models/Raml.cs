using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "raml", Namespace = "raml20.xsd")]
    public class Raml
    {
        [XmlElement(ElementName = "cmData")]
        public CmData CmData { get; set; }

        [XmlAttribute(AttributeName = "version")]
        public double Version { get; set; }

        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }

        [XmlText]
        public string Text { get; set; }
    }
}
