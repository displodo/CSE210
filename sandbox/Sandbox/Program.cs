class Program {
    static void Main(string[] args) {
        Person p = new Person();
        Student s = new Student();
        Console.WriteLine(p.GetName());
        Console.WriteLine(s.GetName());
    }
}

class Person
{
    public string GetName() 
    {
        return "JR";
    }
}

class Student: Person
{

}
