using System.Reflection;
namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Box<int> box = new Box<int>();
            //box.Content = 1;
            //Console.WriteLine(box.Log());

            //Box<string> boxStr = new Box<string>();
            //boxStr.Content = "Hello world";
            //Console.WriteLine(boxStr.Log());

            //======================================///////////==========================//

            //Box<string> boxStr = new Box<string>("Hello World");
            //boxStr.UpdateContent("Teaching C# is fun?");
            //Console.WriteLine(boxStr.GetContent());

            //======================================///////////==========================//

            //Box<int, string> box = new Box<int, string>(100, "One Hundred");
            //box.Display();

            //======================================///////////==========================//

            //Logger logger = new Logger();

            //logger.Log<int>(10);
            //logger.Log<string>("Hello World");

            //logger.Log(new { Name = "John", Age = 30 });

            //======================================///////////==========================//
            //Generic Class Constrait
            //Box<int> box = new Box<int>();
            //Box<Book> bookBox = new Box<Book>();

            //======================================///////////==========================//

            //Repository<Product> repository = new Repository<Product>();
            //var product = new Product();
            //repository.Add(product);

            //======================================///////////==========================//
            //Generic Method Constrait
            //var productOne = new Product();
            //var productTwo = new Product();
            //var result = Comparer.AreEqual(productOne, productTwo);
            //Console.WriteLine(result);

            //======================================///////////==========================//
            //GENERIC REFELTIONS
            //Type type = typeof(ConfigurationManager<>);

            //string myName = "John";
            //if (myName.GetType() == typeof(string))
            //{ 
            //    // hey it s a string
            //}

            //======================================///////////==========================//
            //Action generic delegate (does not return a value)

            //Action action = () => { 
            //    Console.WriteLine("Hello World!");
            //};

            //action();

            //Action<int> numPrint = (x) =>
            //{
            //    Console.WriteLine(x);
            //};

            //numPrint(10);

            //Action<float, float, float> sum = (x, y, z) =>
            //{
            //    Console.WriteLine(x + y + z);
            //};

            //sum(1, 2, 3);

            //======================================///////////==========================//
            //Func generic delegate
            //Func<string> getName = () =>
            //{
            //    return "John";
            //};

            //var myName = getName();
            //Console.WriteLine(myName);

            //Func<int, int, string> sum = (x, y) =>
            //{
            //    return (x + y).ToString(); 
            //};

            //Console.WriteLine(sum(3,5));

            //======================================///////////==========================//
            //Predicate generic delegate (returns a bool value)
            Predicate<int> isEven = (x) =>
            {
                return x % 2 == 0;
            };

            List<int> ints = new List<int>() {1,2,3,4,5,6,7,8};
            var evenInts = ints.FindAll(isEven);

            //Console.WriteLine(isEven(5));

            Console.ReadKey();
        }
    }

    internal class ConfigurationManager<T>
    {
        public T LoadedConfiguration { get; set; }

        public ConfigurationManager(T config)
        {
            LoadedConfiguration = config;
        }

        public static void SaveConfig(T configToSave)
        {
            //logic
        }
    }

    internal interface IEntity
    {
        int Id { get; }
    }

    internal interface IRepository<T> /*where T : IEntity*/
    {
        void Add(T entity);
        void Remove(T entity);
    }

    internal class Product //: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    internal class User : IEntity 
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    //Generic Interfaces--Generic Constraint Interfaces

    internal class Repository<T> : IRepository<T> 
    {
        public void Add(T entity)
        {
        
        }

        public void Remove(T entity)
        {

        }
    }

    //

    internal class ProductRepository : IRepository<Product> 
    {
        public void Add(Product entity)
        {

        }

        public void Remove(Product entity)
        {

        }
    }

    internal class UserRepository : IRepository<User>
    {
        public void Add(User entity)
        {

        }

        public void Remove(User entity)
        {

        }
    }

    //class Product : IEntity
    //{
    //    public int Id { get; }
    //}

    class Book 
    {

    }

}
