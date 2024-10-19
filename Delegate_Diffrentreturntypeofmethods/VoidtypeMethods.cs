using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Diffrentreturntypeofmethods
{
    public class VoidtypeMethods
    {
        public void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("Sum is " + c);
        }
        public void subtract(int a, int b)
        {
            int c = a - b;
            Console.WriteLine("subtraction is " + c);
        }
        public void Multiply(int a, int b,int c)
        {
            int result = a * b* c;
            Console.WriteLine("multiplication is " + result);
        }
        public void Division(int a, int b,int c,int d)
        {
            int result = a / b;
            Console.WriteLine("division is" + result);
        }
    }
}
