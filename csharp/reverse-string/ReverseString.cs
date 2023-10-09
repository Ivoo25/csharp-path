using System;
using System.Linq;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        string reverseWord = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reverseWord += input[i];
        }
        return reverseWord;
        //throw new NotImplementedException("You need to implement this function.");
    }
}
