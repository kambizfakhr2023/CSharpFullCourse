// Loops

int number = 1;
string result = "Hello";
char character = 'o';
int j = 9;
int k = 0;

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