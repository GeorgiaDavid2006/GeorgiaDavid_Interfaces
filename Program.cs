using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GeorgiaDavid_Interfaces
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            
        }
    }

    struct Position
    {
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }
}
