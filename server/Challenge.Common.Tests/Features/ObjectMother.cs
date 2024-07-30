using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.Common.Tests.Features.ObjectMother
{
    public partial class ObjectMother
    {
        /** Example method **/
        public static Object GetNewEmptyObject()
        {
            return new Object()
            {
                // name = "",
                // Age = 0,
            };
        }

    }
}
