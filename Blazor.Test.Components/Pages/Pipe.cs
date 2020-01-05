using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Test.Components.Pages
{
    public class Pipe
    {
        public int X { get; set; }
        public int UpperY { get; set; }
        public int LowerY { get; set; }
        public int Width { get; set; } = 100;

        public Color Color=Color.Green;
        public void Move(int Amount,int resPos,int VSpace)
        {
            X -= Amount;
            if(X<=-100)
            {
                X = resPos;
                RandomY(VSpace);
            }
        }
        public void RandomY(int VSpace)
        {
            LowerY = RandomNumber(150, 450);
            UpperY = LowerY + VSpace;
        }

        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public static int RandomNumber(int min, int max)
        {
            lock (syncLock)
            { 
                return random.Next(min, max);
            }
        }
    }
}
