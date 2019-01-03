using System;
namespace P1
{
	class IntType
	{
		public static void Main()
		{
			//Signed Variables
			sbyte sb = 33;
			short s =33 ;
			int i = 33;
			long l = 33L;

			//Unsigned Variables
			byte b = 33;
			ushort us = 33;
			uint ui = 33U;
			ulong ul = 33UL;
			us = (ushort)ul;

			Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}", sb,s,i,l,b,us,ui,ul);

		}
	}
}