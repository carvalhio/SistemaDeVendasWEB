using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVendasWeb.Services.Exceptions
{
    public class IntegrityExcepition : ApplicationException
    {
        public IntegrityExcepition(string message) : base (message)
        {

        }
    }
}
