/*
char myFavoriteCharacter = '$';
Console.WriteLine(myFavoriteCharacter);

// Operators and Order of Evaluation
int num1 = 5;
//int num2 = 13;
Console.WriteLine("Enter a whole number");
int num2 = int.Parse(Console.ReadLine());

//Concatination
Console.WriteLine("Age is " + num1);

Console.WriteLine("Addition num1 + num2 = " + (num1 + num2));
//Order of Evaluation
Console.WriteLine("Subtraction num1 - num2 = " + (num1 - num2));
//Subtraction num1 - num2  = 5 - 13
Console.WriteLine("Multiplication num1 * num2 = " + num1 * num2);
Console.WriteLine("Division num1 / num2 = " +  num1 / num2);
Console.ReadLine();
*/

//======================================== String Formatting =============================================

/*
int num = 10;
double price = 19.99;
string name = "John";

//String Interpolation
Console.WriteLine($"The number is {num}");
// String Concatination
Console.WriteLine("The number is "+ num);
//String Formatting
Console.WriteLine("The number is {0} and the price is {1} and the name is {2}", num, price, name);
Console.ReadKey();
*/


//Special Characters in strings with the escape char
string s1 = "this is a \"string\" with \na back slash \\ and a colon ";
Console.WriteLine(s1);
Console.ReadLine(); 
