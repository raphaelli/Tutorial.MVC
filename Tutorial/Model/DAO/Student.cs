using System;
using System.ComponentModel.DataAnnotations;
using Tutorial.Model.DAO;

namespace Tutorial.Model
{
    public class Student
    {
        [Key]
        public int stuId { get; set; }
        [Required]
        public string stuFirstName { get; set; }
        [Required]
        public string stuLastName { get; set; }
        public DateTime stuBirthDate { get; set; }
        public Gender stuGender { get; set; }

    }
}
