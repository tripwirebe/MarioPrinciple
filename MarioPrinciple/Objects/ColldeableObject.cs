using MarioPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioPrinciple.Objects
{
    abstract class ColldeableObject : ICollideable
    {
        public string Type;
        public int X { get; set ; }
        public int Y { get ; set ; }

        public virtual int Height { get; protected set; }

        public virtual int Width { get; protected set; }
        public bool Colide(ICollideable other)
        {
            Rectangle fRectangle = new Rectangle() { X = this.X, Y = this.Y, Height = this.Height, Width = this.Width };
            Rectangle sRectangle = new Rectangle() { X = other.X, Y = other.Y, Height = other.Height, Width = other.Width };
            return fRectangle.IntersectsWith(sRectangle);
        }
        public abstract void HandleCollision(ColldeableObject other);
    }
}
