using System.Xml.Serialization;

namespace Lab6.modelsForXml;

[XmlRoot("Users")]
public class Users
{
    [XmlElement("User")]
    public List<User>? usersList { get; set; }
}