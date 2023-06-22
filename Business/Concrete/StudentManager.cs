using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class StudentManager:IStudentService
{
    IStudentDal _studentDal;

    public StudentManager(IStudentDal studentDal)
    {
        _studentDal = studentDal;
    }
    public List<Student> GetAll()
    {
        return _studentDal.GetAll();
    }

    public void Add(Student student)
    {
        _studentDal.Add(student);
    }

    public void Delete(Student student)
    {
        _studentDal.Delete(student);
    }

    public List<Student> GetbyAge()
    {
       return _studentDal.GetbyAge();
        
    }
}