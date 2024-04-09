namespace Assignment_0408
{
    public class PyramidPrinter
    {
        public void printPyramid()
        {
            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2 * i + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
