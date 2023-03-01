using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NSubstitute;
using Shouldly;
using dotnetwithmongodb.Entities.Entities;

namespace dotnetwithmongodb.Test.Business.StudentServiceSpec
{
    public class When_getting_all_student : UsingStudentServiceSpec
    {
        private IEnumerable<Student> _result;

        private IEnumerable<Student> _all_student;
        private Student _student;

        public override void Context()
        {
            base.Context();

            _student = new Student{
                studentname = "studentname"
            };

            _all_student = new List<Student> { _student};
            _studentRepository.GetAll().Returns(_all_student);
        }
        public override void Because()
        {
            _result = subject.GetAll();
        }

        [Test]
        public void Request_is_routed_through_repository()
        {
            _studentRepository.Received(1).GetAll();

        }

        [Test]
        public void Appropriate_result_is_returned()
        {
            _result.ShouldBeOfType<List<Student>>();

            List<Student> resultList = _result as List<Student>;

            resultList.Count.ShouldBe(1);

            resultList.ShouldBe(_all_student);
        }
    }
}
