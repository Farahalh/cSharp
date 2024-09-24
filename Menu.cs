namespace cSharp;

class Menu
{
    // Övning - Program meny

    public Menu()
    {

    }

    public string[] GetMenu()
    {
        return new string[4] {
                "1. Say Hello",
                "2. Display today's date",
                    "3. Input Your Age",
                "4. Exit"
        };
    }

    public void DisplaysMenu()
    {
        while (true)

        {

            Console.WriteLine("Choose an option from the menu:");
            Console.WriteLine("1. Say Hello");
            Console.WriteLine("2. Display today's date");
            Console.WriteLine("3. Input Your Age");
            Console.WriteLine("4. Exit");

            int input = Convert.ToInt32(Console.ReadLine());

            //int choice = int.Parse(input ?? string.Empty);


            ////How about a switch?
            //if (choice == 1)
            //{
            //    Console.WriteLine("Hello!");
            //}
            //else if (choice == 2)
            //{
            //    Console.WriteLine($"Today's date is: {DateTime.Now.ToShortDateString()}");
            //}
            //else if (choice == 3)
            //{
            //    Console.WriteLine("Goodbye!");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid choice, please try again.");
            //}

            string output = "";
            switch (input)
            {
                case 1:
                    Console.WriteLine("Hello!");
                    break;
                case 2:
                    Console.WriteLine($"Today's date is: {DateTime.Now.ToShortDateString()}");
                    break;
                case 3:


                    try
                    {
                        GetAge();
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("You are, old enough to join!");

                    }


                    break;
                case 4:
                    Console.WriteLine("Goodbye!");
                    break;
            }

            Console.WriteLine(output);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <exception cref="Exception">Throws if age is not 18+</exception>
    private static void GetAge()
    {
        int age = Convert.ToInt32(Console.ReadLine());

        if (age < 18)
        {
            throw new Exception("Too young");
        }
    }
}