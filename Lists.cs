namespace cSharp
{
    class Lists
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        public void List()
        {
            for (var i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[0]);
            }
        }
    }
}