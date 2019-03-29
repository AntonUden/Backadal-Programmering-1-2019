using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inlämningsuppgift_8 {
	class Program {
		static void Main(string[] args) {
			while(true) {
				Console.WriteLine("--- Välj programm ---");
				Console.WriteLine("1: Is, Vatten eller ånga");
				Console.WriteLine("2: Ålder");
				Console.Write("\n> ");
				String prog = Console.ReadLine();

				if (prog == "1") {
					startIsVattenAnga();
					return;
				}

				if (prog == "2") {
					startAlder();
					return;
				}
				
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Välj programm 1 eller 2\n");
				Console.ResetColor();
			}
		}

		private static void startIsVattenAnga() {
			while(true) {
				Console.WriteLine("Ange temperaturen i grader celsius: ");
				try {
					double temperatur = double.Parse(Console.ReadLine());

					if(temperatur <= 0) {
						Console.ForegroundColor = ConsoleColor.Blue;
						Console.WriteLine("Is");
					} else if(temperatur < 100) {
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine("Vatten");
					} else {
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("Ånga");
					}
					Console.ResetColor();
				} catch (Exception e) {
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Ange en giltigt temperatur");
					Console.ResetColor();
				}
			}
		}

		private static void startAlder() {
			while(true) {

				String namn = "";
				while (true) {
					Console.Write("Namn: ");
					namn = Console.ReadLine();

					if (namn.Length > 0) {
						break;
					}
					
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Ange ett giltigt namn");
					Console.ResetColor();
				}

				int alder = 0;
				while (true) {
					Console.Write("Ålder: ");

					try {
						alder = int.Parse(Console.ReadLine());
					} catch(Exception e) {
						alder = -1; // Detta ger felmedelandet Ange ett giltig ålder
					}

					if (alder > 0) {
						break;
					}
					
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Ange ett giltig ålder");
					Console.ResetColor();
				}

				Console.WriteLine("Hej " + namn + ((alder < 20 || alder > 70) ? ", " + (alder < 20 ? "du behöver visa legitimation!" : "oj vad gammal du är!") : ""));
			}
		}
	}
}
