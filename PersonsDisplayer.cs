namespace cSharp
{
public class PersonsDisplayer
{
    private IUI _ui;
    public PersonsDisplayer(IUI ui)
    {
        _ui = ui;
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
        string firstName = _ui.ReadLine();

        string secondtName = _ui.ReadLine();

        string thirdName = _ui.ReadLine();

        Person[] persons = { new Person(firstName), new Person(secondtName), new Person(thirdName) };

        foreach (Person person in persons)
        {
            _ui.WriteLine(person.ToString());
        }
    }
}
}