namespace cSharp;

class Program
{
    static void Main(string[] args)
    {
        // Övning - Selektion
        // Gör ett program som använder sig av nedanstående:

        // - if statements
        int x = 20;
        int y = 18;
        if (x > y)
        {
            Console.WriteLine("x is greater than y");
        }

        // - if else statements
        int time = 22;
        if (time < 10)
        {
            Console.WriteLine("Good morning.");
        }
        else if (time < 20)
        {
            Console.WriteLine("Good day.");
        }
        else
        {
            Console.WriteLine("Good evening.");
        }

        // - switch statements
        // switch (expression)
        // {
        //     case x:
        //         // code block
        //         break;
        //     case y:
        //         // code block
        //         break;
        //     default:
        //         // code block
        //         break;
        // }

        // - ternary operator
        //variable = (condition) ? expressionTrue : expressionFalse;
        int age = 20;
        string greeting = age >= 18 ? "Welcome!" : "No minors allowed!";
    }
}
