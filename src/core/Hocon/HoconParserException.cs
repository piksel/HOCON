using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hocon
{
    public class HoconParserException : Exception
    {
        public HoconParserException(string message) : base(message)
        {
        }

        public HoconParserException(string message,Exception innerException) : base(message,innerException)
        {
        }
    }
}
