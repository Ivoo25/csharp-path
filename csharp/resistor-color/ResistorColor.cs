using System;

public static class ResistorColor
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

    public static int ColorCode(string color) => Array.IndexOf(Resistors, color);

    public static string[] Colors() => Resistors;

}