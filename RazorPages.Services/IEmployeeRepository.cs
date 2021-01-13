﻿using RazorPages.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPages.Services
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
    }
}
