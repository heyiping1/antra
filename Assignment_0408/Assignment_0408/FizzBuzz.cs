namespace Assignment_0408
{
    public class FizzBuzz
    {
        public void fizzBuzz()
        {
            Console.Write("Enter the upper bound: ");
            int upperBound = int.Parse(Console.ReadLine());

            for (int i = 1; i <= upperBound; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
