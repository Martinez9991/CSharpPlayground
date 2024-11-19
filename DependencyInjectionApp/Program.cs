namespace DependencyInjectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hammer hammer = new Hammer(); // Create the dependencies outside
            //Saw saw = new Saw();
            ////Builder builder = new Builder(hammer,saw);
            //Builder builder = new Builder();
            ////builder.Hammer = hammer; // Inject dependencies via Setters
            ////builder.Saw = saw; // Inject dependencies via Setters
            //builder.SetHammer(hammer);
            //builder.SetSaw(saw);
            //builder.BuildHouse();

            MultiFunctionPrinter printer = new MultiFunctionPrinter();
            printer.Print();
            printer.Scan();


            Console.ReadKey();
        }
    }
}
