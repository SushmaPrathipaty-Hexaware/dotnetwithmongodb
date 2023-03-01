using NSubstitute;
using dotnetwithmongodb.Test.Framework;
using dotnetwithmongodb.Business.Services;
using dotnetwithmongodb.Data.Interfaces;

namespace dotnetwithmongodb.Test.Business.StudentServiceSpec
{
    public abstract class UsingStudentServiceSpec : SpecFor<StudentService>
    {
        protected IStudentRepository _studentRepository;

        public override void Context()
        {
            _studentRepository = Substitute.For<IStudentRepository>();
            subject = new StudentService(_studentRepository);

        }

    }
}
