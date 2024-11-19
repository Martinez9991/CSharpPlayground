namespace Enums
{

    enum Day {Monday,Tueday,Wednesday,Thrusday,Friday,Saturday,Sunday}
    enum Month {January = 1,February,March,April,May,June,July = 12,August,September,October,November,December}

    internal class Program
    {
        static void Main(string[] args)
        {
            Day fr = Day.Friday;
            Day su = Day.Sunday;
            Day a = Day.Friday;

            Console.WriteLine(fr == a);
            Console.WriteLine((int)Day.Monday);

            Console.WriteLine((int)Month.February);
            Console.WriteLine((int)Month.August);
            Console.ReadKey();
        }
    }
}
