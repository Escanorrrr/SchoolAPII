using System.Data.SqlClient;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete;

public class EfStudentDal:IStudentDal
{
    
    
    public List<Student> GetAll()
    {
        using (SchoolContext context = new SchoolContext())
        {
            List<Student> students = context.Students.ToList();
            return students;
        }
    }
            //dotnet new nugetconfig
    public void Add(Student student)
    {
        using (SchoolContext context = new SchoolContext())
        {
            var addedStudent = context.Entry(student);
            addedStudent.State = EntityState.Added;
            context.SaveChanges();

        }
    }

    public void Delete(Student student)
    {
        using (SchoolContext context = new SchoolContext())
        {
            var deletedStudent = context.Entry(student);
            deletedStudent.State = EntityState.Deleted;
            context.SaveChanges();
        }
    }

    public List<Student> GetbyAge()
    {
        using (SchoolContext context = new SchoolContext())
        {
            List<Student> students = context.Students.OrderByDescending(s => s.Age).ToList();
            return students;
        }
    }
}