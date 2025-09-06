

Person p1 = new Person() { NoOfChildren = 2 };
Person p2 = new Person() { NoOfChildren = null };
Person p3 = new Person() { NoOfChildren = null };

Console.WriteLine(p1.NoOfChildren);

//With If block
//if (p2.NoOfChildren.HasValue)
//{
//    int x = p2.NoOfChildren.Value;
//    Console.WriteLine(x);
//}

//With trinary
//Console.WriteLine((p2.NoOfChildren.HasValue) ? p2.NoOfChildren.Value : 0);

//With coalescing
Console.WriteLine(p2.NoOfChildren ?? 0);

//With propagation
//Console.WriteLine(p2?.NoOfChildren);

Console.ReadKey();