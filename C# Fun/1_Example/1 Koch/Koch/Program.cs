using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.SmallBasic.Library;

namespace Koch
{
    class Program
    {
        static void Main(string[] args)
        {
            Turtle.Speed = 10;
            Turtle.Turn(30);
            Draw(200, 3);
            Turtle.Turn(120);
            Draw(200, 3);
            Turtle.Turn(120);
            Draw(200, 3);
            Turtle.Turn(120);
        }

        public static void Draw(int len, int n)
        {
            if (n==0) Turtle.Move(len);
            else
            {
                Draw(len/3,n-1);
                Turtle.Turn(-60);
                Draw(len/3,n-1);
                Turtle.Turn(120);
                Draw(len/3,n-1);
                Turtle.Turn(-60);
                Draw(len / 3, n - 1);
            }
        }

    }
}
