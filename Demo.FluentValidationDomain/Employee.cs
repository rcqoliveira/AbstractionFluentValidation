using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.FluentValidationDomain
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime AdmissionDate { get; set; }
    }
}
