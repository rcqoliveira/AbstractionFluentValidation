using Demo.FluentValidation;
using Demo.FluentValidation.Interface;
using Demo.FluentValidationDomain;
using NUnit.Framework;
using System;

namespace Demo.FluentValidationTest
{
    [TestFixture]
    public class EmployeeValidatorTest
    {
        private IValidator<Employee> _validator;

        [SetUp]
        public void SetUp()
        {
            _validator = new EmployeeValidator();
        }

        [Test]
        public void WhenHaveCompany_ShouldHaveNoError()
        {
            var employee = new Employee { Id = 1, Name = "Bill Gate", BirthDate = DateTime.Today, AdmissionDate = DateTime.Now };
            _validator.Validate(employee);
            Assert.IsTrue(_validator.IsValid);
        }
    }
}
