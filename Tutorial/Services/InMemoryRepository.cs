using System;
using System.Collections.Generic;
using Tutorial.Model;

namespace Tutorial.Services
{
    public class InMemoryRepository : IRepository<Student>
    {
        public IEnumerable<Student> GetAll()
        {
            return new List<Student>
            {
                new Student
                {
                    stuId = 1001,
                    stuFirstName = "Li",
                    stuLastName = "Muzi",
                    stuBirthDate = new DateTime(1996,8,29)
                },
                new Student
                {
                    stuId = 1002,
                    stuFirstName = "Xiao",
                    stuLastName = "Qiqi",
                    stuBirthDate = new DateTime(1996,8,31)
                },
                new Student
                {
                    stuId = 1003,
                    stuFirstName = "La",
                    stuLastName = "Lala",
                    stuBirthDate = new DateTime(2008,8,8)
                }
            };
        }
    }
}
