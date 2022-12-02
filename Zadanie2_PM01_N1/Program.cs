using System;

namespace Variant10
{
	class Program
	{
		static void Main()
		{
			try
			{
				int a = 0;
				while (true)
				{
					Console.Write("Введите число: "); a = Convert.ToInt32(Console.ReadLine());
					if ((a < 10 || a > 99) && (a > -10 || a < -99))
					{
						Console.WriteLine("Число должно быть двузначным.");
					}
					else
					{
						break;
					}
				}
				int b = 0, c = 0;
				b = Math.Abs(a / 10);
				c = Math.Abs(a % 10);
				int Sum = b + c;
				if(Sum % 3 == 0)
				{
					Console.WriteLine("Сумма цифр {0} кратна трём.", Sum);
				}
				else
				{
					Console.WriteLine("Сумма цифр {0} не кратна трём.", Sum);
				}
			}
			catch
			{
				Console.WriteLine("Введите число!");
			}
		}
	}
}