using System;

public static class ResistorColorDuo
{
    private static readonly string[] Resistors =
      new string[] {
        "black",
        "brown",
        "red",
        "orange",
        "yellow",
        "green",
        "blue",
        "violet",
        "grey",
        "white"
    };

    public static int Value(string[] colors)
    {
        //Return based on the color code
        int colorCode = Array.IndexOf(Resistors, colors[0]);
        int colorCode2 = Array.IndexOf(Resistors, colors[1]);
        string colorCodeString = colorCode.ToString() + colorCode2.ToString();
        return int.Parse(colorCodeString);
        throw new NotImplementedException("You need to implement this function.");
    }
}
