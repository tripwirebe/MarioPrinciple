using MarioPrinciple.Interfaces;
using MarioPrinciple.Consts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioPrinciple.Objects
{
    class Block:ColldeableObject
    {
        public string Type = Constants.Block;
        public bool Active { get; set; }
        public Block(int x,int y)
        {
            this.X = x;
            this.Y = y;
            this.Active = true;
            this.Height = 10;
            this.Width = 10;
        }

        public override void HandleCollision(ColldeableObject other)
        {
            // do nothing
            Console.WriteLine(string.Concat("I'm doing shit bruh ",other.GetType().ToString()));
        }
    }
}
