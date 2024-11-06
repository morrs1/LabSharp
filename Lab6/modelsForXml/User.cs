namespace Lab6.modelsForXml;

public class User
{
    public string? username { get; set; }
    public string? password { get; set; }

    public override string ToString()
    {
        return $"username = {username}, password = {password}";
    }
}