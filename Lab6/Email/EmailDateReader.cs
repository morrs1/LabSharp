using Lab6.XmlParser;

namespace Lab6.Email;

public class EmailDateReader
{
    public static void readEmailsWithDate()
    {
        var parser = new XmlParserEmails();
        parser.deserialize().emailsList.ForEach(email => Console.WriteLine(DateTime.Now - email.dateTime));
    }
}