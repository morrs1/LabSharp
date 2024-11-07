namespace Lab6.auth;

public class Auth
{
    private static XmlParser.XmlParser parser = new XmlParser.XmlParser();

    public static string login(string username, string password)
    {
        if (parser.deserialize()?.usersList?.Find(user => user.username == username && user.password == password) ==
            null) return $"Неуспешная аутентификация: неверные данные {username} {password}";
        CurrentUser.currentUsername = username;
        return $"Успешная аутентификация под пользователем: {username} {password}";

    }
}