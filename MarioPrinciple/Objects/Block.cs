using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioPrinciple.Objects
{
    class Block:ColldeableObject
    {

        public bool Active { get; set; }
        public Block(int x,int y)
        {
            this.X = x;
            this.Y = y;
            this.Active = true;
            this.Height = 10;
            this.Width = 10;
        }
    }
}
