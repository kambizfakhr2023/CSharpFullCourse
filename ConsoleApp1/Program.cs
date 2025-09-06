

class Student
{
    public string StudentName { get; set; }
}

class Program
{
    static void Main()
    {
        string y;
        dynamic x;
        

        x = 100;
        x = "Hello";

        x = new Student() { StudentName = "Harsha" };

        Console.WriteLine(x.StudentName);

        Console.ReadKey();

    }



}