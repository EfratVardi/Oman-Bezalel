﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class EmployeeDto
    {

    
        public int IdEmployee { get; set; }
        public string FirstNameEmployee { get; set; }
        public string LastNameEmployee { get; set; }
        public Nullable<int> IdPosition { get; set; }
        public bool StatusEmployee { get; set; }

    }
}
