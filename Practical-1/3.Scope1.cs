using System;
namespace P1
{
	class Scope1
	{
		public static void Main()
		{
			for(int i=0;i<5;i++)
			{
				Console.WriteLine(i);
			} 
			
			//i goes out of Scope here
			
			for(int i=4;i>=0;i--)
			{
				Console.WriteLine(i);
			}
		}
	}
}