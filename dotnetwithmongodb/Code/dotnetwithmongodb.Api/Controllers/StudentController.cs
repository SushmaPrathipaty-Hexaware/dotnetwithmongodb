using System.Collections.Generic;
using dotnetwithmongodb.BusinessServices.Interfaces;
using dotnetwithmongodb.BusinessEntities.Entities;
using dotnetwithmongodb.Contracts.DTO;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace dotnetwithmongodb.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        IStudentService _StudentService;
        private readonly IMapper _mapper;
        public StudentController(IStudentService StudentService,IMapper mapper)
        {
            _StudentService = StudentService;
            _mapper = mapper;
        }

        // GET: api/Student
        [HttpGet]
        public ActionResult<IEnumerable<StudentDto>> Get()
        {
            var StudentDTOs = _mapper.Map<IEnumerable<StudentDto>>(_StudentService.GetAll());
            return Ok(StudentDTOs);
        }

        [HttpGet("{id}")]
        public ActionResult<StudentDto> GetById(string id)
        {
            var StudentDTO = _mapper.Map<StudentDto>(_StudentService.Get(id));
            return Ok(StudentDTO);
        }

        [HttpPost]
        public ActionResult<StudentDto> Save(Student Student)
        {
            var StudentDTOs = _mapper.Map<StudentDto>(_StudentService.Save(Student));
            return Ok(StudentDTOs);
        }

        [HttpPut("{id}")]
        public ActionResult<StudentDto> Update([FromRoute] string id, Student Student)
        {
            var StudentDTOs = _mapper.Map<StudentDto>(_StudentService.Update(id, Student));
            return Ok(StudentDTOs);
        }

        [HttpDelete("{id}")]
        public ActionResult<bool> Delete([FromRoute] string id)
        {
            bool res = _StudentService.Delete(id);
            if(res== false) return null;
            return Ok(res);

        }


    }
}
