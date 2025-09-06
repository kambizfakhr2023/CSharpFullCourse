

ParentClass pc;

pc = new ChildClass() { x = 10, y = 20 };

//Console.WriteLine(pc.x);
//Console.WriteLine(pc.y);

//if (pc is ChildClass)
//{
//    ChildClass cc = (ChildClass)pc;
//    Console.WriteLine(cc.x);
//    Console.WriteLine(cc.y);
//}

if (pc is ChildClass cc)
{
    Console.WriteLine(cc.x);
    Console.WriteLine(cc.y);
}


Console.ReadKey();