

Sample sample = new Sample();
Emplpoyee emp = new Emplpoyee() { Salary = 1000 };
Student stu = new Student() { Marks = 80 };

sample.PrintData<Emplpoyee>(emp);
sample.PrintData<Student>(stu);

Console.ReadKey();