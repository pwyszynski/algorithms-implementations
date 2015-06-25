using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalanNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int result = CNums.CatalanDirect(5);
			Console.WriteLine("Catalan from n=5: " + result.ToString());
			Console.ReadLine();
		}
	}
}
