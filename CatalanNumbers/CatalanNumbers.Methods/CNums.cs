using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalanNumbers.Methods
{
    public class CNums
    {
		public static int Factorial(int n)
		{
			int result = 0;
			if (n > 1)
			{
				result = n * Factorial(n - 1);
			}
			else if (n == 0 || n == 1)
			{
				return 1;
			}
			else
			{
				throw new System.ArithmeticException();
			}
			return result;
		}

		public static int CatalanDirect(int n)
		{
			var result = Factorial(2 * n) / (Factorial(n + 1) * Factorial(n));
			return result;
		}
    }
}
