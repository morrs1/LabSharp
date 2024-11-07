using Lab6.auth;
using Lab6.XmlParser;

namespace Lab6.Email;

public class EmailSender
{
    private static XmlParser.XmlParser userParser = new XmlParser.XmlParser();
    private static XmlParserEmails emailParser = new XmlParserEmails();
    
    public static string sendEmail(string to, string message)
    {
        if (userParser.deserialize().usersList.Find(user => user.username == to) != null)
        {
            var from = CurrentUser.currentUsername;
            var newEmail = new modelsForXml.Email
            {
                from = from,
                to = to,
                message = message
            };
            var emails = emailParser.deserialize();
            emails?.emailsList?.Add(newEmail);
            if (emails != null) emailParser.serialize(emails);
            return "Сообщение отправилось успешно"; 
        }

        return "Такого пользователя не существует";

    }
}