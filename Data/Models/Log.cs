using System.Xml.Serialization;

namespace Data.Models
{
    [XmlRoot(ElementName = "log")]
    public class Log
    {
        [XmlAttribute(AttributeName = "dateTime")]
        public DateTime DateTime { get; set; }

        [XmlAttribute(AttributeName = "action")]
        public string Action { get; set; }

        [XmlAttribute(AttributeName = "appInfo")]
        public string AppInfo { get; set; }

        [XmlText]
        public string Text { get; set; }
    }
}
