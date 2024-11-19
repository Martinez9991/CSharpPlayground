namespace DateTimeT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(1999, 1, 23);

            
            Console.WriteLine("My birthday is {0}", dateTime);
            // Write today on screen
            Console.WriteLine(DateTime.Today);
            // Write current time on screen
            Console.WriteLine(DateTime.Now);

            DateTime tomorrow = GetTomorrow();
            Console.WriteLine("Tomorrow will be the {0}", tomorrow);
            Console.WriteLine("Today is " + DateTime.Today.DayOfWeek);
            Console.WriteLine(GetFirstDayYear(1999));

            int days = DateTime.DaysInMonth(2000, 2);
            Console.WriteLine("Days in Feb 2000: {0}", days);
            days = DateTime.DaysInMonth(2001, 2);
            Console.WriteLine("Days in Feb 2001: {0}", days);
            days = DateTime.DaysInMonth(2004, 2);
            Console.WriteLine("Days in Feb 2004: {0}", days);

            DateTime now = DateTime.Now;
            Console.WriteLine("Minute {0}", now.Minute);

            // display the time in this structure x o'Clock and y minutes and z seconds
            Console.WriteLine("{0}:{1}:{2}",now.Hour,now.Minute,now.Second);

            Console.WriteLine("Write your  birthdate in this format: yyyy-mm-dd");
            string input = Console.ReadLine();
            if (DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);
                Console.WriteLine("Your are {0} days old", daysPassed.Days);
            }
            else
            {
                Console.WriteLine("Wrong Input!");
            }

            Console.ReadKey();
        }

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        static DateTime GetFirstDayYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
}
