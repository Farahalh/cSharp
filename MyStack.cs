namespace cSharp;

class MyStack
{
    // Create a Stack to store characters (char)
    // Add four different characters in the stack
    // Write a method that removes and prints characters
    // from the stack in reversed order (last in, first out)

    private Stack<char> _stack;

    public MyStack()
    {
        _stack = new Stack<char>();
    }

    public void modifyStack()
    {
        Console.WriteLine("Original Stack: ");

        _stack.Push('A');
        _stack.Push('B');
        _stack.Push('C');
        _stack.Push('D');

        foreach (char c in _stack)
        {
            Console.WriteLine(c);
        }

        Console.WriteLine("\nModified Stack: ");

        while (_stack.Count > 0)
        {
            var removeItem = _stack.Pop();
            Console.WriteLine(removeItem);
        }
    }
}