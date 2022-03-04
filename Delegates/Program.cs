using System;

namespace Delegates
{
    public delegate void MyDelegate(string msg); // declare a delegate
     class Program
    {    
        static void Main(string[] args)
        {
           // MyDelegate del = new MyDelegate(ClassA.MethodA);
            MyDelegate del = ClassA.MethodA;
            del("Hello World");
            del.Invoke("Hello World!");

            del = ClassB.MethodB;
            del("Hello World");

            del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
            del("Hello World");
        }
    }

    public class ClassA
    {
        public static void MethodA(string message)
        {
            Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
        }
    }

    public class ClassB
    {
        public static void MethodB(string message)
        {
            Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
        }
    }
}
