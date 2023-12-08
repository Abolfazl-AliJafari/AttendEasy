using AttendEasy.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AttendEasy.Presentation.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService StudentService)
        {
            _studentService = StudentService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [Route("students/show")]
        public IActionResult GetList()
        {
            var students = _studentService.GetList();
            return View(students);
        }
    }
}
