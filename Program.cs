namespace cSharp;
class Program
{
    //static void PrintMessage(string s)
    //{
    //    Console.WriteLine(s.Length);
    //}

    //static void DivisionOfTwoNumbers()
    //{
    //    int dividend = 10;
    //    int divisor = 0;

    //    Console.WriteLine(dividend / divisor);
    //}

    //static void DivisionOfUserInput()
    //{
    //    int divisorInput;
    //    int dividendInput;

    //    Console.WriteLine("Input value one: ");
    //    divisorInput = Convert.ToInt32(Console.ReadLine());

    //    Console.WriteLine("Input value two: ");
    //    dividendInput = Convert.ToInt32(Console.ReadLine());

    //    int result = dividendInput / divisorInput;

    //    Console.WriteLine("Result: ");
    //    Console.WriteLine($"{dividendInput} / {divisorInput} = {result}");
    //}

    static void Main(string[] args)
    {
        // Övning - Selektion
        // Gör ett program som använder sig av nedanstående:

        // // - if statements
        // int x = 20;
        // int y = 18;
        // if (x > y)
        // {
        //     Console.WriteLine("x is greater than y");
        // }

        // // - if else statements
        // int time = 22;
        // if (time < 10)
        // {
        //     Console.WriteLine("Good morning.");
        // }
        // else if (time < 20)
        // {
        //     Console.WriteLine("Good day.");
        // }
        // else
        // {
        //     Console.WriteLine("Good evening.");
        // }

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

        // // - ternary operator
        // //variable = (condition) ? expressionTrue : expressionFalse;
        // int age = 20;
        // string greeting = age >= 18 ? "Welcome!" : "No minors allowed!";

        //var displaysMenu = new Menu();
        //displaysMenu.DisplaysMenu();


        //// // Om man ska skapa upp ett objekt(instans) så behöver man ta bort static på metoden så att ctor kan komma åt datan på objektet(instansen)
        //var personsDisplayer = new PersonsDisplayer(new ConsoleIO());
        //personsDisplayer.DisplayPersons();

        //// // Här kommer man åt datan genom static på metoden
        //// PersonsDisplayer.DisplayPersons();

        //var loopsDisplayer = new Loops();
        //loopsDisplayer.methodWhile();
        //loopsDisplayer.methodDo();
        //loopsDisplayer.methodFor();

        //var listsDisplayer = new Lists();
        //listsDisplayer.viewList();


        var queueDisplayer = new MyQueue();
        queueDisplayer.modifyQueue();

        //    string? s = (args.Length > 0) ? args[0] : null;
        //    PrintMessage(s ?? string.Empty);

        //    try
        //    {
        //        DivisionOfTwoNumbers();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.StackTrace);
        //    }

        //    try
        //    {
        //        DivisionOfUserInput();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }

    }
}
