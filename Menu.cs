namespace cSharp;

class Menu
{
    // Övning - Program meny

    public Menu()
    {

    }

    public void DisplaysMenu()
    {
        Console.WriteLine("Choose an option from the menu:");
        Console.WriteLine("1. Say Hello");
        Console.WriteLine("2. Display today's date");
        Console.WriteLine("3. Exit");

        string input = Console.ReadLine();

        int choice = int.Parse(input);


        //How about a switch?
        if (choice == 1)
        {
            Console.WriteLine("Hello!");
        }
        else if (choice == 2)
        {
            Console.WriteLine($"Today's date is: {DateTime.Now.ToShortDateString()}");
        }
        else if (choice == 3)
        {
            Console.WriteLine("Goodbye!");
        }
        else
        {
            Console.WriteLine("Invalid choice, please try again.");
        }
    }

}