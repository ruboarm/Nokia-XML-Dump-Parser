using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "header")]
    public class Header
    {
        [XmlElement(ElementName = "log")]
        public Log Log { get; set; }
    }
}
