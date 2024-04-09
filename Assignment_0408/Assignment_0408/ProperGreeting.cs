namespace Assignment_0408
{
    public class ProperGreeting
    {
        public void greetProperly()
        {
            int currentHour = DateTime.Now.Hour;

            if (currentHour >= 4 && currentHour < 12)
            {
                Console.WriteLine("Good Morning");
            }
            if (currentHour >= 12 && currentHour < 16)
            {
                Console.WriteLine("Good Afternoon");
            }
            if (currentHour >= 16 && currentHour < 22)
            {
                Console.WriteLine("Good Evening");
            }
            if (currentHour >= 22 || currentHour < 4)
            {
                Console.WriteLine("Good Night");
            }
        }
    }
}
