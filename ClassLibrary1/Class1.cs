

public class Emplpoyee
{
    public int Salary;
}

public class Student
{
    public int Marks;
}

public class Sample
{
    public void PrintData<T>(T obj) where T : class
    {
        if (obj.GetType() == typeof(Student))
        {
            Student temp = obj as Student;
            Console.WriteLine(temp.Marks);
        }
        else if (obj.GetType() == typeof(Emplpoyee))
        {
            Emplpoyee temp = obj as Emplpoyee;
            Console.WriteLine(temp.Salary);
        }
    }


}