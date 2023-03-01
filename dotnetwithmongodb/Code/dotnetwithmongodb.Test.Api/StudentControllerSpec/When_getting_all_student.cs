using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NSubstitute;
using Shouldly;
using Microsoft.AspNetCore.Mvc;
using dotnetwithmongodb.Entities.Entities;
using dotnetwithmongodb.Api.Controllers;
using dotnetwithmongodb.BusinessServices.Interfaces;

namespace dotnetwithmongodb.Test.Api.StudentControllerSpec
{
    public class When_getting_all_student : UsingStudentControllerSpec
    {
        private ActionResult<IEnumerable<Student>> _result;

        private IEnumerable<Student> _all_student;
        private Student _student;

        public override void Context()
        {
            base.Context();

            _student = new Student{
                studentname = "studentname"
            };

            _all_student = new List<Student> { _student};
            _studentService.GetAll().Returns(_all_student);
        }
        public override void Because()
        {
            _result = subject.Get();
        }

        [Test]
        public void Request_is_routed_through_service()
        {
            _studentService.Received(1).GetAll();

        }

        [Test]
        public void Appropriate_result_is_returned()
        {
            _result.Result.ShouldBeOfType<OkObjectResult>();

            var resultListObject = (_result.Result as OkObjectResult).Value;

            resultListObject.ShouldBeOfType<List<Student>>();

            List<Student> resultList = resultListObject as List<Student>;

            resultList.Count.ShouldBe(1);

            resultList.ShouldBe(_all_student);
        }
    }
}
