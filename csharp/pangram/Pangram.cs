using System.Linq;

public static class Pangram
{
    const string alphabet = "abcdefghijklmnopqrstuvwxyz";
    public static bool IsPangram(string text)
    {
        return alphabet.All(text.ToLower().Contains);
        // All() returns true if all elements in the sequence satisfy the condition
    }
}
