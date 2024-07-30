using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.Domain.Exceptions
{
    public class NotNPCException : BusinessException
    {
        public NotNPCException() : base(ErrorCodes.InvalidObject, "It is only possible to calculate payment slips of type NPC.") { }
    }
}
