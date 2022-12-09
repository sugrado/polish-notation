using PolishNotation.Services;

StackService<string> stackService = new();
Console.Write("İfadeyi Giriniz: ");
string[] expression = Console.ReadLine().Split(' ');

for (int i = expression.Length - 1; i >= 0; i--)
{
    if (PolishService.IsOperator(expression[i]))
    {
        string? value1 = stackService.Pop();
        string? value2 = stackService.Pop();

        stackService.Push(PolishService.Calculate(expression[i], int.Parse(value1), int.Parse(value2)).ToString());
    }
    else
        stackService.Push(expression[i]);
}

while (stackService.Any)
    Console.Write(stackService.Pop());
