using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Models;
using RazorPages.Services;

namespace RazorPages.Pages.Employees
{
    public class DetailsModel : PageModel
    {
        private readonly IEmployeeRepository _employeeRepository;

        public DetailsModel(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public Employee Employees { get; private set; }

        public IActionResult OnGet(int id)
        {
            Employees = _employeeRepository.GetEmployee(id);

            if (Employees == null)
                return RedirectToPage("/NotFound");
            return Page();
        }
    }
}
