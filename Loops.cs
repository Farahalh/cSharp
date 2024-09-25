namespace cSharp
{
    class Loops
    {
        // skriv ut talen 1 - 10 på 3 olika sätt.
        private int _i = 0; //renamed to _i
        public Loops()
        {
        }
        public void methodWhile()
        {
            // while
            while (_i < 10)
            {
                Console.WriteLine(_i);
                _i++;
            }
        }

        public void methodDo()
        {
            // do
            do
            {
                Console.WriteLine(_i);
                _i++;
            }
            while (_i < 11);

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



        // int[] numbersToGuess = {0,1,2,3,4,5,6,7,8,9,10};
        // int choosenNumber = Convert.ToInt32(Console.ReadLine());

        // public void guessNumber()
        // {
        // Console.WriteLine("Guess a number between 1 and 10");

        // if (choosenNumber == numbersToGuess)
        // {
            
        // }
        // }
    }
}