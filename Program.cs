namespace cSharp;

class Program
{
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


        // // Övning - Program meny
        // Console.WriteLine("Choose an option from the menu:");
        // Console.WriteLine("1. Say Hello");
        // Console.WriteLine("2. Display today's date");
        // Console.WriteLine("3. Exit");

        // string input = Console.ReadLine();

        // int choice = int.Parse(input);

        // if (choice == 1)
        // {
        //     Console.WriteLine("Hello!");
        // }
        // else if (choice == 2)
        // {
        //     Console.WriteLine($"Today's date is: {DateTime.Now.ToShortDateString()}");
        // }
        // else if (choice == 3)
        // {
        //     Console.WriteLine("Goodbye!");
        // }
        // else
        // {
        //     Console.WriteLine("Invalid choice, please try again.");
        // }



        // // Om man ska skapa upp ett objekt(instans) så behöver man ta bort static på metoden så att ctor kan komma åt datan på objektet(instansen)
        var personsDisplayer = new PersonsDisplayer();
        personsDisplayer.DisplayPersons();

        // // Här kommer man åt datan genom static på metoden
        // PersonsDisplayer.DisplayPersons();

        var loopsDisplayer = new Loops();
        loopsDisplayer.methodWhile();
        loopsDisplayer.methodDo();
        loopsDisplayer.methodFor();

    }
}