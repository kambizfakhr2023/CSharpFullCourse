string userInput = "";
int point = 6;

Console.WriteLine("Hello!");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");



userInput = Console.ReadLine();

//Console.WriteLine("User input is" + userInput);

//if (userInput == "S")
//    Console.WriteLine("The user wants to see all TODOs.");
//else if (userInput == "A")
//    Console.WriteLine("The user wants to Add a TODO.");
//else if (userInput == "R")
//    Console.WriteLine("The user wants to remnove a TODO.");
//else if (userInput == "E")
//    Console.WriteLine("The user wants to exit.");
//else Console.WriteLine("Invalid input.");

switch (userInput)
{
    case "S":
    case "s":
        PrintSelectedOption("See all TODOs.");
        break;
    case "A":
    case "a":
        PrintSelectedOption("Add a TODO.");
        break;
    case "R":
    case "r":
        PrintSelectedOption("Remove a TODO.");
        break;
    case "E":
    case "e":
        PrintSelectedOption("Exit.");
        break;
    default:
        PrintSelectedOption("Invalid input!");
        break;

}
Console.ReadKey();

void PrintSelectedOption(string selectedOption)
{
    Console.WriteLine("Selected option: " + selectedOption);
}

//int x = 4;

//switch (x)
//{
//    case 1:
//        Console.WriteLine("one");
//        break;
//    case 2:
//        Console.WriteLine("two");
//        break;
//    case 3:
//        Console.WriteLine("three");
//        break;
//    default:
//        Console.WriteLine("!!!");
//        break;
//}

switch (point)
{
    case 10:
    case 9:
        Console.WriteLine("A");
        break;
    case 8:
    case 7:
    case 6:
        Console.WriteLine("B");
        break;
    case 5:
    case 4:
    case 3:
        Console.WriteLine("C");
        break;
    case 2:
    case 1:
        Console.WriteLine("D");
        break;
    case 0:
        Console.WriteLine("F");
        break;
    default:
        Console.WriteLine("!");
        break;

}

Console.ReadKey();  

