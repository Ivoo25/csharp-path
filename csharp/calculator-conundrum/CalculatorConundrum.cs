using System;
public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string operation) =>
        operation switch
        {
            Operations.Division when operand2 == 0 => "Division by zero is not allowed.",
            Operations.Addition or Operations.Multiplication or Operations.Division => $"{operand1} {operation} {operand2} = {GetMathResult(operand1, operand2, operation)}",
            "" => throw new ArgumentException("Invalid operation", nameof(operation)),
            null => throw new ArgumentNullException(nameof(operation)),
            _ => throw new ArgumentOutOfRangeException(nameof(operation))
        };
    #region Helper methods
    private static int GetMathResult(int operand1, int operand2, string operation) => operation switch
    {
        Operations.Addition => operand1 + operand2,
        Operations.Multiplication => operand1 * operand2,
        Operations.Division => operand1 / operand2
    };
    #endregion
}
//NOTE: using a static class to emulate an enum, but for string values (because enums use int values)
static class Operations
{
    public const string Addition = "+";
    public const string Multiplication = "*";
    public const string Division = "/";
}