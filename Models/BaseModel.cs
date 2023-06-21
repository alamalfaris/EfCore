using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BaseModel
    {
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedTime { get; set; }
    }
}
