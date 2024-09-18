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


        // Create a C# program that requests three names of people from the user -check
        //
        // and stores them in an array of objects of type Person. - check
        //
        // To do this, first create a Person class that has a Name property of type string - check
        //
        // and override the ToString() method. - check
        //
        // End the program by reading persons and executing the ToString() method on the screen.

        Console.WriteLine("Insert name: ");
        string firstName = Console.ReadLine();

        string secondtName = Console.ReadLine();

        string thirdName = Console.ReadLine();

        Person[] persons = { new Person(firstName), new Person(secondtName), new Person(thirdName) };

        foreach (Person person in persons)
        {
            Console.WriteLine(person.ToString());
        }
    }

}