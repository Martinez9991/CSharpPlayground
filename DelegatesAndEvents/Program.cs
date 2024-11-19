using System.Net.Cache;

namespace DelegatesAndEvents
{
    internal class Program
    {

        // 1. Declration 
        public delegate void Notify(string message);

        public delegate void LogHandler(string message);

        public delegate int Comparsion<T>(T x, T y);



        static void Main(string[] args)
        {
            /* Delgate define a method signature
             * and any method assgined to a delegate must match this signature.
            */

            
            // 1. Declration 
        //public delegate void Notify(string message);

        // 2. Instantiation:
            Notify notifyDelagate = ShowMessage;
            //Notify notifyDelagate = new Notify(notifyDelagate);

            // 3: Invocation:
            //notifyDelagate("Hello, Delegates!");



            Logger logger = new Logger();
            //Creating a multicast delegate
            LogHandler logHandler = logger.LogToConsole;
            logHandler += logger.LogToFile;
            //invoking the multicast delegate
            logHandler("Log this info!");

            foreach (LogHandler handler in logHandler.GetInvocationList())
            {
                try
                {
                    handler("Event occured with error handling");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception caught " + ex.Message);
                }
            }
            // removing a method from the multicast delgate
            if (IsMethodInDelegate(logHandler, logger.LogToFile))
            {
                logHandler -= logger.LogToFile;
                Console.WriteLine("LogToFile method removed");
            }
            else 
            {
                Console.WriteLine("LogToFile method not found");
            }

            //if (logHandler != null)
            //{
            //    InvokeSafely(logHandler, "After removing LogTofile");
            //}

            //logHandler -= logger.LogToFile;
            //logHandler("After removing LogTofile");
            InvokeSafely(logHandler, "After removing LogTofile");

            //logHandler("Logging to console");

            //logHandler = logger.LogToFile;
            //logHandler("Log some stuff");

            //int[] intArray = { 1, 2, 3, 4, 5 };
            //string[] sringArray = { "one", "two", "three"};
            //PrintArray(intArray);
            //PrintArray(sringArray);

            //Person[] people = {
            //    new Person{ Name = "Alice" , Age = 30 },
            //    new Person{ Name = "Bob" , Age = 25 },
            //    new Person{ Name = "Denis" , Age = 36 },
            //    new Person{ Name = "Charlie" , Age = 35 },
            //};

            //PersonSorter sorter = new PersonSorter();
            //sorter.Sort(people, CompareByAge);

            //foreach (Person person in people) 
            //{
            //    Console.WriteLine($"{person.Name}, {person.Age}");
            //}

            //sorter.Sort(people, CompareByName);
            //foreach (Person person in people)
            //{
            //    Console.WriteLine($"{person.Name}, {person.Age}");
            //}

            Console.ReadKey();
        }

        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static void PrintIntArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintStringArray(string[] array)
        {
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }
        }

        // a generic Method, that accpets a genric datatype
        public static void PrintArray<T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.WriteLine(item);
            }
        }

        static int CompareByAge(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }

        static int CompareByName(Person x, Person y)
        {
            return x.Name.CompareTo(y.Name);
        }

        static void InvokeSafely(LogHandler logHandler, string message)
        {
            LogHandler tempLogHandler = logHandler;
            if (tempLogHandler != null)
            {
                tempLogHandler(message);
            }
        }

        static bool IsMethodInDelegate(LogHandler logHandler, LogHandler method)
        {
            if (logHandler == null)
            {
                return false;
            }

            foreach (var d in logHandler.GetInvocationList())
            {
                if (d == (Delegate)method)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
