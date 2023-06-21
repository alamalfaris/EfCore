using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Student : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Grade { get; set; }
    }
}
