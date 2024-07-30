using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.Domain.Exceptions
{
    public class NotExpiredYetException : BusinessException
    {
        public NotExpiredYetException() : base(ErrorCodes.InvalidObject, "Slip has not yet passed the due date") { }
    }
}
