using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class2 class2 = new Class2();
            class2.ShowValue();
        }
    }
    public class Class1
    {
        private string field1 = "Data Member of class 1";
        public string show()
        {
            return field1;
        }
    }
    public class Class2
    {
        public void ShowValue()
        {
            Class1 class1 = new Class1();
            Console.WriteLine("Accessing the private field of Class1 as Value of field1 = " + class1.show());
        }
    }
}
        