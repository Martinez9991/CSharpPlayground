namespace ListsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Declaring a list and initializing/ Adding items to the list
            List<string> colors = ["red", "blue", "green", "red"];
            //List<int> ints = new List<int>();

            colors.Add("cyan");

            Console.WriteLine("Current colors in the colors list!");
            foreach (string color in colors) 
            {
                Console.WriteLine(color);
            }


            bool isDeletingSucessful = colors.Remove("red");
            while (isDeletingSucessful) 
            {
                isDeletingSucessful = colors.Remove("red");
            }

            Console.WriteLine("Current colors in the colors list!");
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            */

            /*
            List<int> numbers = new List<int> {10,5,15,3,9,25,18};

            Console.WriteLine("Unsorted List");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            bool hasLargeNumber = numbers.Any(x => x > 20);

            if (hasLargeNumber)
            {
                Console.WriteLine("There are large numbers");
            }
            else
            {
                Console.WriteLine("There are no large numbers");
            }

            Console.WriteLine("Sorted List");
            numbers.Sort();
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }


            Console.WriteLine("All numbers 10 and higher in our list");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Define the predicate to check if a number is greater than 10
            Predicate<int> isGreatherThanTen = x => x > 10;

            //This will return a list of number that are 10 and higher
            List<int> higtherTen = numbers.FindAll(isGreatherThanTen);

            /*In C#, a delegate is like a pointer or a reference to a method.
             * It allows you to pass methods as arguments to other methods, store them in variables,
             * call them later.
             * This is useful when you want your code to be flexible and able to handle different
             * behaviors tha aren´t predetermined.
            */

            //Declare a list of complex object with inital values
            List<Product> products = new List<Product> 
            {
                new Product { Name = "Apple", Price = 0.80 },
                new Product { Name = "Banana", Price = 0.30 },
                new Product { Name = "Cherry", Price = 3.80 }
            };
            // add items to the list
            products.Add(new Product { Name = "Berries", Price = 2.99 });

            List<Product> cheapproducts  = products.Where(p => p.Price < 1.0).ToList();

            Console.WriteLine("Available Products for less thatn $1: ");
            //iterate though the list
            foreach (Product product in cheapproducts) 
            {
                Console.WriteLine($"Product name: {product.Name} for {product.Price}");
            }

            Console.ReadKey();
        }

        // A lamba expression consists of 2 Parts
        //1.Parameters
        //2.Expression or Statement Block

        // Parameters are written on the left side of =>(this symbol is read as "goes to" or "becomes")
        //The expression or action to perform is on the right side.

        //This reads as:
        //"Take an input x and turn into x multiple by x"
        //x=> x * x;



        static int Squaring(int num1)
        {
            return num1 * num1;
        }

        public static bool IsGreaterThanTen(int x)
        { return x > 10; }

    }
}
