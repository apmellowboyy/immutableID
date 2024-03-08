using System;
using System.ComponentModel.DataAnnotations;
namespace bruddah
{
    class Student
    {
        // auto-implemented properties
        public int Id { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }

        // default constructor
        public Student()
        {
            Id = 0;
            FirstName = "";
            LastName = "";
        }
        // parameterized constructor
        public Student(int i, string First, string Last)
        {
            Id = i;
            FirstName = First;
            LastName = Last;
        }
        public Student(int i)
        {
            Id = i;
            FirstName = string.Empty;
            LastName = string.Empty;
        }

        static void Main(string[] args)
        {
            Student student = new(9631, "Ethan", "Barnes");
            Console.WriteLine(student.Id);
            Console.WriteLine(student.FirstName);
            Console.WriteLine(student.LastName);
            Student student2 = new Student(1234, "Jerry", "Curls");
            Console.WriteLine(student2.Id);
            Console.WriteLine(student2.FirstName);
            Console.WriteLine(student2.LastName);
            

        }
    }
}