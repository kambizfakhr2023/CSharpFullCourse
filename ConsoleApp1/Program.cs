// Loops

int number = 1;
string result = "Hello";
char character = 'o';
int j = 9;
int k = 0;
int[][] jaggedArray = new int[4][];

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