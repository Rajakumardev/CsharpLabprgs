using System;

namespace AnonymousMethod
{
	delegate int del (int x,int y);
	class MainClass
	{
		public static void Main (string[] args)
		{
			del d1 = (x,y) => x * y;
			del d2 = (x,y) => {return x*y;};
			del d3 = delegate(int x,int y){
				return x*y;
			};
			Console.WriteLine("The value return from the delegate d1 is:{0}",d1(4,4));
			Console.WriteLine("The value return from the delegate d2 is:{0}",d2(4,4));
			Console.WriteLine("The value return from the delegate d2 is:{0}",d3(4,4));
		}
	}
}
