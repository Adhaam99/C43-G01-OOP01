using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{

    [Flags]
    public enum Permissions : byte
    {
        None = 0,
        Delete = 1,
        Execute = 2,
        Read = 4,
        Write = 8,

    }
}
