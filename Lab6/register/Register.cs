using Lab6.auth;
using Lab6.modelsForXml;

namespace Lab6.register;

public class Register
{
    private static XmlParser.XmlParser parser = new XmlParser.XmlParser();

    public static string register(string username, string password)
    {
        var users = parser.deserialize();
        if (users?.usersList?.Find(user => user.username == username) != null)
            return $"Имя пользователя уже существует";
        var newUser = new User();
        newUser.username = username;
        newUser.password = password;
        users?.usersList?.Add(newUser);
        if (users != null) parser.serialize(users);
        CurrentUser.currentUsername = newUser.username;
        return $"Успешная регистрация {newUser.username}";

    }
}