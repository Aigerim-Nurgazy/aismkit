﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AisMKIT.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int DepartmentsId { get; set; }   // Код департамента
        public Departments Departments { get; set; }
    }
}
