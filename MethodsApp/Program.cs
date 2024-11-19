//Methods are structed like this
// modifier returnType MethodName(Parameters){
//code block
//}

/*
// Definition of a void method that returns nothing
void MyfirstMethod()
{
    Console.WriteLine("MyFirstMethod was called");
    Console.WriteLine("Complicated Code!");
}

//Calling a Method
MyfirstMethod();

Console.WriteLine("This is outside of the method");

void WriteSomething() 
{
    Console.WriteLine("I'm writting something!");
}

WriteSomething();

// A method that has the parameter myString of type String
//Method declaration
void WriteSomethingSpecific(string myString)
{
    Console.WriteLine("You passed this argument to me " + myString);
}

string myUsername = "Joao";

//Calling the method using an Argument called "myUserName"
WriteSomethingSpecific(myUsername);

Console.ReadKey();
*/

int myResult;

int AddTwoValues(int value1, int value2)
{ 
    int result = value1 + value2;
    myResult = result;
    return result;
}

int SubtractTwoValues(int value1, int value2)
{
    int result = value1 - value2;
    return result;
}


Console.WriteLine("Enter a number, I'll add 10 to it!");
int num1 = int.Parse(Console.ReadLine());


myResult= AddTwoValues(num1,10);
Console.WriteLine("The result is " + myResult);

Console.ReadKey();