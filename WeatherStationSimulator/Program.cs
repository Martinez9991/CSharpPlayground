namespace WeatherStationSimulator
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to simulate: ");
            int days = int.Parse(Console.ReadLine());

            int[] temperature = new int[days];
            string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };
            string[] weatherConditions = new string[days];

            Random random = new Random();

            for (int i = 0; i < days; i++) 
            {
                temperature[i] = random.Next(-10, 40);
                weatherConditions[i] = conditions[random.Next(conditions.Length)];
                Console.WriteLine($"Day {i + 1}: Temp = {temperature[i]}, Condition = {weatherConditions[i]}");
            }

            temperature.Max();

            double avarageTemp = CalculateAverage(temperature);

            Console.WriteLine($"Avarage Temperature is : {avarageTemp}");
            Console.WriteLine($"The max temp was : { temperature.Max()}");
            Console.WriteLine($"The min temp was : {temperature.Min()}");
            //Console.WriteLine($"The min temp was x : {MinTemperature(temperature)}");
            Console.WriteLine($"Most common condition is : {MostCommonCondition(conditions)}");
            Console.ReadKey();
        }

        static string MostCommonCondition(string[] conditions)
        {
            int count = 0;
            string mostCommon = conditions[0];

            for (int i = 0; i < conditions.Length; i++)
            {   // 1st iteration "Sunny"
                int tempCount = 0;
                for (int j = 0; j < conditions.Length; j++) 
                {
                    if (conditions[j] == conditions[i])
                    {
                        tempCount++;
                    }
                    if (tempCount > count)
                    { 
                        count = tempCount;
                        mostCommon = conditions[j];
                    }
                }
            }
            return mostCommon;
        }

        static double CalculateAverage(int[] temperature)
        {
            double avarage;
            double sum = 0;
            for (int i = 0; i < temperature.Length; i++)
            {
                sum += temperature[i];
            }
            // temperature.Length is the amount of items inside of temperature
            avarage = sum / temperature.Length;
             return avarage;
        }

        static int MinTemperature(int[] temperature)
        {
            int min = temperature[0];

            foreach (int temp in temperature) 
            {
                if (temp < min)
                {
                    min = temp; 
                }
            }
            return min;
        }

    }
}
