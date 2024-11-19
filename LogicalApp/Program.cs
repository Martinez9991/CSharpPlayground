int month = 5;
string monthName;

if (month == 1)
{
    monthName = "January";
}
else if (month == 2)
    monthName = "February";
else if (month == 3)
    monthName = "March";
else
    monthName = "Unknown";

switch (month)
{
    case 1:
        monthName = "January";
        break;
    case 2:
        monthName = "February";
        break;
    case 3:
        monthName = "March";
        break;
    default:
        monthName = "Unknown";
        break;
}

Console.WriteLine($"The month is {monthName}");
Console.ReadKey();

//==============================================//=====================================================//

/*
int num1 = 0;
int num2 = 0;
int age = 0;
string address;

bool isEqual = num1 == num2;
bool isNotEqual = num1 != num2;

Console.WriteLine("Please enter a whole number");

if (num1 == int.Parse(Console.ReadLine()))
{
    Console.WriteLine("Numbers are equal!");
    Console.WriteLine("Please enter your age!");
    age = int.Parse(Console.ReadLine());
    if (age >=18)
    {
        Console.WriteLine("Please enter your address,so that we can send you the prize!");
        address = Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Sorry, you can't get your prize due to your age");
    }
}
else
{
    Console.WriteLine("Numbers aren't equal!");
}

Console.ReadKey();
*/

//==============================================//=====================================================//

/*
Console.WriteLine("How old are you? Write a whole number");
int age = int.Parse(Console.ReadLine());
//bool isWithParents = false;

if (age >= 18) 
{
    Console.WriteLine("Go party in the club!");

}else if (age >= 13)
 {
    Console.WriteLine("Are you with your parents? Answer with y/n");
    string isWithParentsString = Console.ReadLine();
    if (isWithParentsString == "y")
    {
        Console.WriteLine("Go party in the club with your Parents!");
    }
    else 
    {
        Console.WriteLine("No party for you today!");
    }
 } 
 else
 {
    Console.WriteLine("Go play in the Kindergarden!");
 }

Console.ReadKey();
*/

//==============================================//=====================================================//

/*
int num1 = 5;
int num2 = 6;

//relational operator < <= > >=
//
bool isGreater = num1 > num2;
int age = 7;

if (age >= 18) 
{
    Console.WriteLine("Go party in the club!");
}
*/

//==============================================//=====================================================//

/*
bool isRainy = true;
bool hasUmbrella = false;

//Logical Operators
// AND &&
// OR ||
// NOT !

//Variants of OR Statments
// true || true -> True
// true || false -> True
// false || true -> True
// false || false -> False

//Variants of AND operator/Statments
// true && true -> True
// true && false -> false
// false && true -> false
// false && false -> False

if (isRainy && !hasUmbrella) 
{
    Console.WriteLine("I'm getting wet!");
}
Console.WriteLine("Ay OK!");

Console.ReadKey();
*/
