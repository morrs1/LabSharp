//Console.WriteLine("Введите строку:");
//string input = Console.ReadLine();

//WordCollection words = new WordCollection(input);
//foreach (var word in words)
//{
//    Console.WriteLine(word);
//}

Console.WriteLine("Введите строку:");
string input = Console.ReadLine();

WordCollection1 words = new WordCollection1(input);
foreach (var word in words.GetWordsSortedByLength())
{
    Console.WriteLine(word);
}