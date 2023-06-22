using Business.Abstract;
using Business.Message;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
namespace WebAPII.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StudentController : Controller
{
    private readonly IStudentService _studentService;
    public StudentController(IStudentService studentService)
    {
        _studentService = studentService;
    }
    // GET
    [HttpPost("addStudent")]
    public IActionResult Add(Student student)
    {
        _studentService.Add(student);
        return Ok();
    }
    [HttpPost("deletedStudent")]
    public IActionResult Delete(Student student)
    {
        _studentService.Delete(student);
        return Ok();
    }
    [HttpGet("getStudents")]
    public IActionResult GetAll()
    {
       var result = _studentService.GetAll();
       return Ok(result);
    }

    [HttpGet("getStudentsByAge")]
    public IActionResult GetByAge()
    {
      var result = _studentService.GetbyAge();
      return Ok(result);
    }
}