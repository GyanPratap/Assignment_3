using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.SetProperty();
            derivedClass.GetProperty();
        }
    }
    public class BaseClass
    {
        public int Value { get; set; }
    }
    class DerivedClass : BaseClass
    {
        public void SetProperty()
        {
            Value = 10;
        }
        public void GetProperty()
        {
            Console.WriteLine("The Value of property is : " + Value);
        }

    }
}
        