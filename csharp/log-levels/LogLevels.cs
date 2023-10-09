using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        var separator = logLine.IndexOf(':'); // find the first colon
        var message = logLine.Substring(separator + 1).Trim(); // get the message
        return message;
        //throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
    }

    public static string LogLevel(string logLine)
    {
        var firstBracket = logLine.IndexOf('['); // find the first bracket
        var secondBracket = logLine.IndexOf(']'); // find the second bracket
        var level = logLine.Substring(firstBracket + 1, secondBracket - firstBracket - 1).Trim(); // get the level
        return level.ToLower();
        //throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
        var messageFormatted = logLine.Replace("ERROR", "Error").Replace("INFO", "Info").Replace("DEBUG", "Debug").Replace("WARNING", "Warning").Replace("[", "(").Replace("]", ")");
        var separator = logLine.IndexOf(':');
        var message = messageFormatted.Substring(separator + 1).Trim() + " (" + messageFormatted.Substring(1, separator - 1).Trim().ToLower();
        return message;
        //throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}