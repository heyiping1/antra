namespace Assignment_0408
{
    public class NumberGuessing
    {
        public void guessNumber()
        {
            int correctNumber = new Random().Next(3) + 1; 
            Console.WriteLine("Guess a number between 1 and 3:");
            int guessedNumber = int.Parse(Console.ReadLine());
            if (guessedNumber == correctNumber)
            {
                Console.WriteLine("Your guess is correct.");
            }
            else if (guessedNumber < correctNumber)
            {
                Console.WriteLine("Your guess is too low.");
            }
            else
            {
                Console.WriteLine("Your guess is too high.");
            }
            Console.WriteLine($"The correct answer is {correctNumber}");
        }
    }
}
