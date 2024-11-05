using System;
using System.Collections;
using System.Collections.Generic;

public class WordEnumerator : IEnumerator<string>
{
    private string[] _words;
    private int _position = -1;

    public WordEnumerator(string[] words)
    {
        _words = words;
        Array.Sort(_words, (x, y) => x.Length.CompareTo(y.Length));
    }

    public string Current => _words[_position];

    object IEnumerator.Current => Current;

    public bool MoveNext()
    {
        _position++;
        return (_position < _words.Length);
    }

    public void Reset()
    {
        _position = -1;
    }

    public void Dispose() { }
}

public class WordCollection : IEnumerable<string>
{
    private string _input;

    public WordCollection(string input)
    {
        _input = input;
    }

    public IEnumerator<string> GetEnumerator()
    {
        string[] words = _input.Split(new[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        return new WordEnumerator(words);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public string GetLongestWord()
    {
        string longestWord = string.Empty;
        foreach (var word in this)
        {
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }
        return longestWord;
    }
}

