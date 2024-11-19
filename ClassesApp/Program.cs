namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Creating an Object of the Class Car
            //Creating an instance of the Class Car
            Car audi = new Car("A3","Audi", false);
            Car bmw = new Car("I7", "BMW", true);

            Console.WriteLine("Please enter the brand name ");
            //Setting "brand"
            audi.Brand = Console.ReadLine();

            //getting "brand"
            Console.WriteLine($"Brand is {audi.Brand}");
            Console.WriteLine($"Brand is {bmw.Brand}");
            */

            /*
            Customer earl = new Customer("Earl");
            Customer frankTheTank = new Customer("FrankTheTank","Mainstree1","1234567");
            //Default customer with no arguments given
            Customer mycustomer = new Customer();

            mycustomer.SetDetails("Frank", "Mainstreet 2", "987564132");
            Console.WriteLine("MyCustomer is " + mycustomer.Name + "and he lives in" + mycustomer.Address);


            Console.WriteLine("Please enter the customer's name: ");
            mycustomer.Name = Console.ReadLine();
            Console.WriteLine("earl is: " + earl.Name + "and he lives in" + earl.Address);
            Console.WriteLine("Details about customer: " + mycustomer.Name);
            */

            /*
            Car myAudi = new Car("A3","Audi",false);
            myAudi.Drive();
            Car myBMW = new Car("I7", "BMW", true);
            myBMW.Drive();
            */

            /*
            Customer customer = new Customer();
            customer.SetDetails("Joao", "Mainstreet 1");

            Customer customer1 = new Customer("Frank");
            Console.WriteLine("Contactnumber of Frank: " + customer1.ContatctNumber);
            */

            /*
            //Named Parameters
            Console.WriteLine(AddNum(15,25));
            Console.WriteLine(AddNum(firstNum: 23, secondNum: 25));
            Console.WriteLine(AddNum(23, secondNum: 25));
            Console.WriteLine(AddNum(firstNum: 23, 25));
            */

            /*
            //Computed Proprities and no constructor
            Rectangle r1 = new Rectangle();
            r1.Width = 10;
            r1.Height = 10;
            Console.WriteLine("Area of r1 is: " + r1.Area);
            */

            /* Customer customer = new Customer();
             customer.SetDetails("John", "Mainstreet");

             Customer.DoSomeCustomerStuff();
            */
            //The DoSomeCustomerStuff method is static and cannot be called on Objects
            //customerDoSomeCustomerStuff();
            //In C#, the static keyword is used to declare members of a class that belong to the class
            //itself rather than any specific instance of the class

            /*
            //Static fields
            Car car = new Car();
            Car car2 = new Car();
            Car car3 = new Car("A3","Audi",false);
            car3.Drive();

            //acessing the public static variable NumberOfCars of the Car Class
            Console.WriteLine("Number of cars produced: " + Car.NumberOfCars);
            */

            /*
            Customer customer1 = new Customer();
            Customer customer2 = new Customer("John Doe");
            Customer customer3 = new Customer();

            customer1.Getdetails();
            customer2.Getdetails();
            customer3.Getdetails();

            customer3.Password = "123456789@WEQa_!";

            Console.WriteLine("Customer3 id is: " + customer3.Id);
            */

            Rectangle rectangle1 = new Rectangle("Red");
            Rectangle rectangle2 = new Rectangle("Blue");

            rectangle1.DisplayDetails();
            rectangle2.DisplayDetails();


            Console.ReadKey();
        }

        /*
        static int AddNum(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
        */

    }
}
