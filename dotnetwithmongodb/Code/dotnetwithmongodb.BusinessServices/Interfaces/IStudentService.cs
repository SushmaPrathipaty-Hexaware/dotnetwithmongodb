using dotnetwithmongodb.BusinessEntities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetwithmongodb.BusinessServices.Interfaces
{
    public interface IStudentService
    {      
        IEnumerable<Student> GetAll();
        Student Get(string id);
        Student Save(Student classification);
        Student Update(string id, Student classification);
        bool Delete(string id);

    }
}
