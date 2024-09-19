namespace cSharp
{
public class PersonsDisplayer
{
    public PersonsDisplayer()
    {

    }
    public void DisplayPersons()
    {
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
}