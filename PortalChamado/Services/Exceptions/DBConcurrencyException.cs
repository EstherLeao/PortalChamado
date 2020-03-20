using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalChamado.Services.Exceptions
{
    public class DBConcurrencyException : ApplicationException
    {
        public DBConcurrencyException(string massage) : base(massage)
        {

        }
    }

}
