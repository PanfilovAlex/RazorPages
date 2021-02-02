using RazorPages.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RazorPages.Services
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>
            {
                new Employee
                {
                    Id = 0, Name = "Mary", Email = "mary@example.com", Department = Dept.HR,
                    PhotoPath = "avatar2.png"
                },
                new Employee
                {
                    Id = 1, Name = "Tom", Email = "tom@example.com", Department = Dept.IT,
                    PhotoPath = "avatar3.png"
                },
                new Employee
                {
                    Id = 2, Name = "Nick", Email = "nick@example.com", Department = Dept.Payroll,
                    PhotoPath = "avatar4.png"
                },
                new Employee
                {
                    Id = 3, Name = "Shawn", Email = "shawn@example.com", Department = Dept.IT,
                    PhotoPath = "avatar5.png"
                },
                new Employee
                {
                    Id = 4, Name = "Moly", Email = "moly@example.com", Department = Dept.HR,
                    PhotoPath = "avatar2.png"
                },
                new Employee
                {
                    Id = 5, Name = "Pole", Email = "pole@example.com", Department = Dept.Payroll
                }
            };
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(x => x.Id == id);
        }
    }
}
