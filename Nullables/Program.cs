namespace Nullables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? age = null;// int? is a nullable int
            int myAge = 35;

            if (age.HasValue)
            {
                Console.WriteLine("Age is: " + age.Value);
                int sum = age.Value + myAge;
            }
            else 
            {
                
                Console.WriteLine("Age us not specified" + age);
            }

            Console.ReadKey();
        }
    }
}
