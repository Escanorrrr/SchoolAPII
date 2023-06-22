using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI;

[ApiController]
[Route("api/[controller]")]
public class StudentController : Controller
{
    private IStudentService _studentService;

    public StudentController(IStudentService studentService)
    {
        _studentService = studentService;
    }
    
    // GET
    [HttpPost("addStudent")]
    public IActionResult Add(Student student )
    {
        _studentService.Add(student);
        return Ok();
    }
   
}