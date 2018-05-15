using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hocon
{
    public class HoconTokenizerException : Exception
    {
        public HoconTokenizerException(string message) : base(message)
        {
        }
    }
}
