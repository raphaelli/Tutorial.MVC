using System;
using System.ComponentModel.DataAnnotations;
using Tutorial.Model.DAO;

namespace Tutorial.Model.DTO
{
    public class StudentCreate
    {
        public int stuId { get; set; }

        [Display(Name = "名"),Required,MaxLength(10)]
        public string stuFirstName { get; set; }

        [Display(Name = "姓"), Required, MaxLength(10)]
        public string stuLastName { get; set; }

        [Display(Name = "生日")]
        public DateTime stuBirthDate { get; set; }

        [Display(Name = "性别")]
        public Gender stuGender { get; set; }
    }
}
