/*
//======================================== "Count up" =============================================
for (int counter = 5; counter <= 10; counter++)
{
    Console.WriteLine("Counter is " +counter);
}

Console.ReadKey();
*/

/*
//in string / is an "Escape Character"
// \n stands for "new line"
// \r -carriage return

string myString = "Hi \r\nHi";

//======================================== "Count Down" =============================================
for (int counter = 10; counter >= 0; counter--)
{
    Console.WriteLine("Counter is " + counter);
    Console.WriteLine(myString);
    Thread.Sleep(1000);
}

Console.ReadKey();
*/


/*
//======================================== "Rocket Animation" =============================================
string rocket = "    |\n   /_\\\n   |_|\n  /___\\\n   VvV";

for (int i = 10; i > 0; i--)
{
    Console.Clear();
    Console.WriteLine("Counter is " + i);
    Console.WriteLine(rocket);
    rocket = "\r\n" + rocket;
    Thread.Sleep(1000);
}
Console.WriteLine("\nRocket has Landed!");
Console.ReadKey();
*/

//The while loop
/*
int counter = 0;
bool isGood = true;

Console.WriteLine("Enter go or stay");

string userChoice = Console.ReadLine();

while (userChoice == "go")
{
    Console.WriteLine("Gor for a mile!");
    Console.WriteLine("Wanna keep going? Enter go");
    userChoice = Console.ReadLine();
}
Console.WriteLine("Finally you are staying!");

Console.ReadKey();
*/

//======================================== "Guess the number" =============================================
/*
Random random = new Random();

int secretNumber = random.Next(1, 101);
int userGuess = 0;
int counter = 0;

Console.WriteLine("Guess the number that I'm thinking between 1 and 100");

while (userGuess != secretNumber)
{

    Console.WriteLine("Enter your guess:");
    userGuess = int.Parse(Console.ReadLine());
    if (userGuess < secretNumber)
    {
        Console.WriteLine("Too low! Try again");
        counter++;
    }
    else if (userGuess > secretNumber)
    {
        Console.WriteLine("Too high! Try again");
        counter++;
    }
    else
    {
        Console.WriteLine("Congratulations! You guessed the number correctly!It took you " + counter + " tries!");
    }
}
Console.ReadLine();
*/

//======================================== "Adventure Game" =============================================

/*
Console.WriteLine("Welcome to the Adventure Game!");
Console.WriteLine("Enter your character's name ");
string playerName = Console.ReadLine();
Console.WriteLine("Choose your character type (Warrior, Wizard ,Archer)");
string characterType = Console.ReadLine();

Console.WriteLine($"You, {playerName} the {characterType} find yourself at the edge of a dark florest");
Console.WriteLine("Do you enter the forest or do you camp outisde(Enter/Camp)");
string choice1 = Console.ReadLine();

if (choice1.ToLower() == "enter")
{
    Console.WriteLine("You bravely enter the forest");
}
else
{
    Console.WriteLine("You decide to camp put and wait for daylight.");
}

bool gameContinues = true;

while (gameContinues)
{
    Console.WriteLine("You come to a fork in the road. Go left or right?");
    string direction = Console.ReadLine();
    if (direction.ToLower() == "left")
    {
        Console.WriteLine("You find a treasure chest!");
        gameContinues = false;
    }
    else 
    {
        Console.WriteLine("You encounter a wild beast!");
        Console.WriteLine("Fight or flee? (Fight/Flee)");
        string fightChoice = Console.ReadLine();
        if (fightChoice.ToLower() == "fight")
        {
            Random random = new Random();
            int luck = random.Next(1, 11);
            if (luck > 5)
            {
                Console.WriteLine("You beat the wild beast");
                if (luck > 8)
                {
                    Console.WriteLine("The wild beat dropped a treasure");
                }
            }
            else 
            {
                Console.WriteLine("You died!");
                gameContinues = false;
            }
        }

    }
}

Console.WriteLine("Game Over!");
Console.WriteLine("Thank you for playing game!");

Console.ReadKey();
*/

//======================================== Do while =============================================
//do while loop is a post-test loop
/*
int number;

do
{
    Console.WriteLine("Enter a positive whole number");
    number = int.Parse(Console.ReadLine());
} while (number <= 0);
Console.WriteLine("Finally!");
Console.ReadKey();
*/

//Average Calculator
/*
int currentscore;
int sum = 0;
int counter = 0;

do
{
    Console.WriteLine("Enter your students score. Enter -1 to finish");
    currentscore = int.Parse(Console.ReadLine());
    if (currentscore != -1)
    {
        sum = sum + currentscore;
        counter++;
    }
} while (currentscore != -1);

int average = sum / counter;

Console.WriteLine("The average is: " + average);
Console.ReadKey();
*/

//======================================== Break and Continue =============================================

for (int i = 0; i < 4; i++)
{
    Console.WriteLine(i);
    if (i == 2)
    {
        //Console.WriteLine("I have had enough");
        continue;
    }
    Console.WriteLine(i);
}


Console.ReadKey();

