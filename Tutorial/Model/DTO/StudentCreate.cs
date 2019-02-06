using System;
using Tutorial.Model.DAO;

namespace Tutorial.Model.DTO
{
    public class StudentCreate
    {
        public string stuFirstName { get; set; }
        public string stuLastName { get; set; }
        public DateTime stuBirthDate { get; set; }
        public Gender stuGender { get; set; }
    }
}
