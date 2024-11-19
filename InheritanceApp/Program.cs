namespace InheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            //Dog myDog = new Dog();
            //myDog.MakeSound();
            ////myDog.Eat();
            //Cat myCat = new Cat();
            //myCat.MakeSound();
            

            //Employee joe = new Employee("Joe", 36,"Sales Rep",1234);
            //joe.DisplayEmployeeInfo();
            Manager carl = new Manager("Carl",45, "Manager",123123,7);
            //carl.DisplayManagerInfo();
            carl.BecomeOlder(5);
            carl.DisplayPersonInfo();

            Console.WriteLine(carl.ToString()); 

            Console.ReadKey();

        }
    }
}
