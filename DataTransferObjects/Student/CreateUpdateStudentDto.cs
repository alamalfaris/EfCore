using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObjects.Student
{
    public class CreateUpdateStudentDto
    {
        public string Name { get; set; } = string.Empty;
        public int Grade { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedTime { get; set; } = DateTime.Now;
    }
}
