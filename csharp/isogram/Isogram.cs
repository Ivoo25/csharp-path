using System.Linq;
public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        var lowerLetters = word.ToLower().Where(char.IsLetter).ToList();
        // get all letters in lower case
        return lowerLetters.Distinct().Count() == lowerLetters.Count; //distinct() removes duplicates
    }
}
