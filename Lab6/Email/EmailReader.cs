using Lab6.auth;
using Lab6.XmlParser;

namespace Lab6.Email;

public class EmailReader
{
    private static XmlParser.XmlParser userParser = new XmlParser.XmlParser();
    private static XmlParserEmails emailParser = new XmlParserEmails();
    
    public static List<modelsForXml.Email>? readEmail()
    {
        return emailParser.deserialize()?.emailsList?.FindAll(email => email.to == CurrentUser.currentUsername);

    }
}