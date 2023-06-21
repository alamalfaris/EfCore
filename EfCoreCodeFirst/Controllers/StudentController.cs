using DataTransferObjects.Student;
using EfCoreCodeFirst.Repository.Student;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace EfCoreCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CreateStudent(CreateUpdateStudentDto request)
        {
            await _studentRepository.CreateStudent(request);

            return Ok(request);
        }
    }
}
