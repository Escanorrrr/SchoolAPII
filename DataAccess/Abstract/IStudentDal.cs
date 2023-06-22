using Entities.Concrete;

namespace DataAccess.Abstract;

public interface IStudentDal
{
    List<Student> GetAll();
    void Add(Student student);
    void Delete(Student student);
    List<Student> GetbyAge();
}