using System;
namespace P1
{
	class Scope2
	{
		public static void Main()
		{
			int j;
			for(int i=0;i<15;i++)
			{
				int j;
				Console.WriteLine(i);
			}
		}
	}
}