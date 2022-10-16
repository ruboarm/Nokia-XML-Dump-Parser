using System.Net;
using System.Xml.Schema;
using System.Xml;
using Data.Models;
using System.Xml.Serialization;

namespace ConsoleApp
{
    internal class Serialization
    {
        // Display any validation errors.
        public static void ValidationCallBack(object sender, ValidationEventArgs e)
        {
            Console.WriteLine("Validation Error: {0}", e.Message);
        }

        // Setuo settings for XML reader
        public static XmlReaderSettings XmlReaderSettings()
        {
            // Initialize XmlResolver for DTD
            XmlUrlResolver resolver = new XmlUrlResolver();
            resolver.Credentials = CredentialCache.DefaultCredentials;

            // Set the validation settings (Important DTD for untrasted XML files).
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.DtdProcessing = DtdProcessing.Parse;
            settings.ValidationType = ValidationType.DTD;
            settings.Async = true;
            settings.XmlResolver = resolver;
            settings.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);

            return settings;
        }


        public static Raml DeserializeXML(FileStream fileStream)
        {
            // Set the validation settings (Important DTD for untrasted XML files).
            XmlReaderSettings settings = XmlReaderSettings();

            // Deserialize XML file
            var serializer = new XmlSerializer(typeof(Raml));
            var xmlDocument = (Raml)serializer.Deserialize(XmlReader.Create(fileStream, settings));

            return xmlDocument;
        }
    }
}
