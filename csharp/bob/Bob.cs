using System;

public static class Bob
{
    public static string Response(string statement)
    {
        if (statement.Trim().Length == 0)
        {
            return "Fine. Be that way!";
        }
        else if (statement.ToUpper() == statement && statement.ToLower() != statement)
        {
            if (statement.Trim().EndsWith("?"))
            {
                return "Calm down, I know what I'm doing!";
            }
            else
            {
                return "Whoa, chill out!";
            }
        }
        else if (statement.Trim().EndsWith("?"))
        {
            return "Sure.";
        }
        else
        {
            return "Whatever.";
        }
    }
}