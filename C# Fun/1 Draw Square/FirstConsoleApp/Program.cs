using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.SmallBasic.Library;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var len = 100;

            Turtle.Turn(90);
            Turtle.Move(len);
            Turtle.Turn(90);
            Turtle.Move(len);
            Turtle.Turn(90);
            Turtle.Move(len);
            Turtle.Turn(90);
            Turtle.Move(len);

        }
    }
}
