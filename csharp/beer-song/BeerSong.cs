using System.Collections.Generic;
using System.Linq;
using System.Text;
public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown)
    {
        var stringBuilder = new StringBuilder();
        var bottleCounts = Enumerable.Range(0, takeDown)
            .Select(i => startBottles - i);
        foreach (var bottleCount in bottleCounts)
        {
            foreach (var line in GetVerseLines(bottleCount))
            {
                stringBuilder.Append(line);
                stringBuilder.Append('\n');
            }
            stringBuilder.Append('\n');
        }
        return stringBuilder.ToString(0, stringBuilder.Length - 2);
    }
    private static IEnumerable<string> GetVerseLines(int currentCount)
    {
        yield return currentCount switch
        {
            0 => "No more bottles of beer on the wall, no more bottles of beer.",
            1 => "1 bottle of beer on the wall, 1 bottle of beer.",
            var i => $"{i} bottles of beer on the wall, {i} bottles of beer."
        };
        yield return currentCount switch
        {
            0 => "Go to the store and buy some more, 99 bottles of beer on the wall.",
            1 => "Take it down and pass it around, no more bottles of beer on the wall.",
            2 => "Take one down and pass it around, 1 bottle of beer on the wall.",
            var i => $"Take one down and pass it around, {currentCount - 1} bottles of beer on the wall."
        };
    }
}