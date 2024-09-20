namespace cSharp
{
    class Loops
    {
        // skriv ut talen 1 - 10 på 3 olika sätt.
        int i = 0;
        public Loops()
        {

        }
        public void methodWhile()
        {
            // while
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public void methodDo()
        {
            // do
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 11);

            // for
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void methodFor()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}