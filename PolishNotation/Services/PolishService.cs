namespace PolishNotation.Services;

public static class PolishService
{
    public static int Calculate(string element, int value, int value2) => DetectOperatorType(element)(value, value2);
    public static bool IsOperator(string element) => (element == "+") || (element == "-") || (element == "*") || (element == "/");
    public static Func<int, int, int> DetectOperatorType(string element) => element switch
    {
        "+" => (a, b) => a + b,
        "-" => (a, b) => a - b,
        "*" => (a, b) => a * b,
        "/" => (a, b) => a / b,
        _ => (a, b) => 0,
    };
}
