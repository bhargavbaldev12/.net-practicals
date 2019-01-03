using System;
namespace P1
{
	public class Floatting
	{
		public static void Main()
		{
			float f = 0.123456789F;
			double d = 0.112233445566778899;
			decimal dec = 11223344.1112223334445556667778889999M;	
			f = (float)d;
			Console.WriteLine("f is {0} and d is {1} and dec is {2}", f, d, dec);
		}
	}
}