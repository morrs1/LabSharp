using System;
using System.Collections.Generic;

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

    public string GetLongestWord()
    {
        string longestWord = string.Empty;
        foreach (var word in GetWordsSortedByLength())
        {
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }
        return longestWord;
    }
}