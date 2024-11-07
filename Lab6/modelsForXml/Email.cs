namespace Lab6.modelsForXml;

public class Email
{
    public string? from { get; set; }
    public string? to { get; set; }
    public string? message { get; set; }
    public DateTime dateTime { get; set; }

    public override string ToString()
    {
        return $"from = {from}, to = {to}, message = {message}";
    }
}