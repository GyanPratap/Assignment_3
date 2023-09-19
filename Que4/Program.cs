using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.ShowValue();
        }
    }
    public class BaseClass
    {
        protected int value = 100;
        protected void show()
        {
            Console.WriteLine("Calling Base Class Protected Method !");
        }
    }
    class DerivedClass : BaseClass
    {
        public void ShowValue()
        {
            show();
            Console.WriteLine("The value of Base Class protected Member is : " + value);
        }
    }
}
        
