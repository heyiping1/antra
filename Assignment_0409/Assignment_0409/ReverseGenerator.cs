namespace Assignment_0409;
public class ReverseGenerator
{
    public static int[] GenerateNumbers(int length)
    {
        int[] numbers = new int[length];
        for (int i = 0; i < length; i++)
        {
            numbers[i] = i + 1;
        }
        return numbers;
    }

    public static void Reverse(ref int[] numbers)
    {
        for (int i = 0; i <= numbers.Length / 2; i++ )
        {
            int temp = numbers[i];
            numbers[i] = numbers[numbers.Length - 1 - i];
            numbers[numbers.Length - 1 - i] = temp;
        }
    }

    public static void PrintNumbers(int[] numbers)
    {
        Console.WriteLine(String.Join(", ", numbers));
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        int[] numbers = GenerateNumbers(length);
        Reverse(ref numbers);
        PrintNumbers(numbers);
    }

}
