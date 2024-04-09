namespace Assignment_0408
{
    public class AgeCalculator
    {
        public void calculateAgeInDays()
        {
            Console.Write("Enter your birth year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Enter your birth month: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Enter your birth day: ");
            int day = int.Parse(Console.ReadLine());
            DateTime birthDate = new DateTime(year, month, day); 
            DateTime currentDate = DateTime.Today;
            int ageInDays = (currentDate - birthDate).Days;
            Console.WriteLine($"You are currently {ageInDays} days old.");
            int daysToNextAnniversary = 10000 - (ageInDays % 10000);
            DateTime nextAnniversary = currentDate.AddDays(daysToNextAnniversary);
            Console.WriteLine($"The date of your next 10,000 day anniversary is {nextAnniversary:d}.");
        }
    }
}
