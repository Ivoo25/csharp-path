using System;
using System.Runtime.CompilerServices;

public static class LogAnalysis
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string separator)
    {
        var index = str.IndexOf(separator);
        return index < 0 ? str : str.Substring(index + separator.Length);
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string start, string end)
    {
        var startingInndex = str.IndexOf(start);
        var endingInndex = str.IndexOf(end);
        return startingInndex < 0 || endingInndex < 0 ?
            str :
            str.Substring(startingInndex + start.Length, endingInndex - startingInndex - start.Length);
    }

    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str)
    {
        return str.SubstringAfter(": ");
    }

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str)
    {
        return str.SubstringBetween("[", "]");
    }
}