using System;

public class WordCollection1
{
    private string _input;

    public WordCollection1(string input)
    {
        _input = input;
    }

    public IEnumerable<string> GetWordsSortedByLength()
    {
        string[] words = _input.Split(new[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(words, (x, y) => x.Length.CompareTo(y.Length));

        foreach (var word in words)
        {
            yield return word;
        }
    }
}

