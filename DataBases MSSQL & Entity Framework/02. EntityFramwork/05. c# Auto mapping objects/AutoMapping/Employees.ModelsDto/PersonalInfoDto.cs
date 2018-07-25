﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.ModelsDto
{
    public class PersonalInfoDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public DateTime birthDate { get; set; }
        public string Address { get; set; }

    }
}
