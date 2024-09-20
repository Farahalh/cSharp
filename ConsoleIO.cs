public class ConsoleIO : IUI
{
    public ConsoleIO()
    {
        
    }
    public void WriteLine(string message)
    {
        Console.WriteLine(message);
    }

    public string ReadLine()
    {
        return Console.ReadLine() ?? "";
    }
}