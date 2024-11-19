namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var codes = new Dictionary<string, string>
            {
                ["NY"] = "New York",
                ["CA"] = "California",
                ["TX"] = "Texas",
            };

            string state;

            if (codes.TryGetValue("NY", out state))
            {
                Console.WriteLine(state);
            }

            foreach (var item in codes)
            {
                Console.WriteLine($"The statecode is {item.Key} and the state name is {item.Value}");
            }

            
            // Key - Value
            // Declaring and intializing a Dictionary

            Dictionary<int, Employee> employees = new Dictionary<int, Employee>();

            employees.Add(1, new Employee("John Doe",35,100000));
            employees.Add(2, new Employee("John Michael", 25, 200000));
            employees.Add(3, new Employee("Joanna Smith", 45, 800000));
            employees.Add(4, new Employee("Karl Will", 15, 500000));

            foreach(var item in employees)
            {
                Console.WriteLine($"ID: {item.Key}, Named: {item.Value.Name}, Earns: {item.Value.Salary}" +
                    $" and is {item.Value.Age} years old!");
            }
            

            /*
            Dictionary<int, string> employees = new Dictionary<int, string>();
            // Adding Items to a Dictionary
            employees.Add(101, "John Doe");
            employees.Add(102, "Bob Smith");
            employees.Add(103, "Stuart Smith");
            employees.Add(104, "Robert Smith");
            employees.Add(105, "James Smith");

            // Access items in a dictionary
            string name = employees[101];
            Console.WriteLine(name);

            // Update data in a dictionary
            employees[102] = "Jane Smith";

            // Remove an item from a dictionary
            employees.Remove(101);

            employees[104] =  "Mike James";

            if (!employees.ContainsKey(104))
            {
                employees.Add(104, "Mike James");
            }

            
            //int counter = 101;
            //while (employees.ContainsKey(counter)) 
            //{
            //    counter++;
            //}
            //employees.Add(counter, "Jean Napoleon");
            

            bool added = employees.TryAdd(102, "Michael Phelps");
            if (!added) 
            {
                Console.WriteLine("Employeed with id of 102 already exists!");
            }

            //Iterating over a dictionary
            foreach (KeyValuePair<int, string> employee in employees)
            {
                Console.WriteLine($"ID: {employee.Key}, Name: {employee.Value}");
            }
            */
            Console.ReadKey();

        }
    }
}
