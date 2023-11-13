using Ef1.DAL;
using Ef1.Models;

namespace Ef1.Services;

public class StudentService
{
    private readonly AppDbContext _context=new();
    

    public List<Student> GetAllStudents()
    {
        var students = _context.Students.ToList();
        return students;
    }

    public void Create(Student student)
    {
        _context.Students.Add(student);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var student = GetById(id);

        if (student != null)
        {
            _context.Students.Remove(student);
            _context.SaveChanges();
        }
    }

    public Student GetById(int id)
    {
        var Student=_context.Students.FirstOrDefault(c=>c.Id==id);
        return Student;
    }
}
