using System;
using System.Collections.Generic;
using System.Linq;
using Tutorial.Model;
using Tutorial.Model.DAO;
using Tutorial.Model.DTO;

namespace Tutorial.Services
{
    public class InMemoryRepository : IRepository<Student>
    {
        private readonly List<Student> _students;

        public InMemoryRepository()
        {
            _students = new List<Student>
            {
                new Student
                {
                    stuId = 1001,
                    stuFirstName = "Li",
                    stuLastName = "Muzi",
                    stuBirthDate = new DateTime(1996,8,29),
                    stuGender = Gender.男
                },
                new Student
                {
                    stuId = 1002,
                    stuFirstName = "Xiao",
                    stuLastName = "Qiqi",
                    stuBirthDate = new DateTime(1996,8,31),
                    stuGender = Gender.女
                },
                new Student
                {
                    stuId = 1003,
                    stuFirstName = "La",
                    stuLastName = "Lala",
                    stuBirthDate = new DateTime(2008,8,8),
                    stuGender = Gender.保密
                }
            };
        }

        public Student Add(Student newModel)
        {
            var maxId = _students.Max(x => x.stuId);
            newModel.stuId = maxId + 1;
            _students.Add(newModel);
            return newModel;
        }

        public IEnumerable<Student> GetAll()
        {
            return _students;
        }

        public Student GetById(int id)
        {
            return _students.FirstOrDefault(x=> x.stuId == id);
        }
    }
}
