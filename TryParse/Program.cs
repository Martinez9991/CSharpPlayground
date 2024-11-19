
//Creating an instance of Random Class
Random random = new Random();
// this will give us a random number between 1 and 10
int randomNumber = random.Next(1, 11);

Console.WriteLine("Give me a number");
string inputString = Console.ReadLine();
int num1 = 0;

bool isNumber = int.TryParse(inputString, out num1);

if (isNumber)
{
    if (num1 == randomNumber)
    {
        Console.WriteLine("You guessed right!");
    }
    else
    {
        Console.WriteLine("You guessed wrong! Try again");
    }
    Console.WriteLine("Well done you have entered a number!");
}
else
{
    Console.WriteLine("This is not a number!");
}

num1++;
Console.WriteLine("User entered number + 1 " +num1);

Console.ReadKey();