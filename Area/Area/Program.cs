using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area {
	class Program {
		static void Main(string[] args) {
			while(true) {
				Console.Write("Length of Side: ");
				try {
					double length = double.Parse(Console.ReadLine());
					double area = length * length;

					Console.WriteLine("Area: " + area);
				} catch(Exception e) {
					Console.WriteLine("Invalid input");
				}
			}
		}
	}
}
