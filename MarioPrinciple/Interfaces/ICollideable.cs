using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioPrinciple.Interfaces
{
    interface ICollideable
    {
        int X { get; set; }
        int Y { get; set; }
        int Height{ get;  }
        int Width { get;  }
    }
}
