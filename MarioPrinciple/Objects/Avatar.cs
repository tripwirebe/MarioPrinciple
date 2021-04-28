using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioPrinciple.Objects
{
    public enum AvatarState
    {
        small,
        big,
        flower,
        tail
    }
    class Avatar:ColldeableObject
    {
        public int ID { get; }
        public override int Height
        {
            get
            {
                int height = 10;
                switch (this.State)
                {
                    case AvatarState.small:height = 10;break;
                    case AvatarState.big:height = 15;break;
                    case AvatarState.flower:height= 15;break;
                    case AvatarState.tail: height = 15; break;
                }
                return height;
            }
        }
        public override int Width
        {
            get
            {
                int width = 10;
                switch (this.State)
                {
                    case AvatarState.small: width = 10; break;
                    case AvatarState.big: width = 15; break;
                    case AvatarState.flower: width = 15; break;
                    case AvatarState.tail: width = 20; break;
                }
                return width;
            }
        }

        public AvatarState State { get; set; }
        public Avatar(int id,int x,int y)
        {
            this.ID = id;
            this.X = x;
            this.Y = y;
            this.State = AvatarState.small;
        }
    }
}
