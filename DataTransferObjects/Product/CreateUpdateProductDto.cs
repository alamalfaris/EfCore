using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObjects.Product
{
    public class CreateUpdateProductDto : BaseDto
    {
        public string Name { get; set; } = string.Empty;
        public string? Information { get; set; }

    }
}
