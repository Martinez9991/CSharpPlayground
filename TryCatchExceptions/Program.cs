using System.Diagnostics;

namespace TryCatchExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("App running before the try block");
            try
            {
                LevelOne();
            }
            catch (Exception ex)
            {

                Console.WriteLine("Expection caught in Main: " + ex.Message); 
            }
            Console.WriteLine("App is still running!");
            */
            int result = 0;

            Debug.WriteLine("Main Method is running");

            try
            {
                Console.WriteLine("Please enter a number");
                int num1 = int.Parse(Console.ReadLine());
                //int num1 = 0;
                int num2 = 2;
                result = num2 / num1;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Don't Divide by zero! " + ex.Message);
                result = 10;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("I told to enter a number! " + ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Number is too high! " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //This next line is only executed during "Debugging"
            //    Debug.WriteLine(ex.ToString());
            //}
            finally
            {
                //Code to cleanup or finalize
                // ideal for cleaning resources
                // like closing file streams or database connections
                Console.WriteLine("This always executes");
            }



            Console.WriteLine("Result: " + result);

            
            //Console.WriteLine("Enter your age.");
            //GetUserAge(Console.ReadLine());
            
            Console.ReadKey();

        }

        static int GetUserAge(string input)
        {
            int age;
            if (!int.TryParse(input, out age))
            {
                throw new Exception("You didn't enter a valid age.");
            }
            if (age < 0 || age > 120)
            {
                throw new Exception("Your age must be between 0 and 120.");
            }
            return age;
        }

        static void LevelOne()
        {
            LevelTwo();
        }

        static void LevelTwo()
        {
            Console.WriteLine("Level Two before throw");
            throw new Exception("Something went wrong!");
            Console.WriteLine("Level Two after throw");
        }

    }
}
