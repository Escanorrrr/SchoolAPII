using Entities.Concrete;

namespace Business.Abstract;

public interface IStudentService
{
    List<Student> GetAll();
    void Add(Student student);
    void Delete(Student student);
    List<Student> GetbyAge();
}