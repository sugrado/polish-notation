using PolishNotation.Models;

namespace PolishNotation.Services;

public static class PolishService
{
    public static int Calculate(string element, int value, int value2) => DetectOperatorType(element) switch
    {
        Operators.ADD => value + value2,
        Operators.SUB => value - value2,
        Operators.MUL => value * value2,
        Operators.DIV => value / value2,
        _ => throw new Exception("Invalid Input!"),
    };

    public static bool IsOperator(string element) => (element == "+") || (element == "-") || (element == "*") || (element == "/");

    private static Operators DetectOperatorType(string element) => element switch
    {
        "+" => Operators.ADD,
        "-" => Operators.SUB,
        "*" => Operators.MUL,
        "/" => Operators.DIV,
        _ => default,
    };
}

