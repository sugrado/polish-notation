namespace PolishNotation.Models;

public class StackNode<T>
{
    public T? Data { get; set; }
    public StackNode<T>? Next { get; set; }
}
