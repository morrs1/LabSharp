using System.Xml.Serialization;

namespace Lab6.modelsForXml;

[XmlRoot("Emails")]
public class Emails
{
    [XmlElement("Email")]
    public List<Email>? emailsList { get; set; }
}