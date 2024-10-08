namespace cSharp
{

    // Create a "List" of whole numbers from 1-5
    // Write a method that iterates the List and writes out every number to the console
    // Add a number to the list after the iteration and show that the list grows dynamically 

    class Lists
    {

        private List<int> _numbers;

        public Lists()
        {
            _numbers = new List<int> { 2, 4, 6, 8, 10 };
        }

        public void viewList()
        {

            Console.WriteLine("Original List: ");

            foreach (var a in _numbers)
            {
                Console.WriteLine(a);
            }

            _numbers.Add(70);
            _numbers.Add(24);
            _numbers.Remove(8);

            Console.WriteLine("\nUpdated List: ");

            foreach (var a in _numbers)
            {
                Console.WriteLine(a);
            }

            // Built in Method in C#
            //numbers.ForEach(Print);

            // Print out total number of items in List
            //Console.WriteLine(numbers.Count);
        }

        //public void Print(int n)
        //{

        //    Console.WriteLine(n);
        //}

    }
}