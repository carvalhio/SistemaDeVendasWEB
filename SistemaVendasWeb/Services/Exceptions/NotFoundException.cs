using System;

namespace SistemaVendasWeb.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message) : base (message)
        {

        }
    }
}
