using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperature_converter {
	class Program {
		static void Main(string[] args) {
			while (true) {
				Console.Write("Temperature in celsius: ");
				try {
					double temperature_c = Double.Parse(Console.ReadLine());
					double fahrenheit = (temperature_c * 9) / 5 + 32;
					Console.WriteLine(fahrenheit + " fahrenheit");
				} catch (Exception e) {
					Console.WriteLine("Invalid input!");
				}
			}
		}
	}
}
