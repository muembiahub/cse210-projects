using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Person person = new Person();
        Student student = new Student();
        string name = person.GetName();
        string studentId = student.GetStudentId();
        
        Console.WriteLine($"Name: {name}");
        Console.Write("\b \b");
        Console.WriteLine($"Student ID: {studentId}");
       
    }
}
class Person
{
    public string GetName()
    {
        return "Jonathan";
    }
}
class Student : Person
{
    public string GetStudentId()
    {
        return "123456";
    }
}