using System.Xml.Serialization;
using Lab6.modelsForXml;

namespace Lab6.XmlParser;

public class XmlParser
{
    private const string FILE_PATH = @"..\..\..\xmls\Users.xml";
    private XmlSerializer _xmlSerializer = new(typeof(Users));

    public void serialize(Users users)
    {
        using (var fileStream = new FileStream(FILE_PATH, FileMode.Create))
        {
            _xmlSerializer.Serialize(fileStream, users);
        }
    }

    
    public Users? deserialize()
    {
        using (var fileStream = new FileStream(FILE_PATH, FileMode.Open))
        {
            return (Users?)_xmlSerializer.Deserialize(fileStream);
        }
    }
}