//Console.WriteLine("Введите строку:");
//string input = Console.ReadLine();

//WordCollection words = new WordCollection(input);
//string longestWord = words.GetLongestWord();

//Console.WriteLine("Самое длинное имя: " + longestWord);

Console.WriteLine("Введите строку:");
string input = Console.ReadLine();

WordCollection1 words = new WordCollection1(input);
string longestWord = words.GetLongestWord();

Console.WriteLine("Самое длинное имя: " + longestWord);