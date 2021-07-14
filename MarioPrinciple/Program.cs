using MarioPrinciple.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Block b = new Block(11, 11);
            Avatar a = new Avatar(0, 0, 0);
            //PrintCheckCollide(b, a);
            if (a.Colide(b)) {
                a.HandleCollision(b);
                b.HandleCollision(a);
            }
            a.State = AvatarState.big;
            if (a.Colide(b))
            {
                a.HandleCollision(b);
                b.HandleCollision(a);
            }
            //PrintCheckCollide(b, a);
            Console.ReadLine();
        }

        private static void PrintCheckCollide(Block b, Avatar a)
        {
            if (a.Colide(b))
            {
                Console.WriteLine("collides");
            }
            else
            {
                Console.WriteLine("doesn't collides");
            }
        }
    }
}
