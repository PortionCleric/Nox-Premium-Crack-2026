using System;
using System.Collections.Generic;
using System.Linq;
public static class StringUtilities
{
    public static string Reverse(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    public static string ToUpperCase(string input)
    {
        return input.ToUpper();
    }
    public static string ToLowerCase(string input)
    {
        return input.ToLower();
    }
    public static bool IsPalindrome(string input)
    {
        string reversed = Reverse(input);
        return string.Equals(input, reversed, StringComparison.OrdinalIgnoreCase);
    }
    public static string RemoveWhitespace(string input)
    {
        return string.Concat(input.Where(c => !char.IsWhiteSpace(c)));
    }
    public static Dictionary<char, int> CharacterFrequency(string input)
    {
        return input.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
    }
    public static string[] SplitByDelimiter(string input, char delimiter)
    {
        return input.Split(delimiter);
    }
    public static string JoinStrings(IEnumerable<string> strings, char delimiter)
    {
        return string.Join(delimiter, strings);
    }
    public static string CapitalizeFirstLetter(string input)
    {
        if (string.IsNullOrEmpty(input)) return input;
        return char.ToUpper(input[0]) + input.Substring(1);
    }
    public static string Truncate(string input, int length)
    {
        if (input.Length <= length) return input;
        return input.Substring(0, length) + "...";
    }
}
