using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo demo = new Demo();
            demo.SetValue();
            Console.WriteLine("The Value of Private Field : " + demo.ShowValue());
        }
    }
    internal class Demo
    {
        private int Num;
        public void SetValue()
        {
            Console.WriteLine("Enter the value of private field : ");
            Num = Convert.ToInt32(Console.ReadLine());
        }
        public int ShowValue()
        {
            return Num;
        }
    }
}
        
