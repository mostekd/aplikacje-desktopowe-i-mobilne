using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "Jabłko";
        string reversed = ReverseString(input);
        Console.WriteLine(reversed);
    }

    static string ReverseString(string s)
    {
        if (s.Length <= 1)
            return s;
        return s[s.Length - 1] + ReverseString(s.Substring(0, s.Length - 1));
    }
}
