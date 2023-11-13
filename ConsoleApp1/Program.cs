using Ef1.DAL;
using Ef1.Models;
using Ef1.Services;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentService studentService = new();
            Student student = new Student
            {
                Name = "Nihat",
                Surname = "Comeback",
                AvgPoint = 101,

            };
            //studentService.Create(student);
            
            //studentService.Delete(6);
            
            //List<Student> students = studentService.GetAllStudents();
            
            //foreach(Student A in students)
            //{
            //    Console.WriteLine($"{A.Name} {A.Surname}");
            //}
            
            Student studentfind=studentService.GetById(1);
            Console.WriteLine($"{studentfind.Name} {studentfind.Surname}");

        }
    }
}