
int myNumber = 18;
bool myBoolean = false;

myBoolean = (myNumber > 10) ? true : false;
if (myBoolean)
    Console.WriteLine("Number is grater than 10");
else Console.WriteLine("Number is lower than 10");

int firstNumber = 5;
int secondNumber = 2;

Console.WriteLine("Sum is:" + (firstNumber+secondNumber));
Console.WriteLine("Sum is:" + (firstNumber - secondNumber));
Console.WriteLine("Mul is:" + firstNumber*secondNumber);
Console.WriteLine("Div is:" + firstNumber/secondNumber);
Console.WriteLine("Rem is:" + firstNumber % secondNumber);


Console.ReadKey();