using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultitelecastReturnValue
{
    public delegate int MyDelegate(); //declaring a delegate
     class Program
    {
        static void Main(string[] args)
        {
            MyDelegate del1 = ClassA.MethodA;
            MyDelegate del2 = ClassB.MethodB;

            MyDelegate del = del1 + del2;
            Console.WriteLine(del());
            Console.ReadKey();
        }
    }

    public class ClassA
    {
        public static int MethodA()
        {
            return 100;
        }
    }

    public class ClassB
    {
        public static int MethodB()
        {
            return 200;
        }
    }
}
