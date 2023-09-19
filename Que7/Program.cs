using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            class1 c = new class1();
            Console.Write("Enter the value of property : ");
            int num = Convert.ToInt32(Console.ReadLine());
            c.SetProperty(num);
            c.GetProperty();

        }
    }
    class class1
    {
        private int property { get; set; }
        public void SetProperty(int value)
        {
            property = value;
        }
        public void GetProperty()
        {
            Console.WriteLine("The value of property is : " + property);
        }
    }
}
       