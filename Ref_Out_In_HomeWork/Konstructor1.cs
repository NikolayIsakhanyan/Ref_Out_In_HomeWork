using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ref_Out_In_HomeWork
{
    public class Konstructor1
    {
        int x;
        int y;
       public Konstructor1(int x, int y)
        {
            int b = y;
            int c = x;
            b = b + 1;
            c = c + 1;
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
