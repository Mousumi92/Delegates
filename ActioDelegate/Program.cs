using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActioDelegate
{
    public delegate void Print(int val);
  
     class Program
    {
        static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }
        static void Main(string[] args)
        {
            Print prnt = ConsolePrint;
            prnt(10);

            Action<int> printActionDel = ConsolePrint;
            //Action<int> printActionDel = new Action<int>(ConsolePrint);
            printActionDel(10);
        }
    }
}
