using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NSubstitute;
using Shouldly;
using dotnetwithmongodb.BusinessEntities.Entities;

namespace dotnetwithmongodb.Test.Business.StudentServiceSpec
{
    public class When_saving_student : UsingStudentServiceSpec
    {
        private Student _result;

        private Student _student;

        public override void Context()
        {
            base.Context();

            _student = new Student
            {
                studentname = "studentname"
            };

            _studentRepository.Save(_student).Returns(true);
        }
        public override void Because()
        {
            _result = subject.Save(_student);
        }

        [Test]
        public void Request_is_routed_through_repository()
        {
            _studentRepository.Received(1).Save(_student);

        }

        [Test]
        public void Appropriate_result_is_returned()
        {
            _result.ShouldBeOfType<Student>();

            _result.ShouldBe(_student);
        }
    }
}
