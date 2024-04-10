namespace Assignment_0409;
public class FibonacciNumbers
{
    public static int[] Fibonacci(int length)
    {
        int[] numbers = new int[length];
        if (length > 0)
        {
            numbers[0] = 1;
        }
        if (length > 1)
        {
            numbers[1] = 1;
        }
        for (int i = 2; i < length; i++)
        {
            numbers[i] = numbers[i - 2] + numbers[i - 1];
        }
        return numbers;
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter the length of fibonacci: ");
        int length = int.Parse(Console.ReadLine());
        int[] numbers = Fibonacci(length);
        Console.WriteLine(String.Join(", ", numbers));
    }

}
