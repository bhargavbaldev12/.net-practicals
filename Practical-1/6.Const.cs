using System;
namespace P1
{
	public class Const
	{
		public static void Main()
		{
			const double bonusPercent = 0.51;
			int sal = 3000;
			int bonus = (int)(sal * bonusPercent);
			Console.WriteLine(bonus);
		}
	}
}