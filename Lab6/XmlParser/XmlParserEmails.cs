using System.Xml.Serialization;
using Lab6.modelsForXml;

namespace Lab6.XmlParser;

public class XmlParserEmails
{
    private const string FILE_PATH = @"..\..\..\xmls\emails.xml";
    private XmlSerializer _xmlSerializer = new(typeof(Emails));

    public void serialize(Emails users)
    {
        using (var fileStream = new FileStream(FILE_PATH, FileMode.Create))
        {
            _xmlSerializer.Serialize(fileStream, users);
        }
    }

    
    public Emails? deserialize()
    {
        using (var fileStream = new FileStream(FILE_PATH, FileMode.Open))
        {
            return (Emails?)_xmlSerializer.Deserialize(fileStream);
        }
    }
}