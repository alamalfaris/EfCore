using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
    public interface ILogMessage
    {
        public const string CreateSuccessMessage = "Create {0} success";
        public const string UpdateSuccessMessage = "Update {0} success";
    }
}
