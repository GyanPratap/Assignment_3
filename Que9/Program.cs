using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeriveClass deriveClass = new DeriveClass();
            deriveClass.Method2();
        }
    }
    class BaseClass
    {
        protected void Method()
        {
            Console.WriteLine("This is the protected method of BaseClass !");
        }
    }
    class DeriveClass : BaseClass
    {
        public void Method2()
        {
            Method();
        }
    }
}
       