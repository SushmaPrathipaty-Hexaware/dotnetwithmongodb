using dotnetwithmongodb.BusinessServices.Interfaces;
using dotnetwithmongodb.Data.Interfaces;
using dotnetwithmongodb.BusinessEntities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetwithmongodb.BusinessServices.Services
{
    public class StudentService : IStudentService
    {
        IStudentRepository _StudentRepository;

        public StudentService(IStudentRepository StudentRepository)
        {
           this._StudentRepository = StudentRepository;
        }
        public IEnumerable<Student> GetAll()
        {
            return _StudentRepository.GetAll();
        }

        public Student Get(string id)
        {
            return _StudentRepository.Get(id);
        }

        public Student Save(Student Student)
        {
            _StudentRepository.Save(Student);
            return Student;
        }

        public Student Update(string id, Student Student)
        {
            return _StudentRepository.Update(id, Student);
        }

        public bool Delete(string id)
        {
            return _StudentRepository.Delete(id);
        }

    }
}
