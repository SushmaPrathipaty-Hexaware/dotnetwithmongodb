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
    public class When_saving_student : UsingStudentControllerSpec
    {
        private ActionResult<Student> _result;

        private Student _student;

        public override void Context()
        {
            base.Context();

            _student = new Student
            {
                studentname = "studentname"
            };

            _studentService.Save(_student).Returns(_student);
        }
        public override void Because()
        {
            _result = subject.Save(_student);
        }

        [Test]
        public void Request_is_routed_through_service()
        {
            _studentService.Received(1).Save(_student);

        }

        [Test]
        public void Appropriate_result_is_returned()
        {
            _result.Result.ShouldBeOfType<OkObjectResult>();

            var resultListObject = (_result.Result as OkObjectResult).Value;

            resultListObject.ShouldBeOfType<Student>();

            var resultList = (Student)resultListObject;

            resultList.ShouldBe(_student);
        }
    }
}
