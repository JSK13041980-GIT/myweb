using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            working _obj = new working(10);

            string strvalue= _obj.Display("Working");

            Console.Write("testing Application new changes " + strvalue);
        }
    }
}
