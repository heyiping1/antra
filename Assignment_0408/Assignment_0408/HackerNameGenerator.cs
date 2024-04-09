namespace Assignment_0408
{
    public class HackerNameGenerator
    {
        public void generateHackerName()
        {
            Console.Write("What is your favorite color? ");
            string color = Console.ReadLine();
            Console.Write("What is your astrology sign? ");
            string sign = Console.ReadLine();
            Console.Write("What is your street address number? ");
            string address = Console.ReadLine();
            string hackerName = $"{color}{sign}{address}";
            Console.WriteLine($"Your hacker name is {hackerName}.");
        }
    }
}
