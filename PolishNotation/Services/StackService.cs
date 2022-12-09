using PolishNotation.Models;

namespace PolishNotation.Services;

public class StackService<T>
{
    StackNode<T>? _stack;
    public int Count => GetListCount();
    public bool Any => Count != 0;

    public StackService()
    {
        _stack = null;
    }

    private int GetListCount()
    {
        int count = 0;
        StackNode<T>? current = _stack;
        while (current != null)
        {
            count++;
            current = current.Next;
        }
        return count;
    }

    public T? Pop()
    {
        if (_stack == null)
        {
            Console.WriteLine("Stack is empty.");
            return default;
        }
        if (_stack.Next == null)
        {
            var toReturn = _stack.Data;
            _stack = null;
            return toReturn;
        }

        StackNode<T> iter = _stack;
        while (iter.Next?.Next != null)
            iter = iter.Next;

        StackNode<T>? temp = iter.Next;
        iter.Next = null;
        return temp.Data;
    }

    public void Push(T data)
    {
        if (_stack == null)
        {
            _stack = new StackNode<T>
            {
                Data = data,
                Next = null
            };
            return;
        }

        StackNode<T> iter = _stack;
        while (iter.Next != null)
            iter = iter.Next;

        var temp = new StackNode<T>
        {
            Data = data,
            Next = null
        };
        iter.Next = temp;
    }
}
