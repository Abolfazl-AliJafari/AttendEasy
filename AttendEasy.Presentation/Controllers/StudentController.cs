using AttendEasy.Application.Interfaces;
using AttendEasy.Domain.Entities.Studentes;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AttendEasy.Presentation.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        //private readonly UserManager<Student> _userManager;

        public StudentController(IStudentService StudentService,
            UserManager<Student> userManager)
        {
            _studentService = StudentService;
            //_userManager = userManager;
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

        public IActionResult Register(Student Student)
        {
            return View();
        }
    }
}
