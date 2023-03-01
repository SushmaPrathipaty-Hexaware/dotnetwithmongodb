using NSubstitute;
using dotnetwithmongodb.Test.Framework;
using dotnetwithmongodb.Api.Controllers;
using dotnetwithmongodb.Business.Interfaces;


namespace dotnetwithmongodb.Test.Api.StudentControllerSpec
{
    public abstract class UsingStudentControllerSpec : SpecFor<StudentController>
    {
        protected IStudentService _studentService;

        public override void Context()
        {
            _studentService = Substitute.For<IStudentService>();
            subject = new StudentController(_studentService);

        }

    }
}
