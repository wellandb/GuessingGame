namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 99);
            Console.WriteLine("I have chosen a number between 1 and 99, try to guess it, you only get 5 tries.");
            int guesses = 0;
            int guess = 0;
            int low = 1;
            int high = 99;
            bool correct = false;
            for (guesses = 0;  guesses < 5; guesses++) {
                //guess = guessNum(low, high);
                //Console.WriteLine("My guess is {0}", guess);
                Console.Write("What is your guess: ");
                guess = Convert.ToInt16(Console.ReadLine());
                if (guess == num)
                {
                    correct = true;
                    guesses ++;
                    break;
                }
                else if (guess > num)
                {
                    high = guess - 1;
                    Console.WriteLine("Lower than that");
                }
                else
                {
                    low = guess + 1;
                    Console.WriteLine("Higher than that");
                }
            }
            if (correct)
            {
                Console.WriteLine("Well done my number was {0} you got it in {1} guesses :)", num, guesses);
            } else
            {
                Console.WriteLine("Unlucky my number was {0}, your last guess was {1} thats {2} away, better luck next time :(", num, guess, Math.Abs(num - guess));
            }
            Console.ReadLine();
        }

        public static int guessNum(int low, int high)
        {
            int result = (low + high+ 1) / 2;
            return result;
        }
    }
}
