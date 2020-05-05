using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exceptions;

namespace Exceptions
{
    public class ExceptionCreatedbyMe :Exception
    {
        public ExceptionCreatedbyMe(string message) : base(message)      
        {
            
        }
    }
}
