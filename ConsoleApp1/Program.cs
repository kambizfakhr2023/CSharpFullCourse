// Loops

int number = 1;
string result = "Hello";
char character = 'o';
int j = 9;
int k = 0;
int[][] jaggedArray = new int[4][];
int[] numbers = { 5, 6, 7, 17, 22 };
string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

while (number <= 10)
{
    Console.WriteLine(number);
    number++;
}

do
{
    result += character;
} while (result.Length < 25);

Console.WriteLine(result);

for (; j >= 0; j--)
{
    Console.WriteLine(j);
}

for (; k <= 10; k++)
{
    if ((k == 6) || (k == 7))
        continue;
    Console.WriteLine(k);
}

for (int row = 1; row <= 10; row++)
{
    for (int col = 1; col <= 10; col++)
    {
        Console.Write(row * col + " ");
    }
    Console.WriteLine();
}

jaggedArray[0] = new int[] { 0, 1, 2 };
jaggedArray[1] = new int[] { 6, 4 };
jaggedArray[2] = new int[] { 1, 7, 6, 8, 9 };
jaggedArray[3] = new int[] { 5 };

//int[][] jaggedArray = new int[3][];

//jaggedArray[0] = [1, 3, 5, 7, 9];
//jaggedArray[1] = [0, 2, 4, 6];
//jaggedArray[2] = [11, 22];

//var firstFromEnd = numbers[numbers.Length - 1];
//var secondFromEnd = numbers[numbers.Length - 2]

var firstFromEnd = numbers[^1];
var secondFromEnd = numbers[^2];

Console.WriteLine("First from end: " + firstFromEnd);
Console.WriteLine("Second from end: " + secondFromEnd);

foreach (string car in cars)
{
    Console.WriteLine(car);
}