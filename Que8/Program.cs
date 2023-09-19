using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DemoClass demoClass = new DemoClass();
            demoClass.ShowPrivate();
        }
    }
    class DemoClass
    {
        private void Show()
        {
            Console.WriteLine("This is the private method of DemoClass");
        }
        public void ShowPrivate()
        {
            Show();
        }
    }
}
      