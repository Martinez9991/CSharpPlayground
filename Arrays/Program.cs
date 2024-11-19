
int num1 = 0;
int num2 = 0;
int num3 = 0;
int num4 = 0;
int num5 = 0;

/*
// declare an array
int[] myIntArray = new int[5];

// assigned values into the array
myIntArray[0] = 5;
myIntArray[1] = 12;
myIntArray[2] = 13;
myIntArray[3] = 14;
myIntArray[4] = 15;

Console.WriteLine(myIntArray[0]);

Console.ReadKey();
*/
//Indexes [0][ 1][2 ][ 3][ 4]
//Indexes [5][12][13][14][15]

/*
// declare an array and set the array element values
int[] myIntArray = [5,12,13,14,15];
string[] weekDays = ["monday","tuesday","wednesday","thrusday","friday","saturday","sunday"];

Console.WriteLine("Length of weekdays Array is: " + weekDays.Length);

foreach (string day in weekDays)
{
    Console.WriteLine(day);
}

Console.ReadKey();
*/

// 2dimensional arrays

int[,] array2DDeclaration = new int[3, 3];
// [0] [0] [0]
// [0] [0] [0]
// [0] [0] [0]

int[,,] array3DDeclaration = new int[3, 3, 3];

int[,]  array2DInitialized = { {1,2}, {3,4}};

// [1] [2] // row 0
// [3] [4] // row 1

string[,] ticTacToeField =
{
    {"O","X","X"},
    {"O","O","X"},
    {"X","X","O"}
};

string[,] understandingIndexes =
{
    {"0,0","0,1","0,2"},
    {"1,0","1,1","1,2"},
    {"2,0","2,1","2,2"}
};

Console.WriteLine(ticTacToeField[1,2]);

Console.WriteLine(array2DInitialized[0,0]);

Console.WriteLine(understandingIndexes[1, 2]);

Console.WriteLine(ticTacToeField[1, 2]);
array2DInitialized[0, 0] = 5;
Console.WriteLine(array2DInitialized[0, 0]);

Console.ReadKey();

//3dimensional arrays

//initializaed 3d array
/*
string[,,] simple3D =
{
    {
        {"000", "001"},
        {"010", "011"}
    },
    {
        {"100", "101"},
        {"110", "111"}
    },
    {
        {"200", "201"},
        {"210", "211"}
    }
};

//assign value 
simple3D[2, 1, 0] = "Hi, what is up?";

Console.WriteLine(simple3D[2,1,0]);

Console.ReadKey();
*/