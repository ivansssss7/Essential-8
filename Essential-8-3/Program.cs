namespace Essential8_3
{
    class Program
    {

        static void Main()
        {
            Console.WriteLine("Enter the birthday date");
            Console.WriteLine("Enter year of birth");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month of birth");
            int monthOfBirth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter day of birth");
            int dayOfBirth = Convert.ToInt32(Console.ReadLine());

        
            DateTime nextBirthday = new DateTime(DateTime.Now.Year, monthOfBirth, dayOfBirth);

            if (nextBirthday < DateTime.Now)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }

            TimeSpan daysRemainingToBirthday = nextBirthday - DateTime.Now;

            int daysUntilBirthday = daysRemainingToBirthday.Days;
            if (daysUntilBirthday < 0)
            {
                daysUntilBirthday += 365;
            }

            Console.WriteLine(daysUntilBirthday);
        }
    }
}