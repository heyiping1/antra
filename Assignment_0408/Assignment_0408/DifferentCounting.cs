namespace Assignment_0408
{
    public class DifferentCounting
    {
        public void countTo24()
        {
            for (int i = 0; i <= 24; i++)
            {
                Console.Write(i);
                if (i != 24)
                {
                    Console.Write(", ");
                } else
                {
                    Console.WriteLine();
                }
            }
            for (int i = 0; i <= 24; i += 2)
            {
                Console.Write(i);
                if (i != 24)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.WriteLine();
                }
            }
            for (int i = 0; i <= 24; i += 3)
            {
                Console.Write(i);
                if (i != 24)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.WriteLine();
                }
            }
            for (int i = 0; i <= 24; i += 4)
            {
                Console.Write(i);
                if (i != 24)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
