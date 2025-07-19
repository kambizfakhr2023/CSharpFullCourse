string userInput = "";

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
        Console.WriteLine("The user wants to see all TODOs.");
        break;
    case "A":
    case "a":
        Console.WriteLine("The user wants to Add a TODO.");
        break;
    case "R":
    case "r":
        Console.WriteLine("The user wants to remnove a TODO.");
        break;
    case "E":
    case "e":
        Console.WriteLine("The user wants to exit.");
        break;
    default:
        Console.WriteLine("Invalid input.");
        break;

}
Console.ReadKey();

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

Console.ReadKey();  

