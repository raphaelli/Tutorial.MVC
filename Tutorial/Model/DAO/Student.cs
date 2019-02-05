﻿using System;
using Tutorial.Model.DAO;

namespace Tutorial.Model
{
    public class Student
    {
        public int stuId { get; set; }
        public string stuFirstName { get; set; }
        public string stuLastName { get; set; }
        public DateTime stuBirthDate { get; set; }
        public Gender stuGender { get; set; }

    }
}
