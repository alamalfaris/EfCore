﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObjects.Student
{
    public class CreateUpdateStudentDto : BaseDto
    {
        public string Name { get; set; } = string.Empty;
        public int Grade { get; set; }
    }
}
