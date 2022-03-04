using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAsAParameter
{
	public delegate void MyDelegate(string msg);

	class Program
    {
        static void Main(string[] args)
        {
			MyDelegate del = ClassA.MethodA;
			InvokeDelegate(del);

			del = ClassB.MethodB;
			InvokeDelegate(del);

			del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
			InvokeDelegate(del);
		}
		public static void InvokeDelegate(MyDelegate del) // MyDelegate type parameter
		{
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
