using System;
using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase) =>
        string.Concat(phrase.Split(new[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => char.ToUpper(s.First(char.IsLetter)))
                .ToArray());
}
