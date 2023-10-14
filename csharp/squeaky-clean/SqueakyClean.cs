using System.Text;
public static class Identifier
{
    private static bool IsGreekLowercase(char c) => (c >= 'α' && c <= 'ω');
    public static string Clean(string identifier)
    {
        var stringBuilder = new StringBuilder();
        var isAfterDash = false;
        foreach (var c in identifier)
        {
            stringBuilder.Append(c switch
            {
                _ when IsGreekLowercase(c) => default, // ignore Greek lowercase
                _ when isAfterDash => char.ToUpperInvariant(c), // uppercase after dash
                _ when char.IsWhiteSpace(c) => '_', // replace whitespace with underscore
                _ when char.IsControl(c) => "CTRL", // replace control characters with "CTRL", control characters are for example: \n, \t, \r
                _ when char.IsLetter(c) => c, // keep letters
                _ => default, // ignore other characters
            });
            isAfterDash = c.Equals('-'); // remember if the current character is a dash
        }
        return stringBuilder.ToString();
    }
}