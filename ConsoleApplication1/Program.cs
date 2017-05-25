using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            n++;
            M1(ref n);

        }
        static void M1(ref int m)
        {
            m++;
        }
    }
}
