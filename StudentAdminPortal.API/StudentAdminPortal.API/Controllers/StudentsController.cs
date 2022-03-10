using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentAdminPortal.API.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentAdminPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IStudentRepository studentRepository;
        public StudentsController(IStudentRepository studentRepository, IMapper mapper)
        {
            this.studentRepository = studentRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetAllStudents() {
            var students = await studentRepository.GetStudents();
            return Ok(mapper.Map<List<DomainModels.Student>>(students));
        }

    }
}
