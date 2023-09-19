using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("Que3_2")]

namespace Ques3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class class1
    {
        internal int Value = 100;
        public void show()
        {
            Console.Write("N=" + Value);
        }
    }
}