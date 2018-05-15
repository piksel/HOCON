using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hocon
{
    class HoconWriter : JsonWriter
    {
        public override void Flush()
        {
            throw new NotImplementedException();
        }
    }
}
