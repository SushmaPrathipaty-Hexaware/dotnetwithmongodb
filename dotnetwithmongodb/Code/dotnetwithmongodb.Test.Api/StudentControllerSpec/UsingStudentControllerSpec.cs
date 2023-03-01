using NSubstitute;
using dotnetwithmongodb.Test.Framework;
using dotnetwithmongodb.Api.Controllers;
using dotnetwithmongodb.BusinessServices.Interfaces;
using AutoMapper;


namespace dotnetwithmongodb.Test.Api.StudentControllerSpec
{
    public abstract class UsingStudentControllerSpec : SpecFor<StudentController>
    {
        protected IStudentService _studentService;
        protected IMapper _mapper;

        public override void Context()
        {
            _studentService = Substitute.For<IStudentService>();
            subject = new StudentController(_studentService,_mapper);

        }

    }
}
