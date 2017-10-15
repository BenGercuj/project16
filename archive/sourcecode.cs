using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication16
{
	class Program
	{
		static void numb1(int[] array)
		{
			for (int i = 0; i < 10; i++)
			{
				if (i % 2 == 0)
				{
					array[i] = i;
				}
			}
		}

		static void numb2(int[] array)
		{
			for (int i = 0; i < 10; i++)
			{
				if (i % 2 != 0)
				{
					array[i] = i;
				}
			}
		}

		static void ucharb1(string[] array)
		{
			array[0] = "B";
			array[1] = "C";
			array[2] = "D";
			array[3] = "G";
			array[4] = "H";
			array[5] = "J";
			array[6] = "L";
			array[7] = "M";
			array[8] = "Q";
			array[9] = "R";
			array[10] = "S";
			array[11] = "V";
			array[12] = "W";
			array[13] = "Y";
			array[14] = "Z";
		}

		static void ucharb2(string[] array)
		{
			array[0] = "A";
			array[1] = "E";
			array[2] = "F";
			array[3] = "I";
			array[4] = "K";
			array[5] = "N";
			array[6] = "O";
			array[7] = "P";
			array[8] = "T";
			array[9] = "U";
			array[10] = "X";
		}

		static void lcharb1(string[] array)
		{
			array[0] = "a";
			array[1] = "e";
			array[2] = "f";
			array[3] = "i";
			array[4] = "k";
			array[5] = "n";
			array[6] = "o";
			array[7] = "p";
			array[8] = "t";
			array[9] = "u";
			array[10] = "x";
		}

		static void lcharb2(string[] array)
		{
			array[0] = "b";
			array[1] = "c";
			array[2] = "d";
			array[3] = "g";
			array[4] = "h";
			array[5] = "j";
			array[6] = "l";
			array[7] = "m";
			array[8] = "q";
			array[9] = "r";
			array[10] = "s";
			array[11] = "v";
			array[12] = "w";
			array[13] = "y";
			array[14] = "z";
		}

		static void symbolb1(string[] array)
		{
			array[0] = "!";
			array[1] = "#";
			array[2] = "^";
			array[3] = "&";
			array[4] = "(";
			array[5] = ")";
			array[6] = "_";
			array[7] = "+";
			array[8] = "`";
			array[9] = "[";
			array[10] = "]";
			array[11] = "|";
			array[12] = ";";
			array[13] = "\"";
			array[14] = ">";
			array[15] = ",";
			array[16] = "?";
		}

		static void symbolb2(string[] array)
		{
			array[0] = "$";
			array[1] = ":";
			array[2] = "-";
			array[3] = "<";
			array[4] = "/";
			array[5] = "%";
			array[6] = "~";
			array[7] = "}";
			array[8] = "*";
			array[9] = "=";
			array[10] = "{";
			array[11] = "@";
			array[12] = ".";
		}

		static void Main(string[] args)
		{
			////////////////////////////////////////////////////////////////////////////////////////////////////////////////
			////////////////////////////////////////////////////////////////////////////////////////////////////////////////
			//////////											PART 0											  //////////
			////////////////////////////////////////////////////////////////////////////////////////////////////////////////
			////////////////////////////////////////////////////////////////////////////////////////////////////////////////

			int[] numab1 = new int[10];
			numb1(numab1);

			int[] numab2 = new int[10];
			numb2(numab2);

			string[] ucharab1 = new string[15];
			ucharb1(ucharab1);

			string[] ucharab2 = new string[11];
			ucharb2(ucharab2);

			string[] lcharab1 = new string[11];
			lcharb1(lcharab1);

			string[] lcharab2 = new string[15];
			lcharb2(lcharab2);

			string[] symbolab1 = new string[17];
			symbolb1(symbolab1);

			string[] symbolab2 = new string[13];
			symbolb2(symbolab2);

			////////////////////////////////////////////////////////////////////////////////////////////////////////////////
			////////////////////////////////////////////////////////////////////////////////////////////////////////////////
			//////////											PART 1											  //////////
			////////////////////////////////////////////////////////////////////////////////////////////////////////////////
			////////////////////////////////////////////////////////////////////////////////////////////////////////////////

			int pwdl = 16;
			int[] pwd = new int[pwdl];
			string[] pwdstr = new string[pwdl];
			bool numb = true;
			bool ucharb = true;
			bool lcharb = true;
			bool symb = true;

			/*Console.WriteLine("Password length?");
			int pwdl = int.Parse(Console.ReadLine());

			int[] pwd = new int[pwdl];
			string[] pwdstr = new string[pwdl];

			Console.WriteLine("Pwd length: {0} characters", pwd.Length);
			Console.WriteLine();

			Console.WriteLine("Include numbers? (y/n)");
			bool numb = false;
			char numyn = char.Parse(Console.ReadLine());

			if (numyn == 'y')
			{
				numb = true;
				Console.WriteLine("Numbers will be included");
			}

			else
			{
				numb = false;
				Console.WriteLine("Numbers will not be included");
			}
			Console.WriteLine();

			Console.WriteLine("Include upper letters? (y/n)");
			bool ucharb = false;
			char ucharyn = char.Parse(Console.ReadLine());

			if (ucharyn == 'y')
			{
				ucharb = true;
				Console.WriteLine("Upper letters will be included");
			}

			else
			{
				ucharb = false;
				Console.WriteLine("Upper letters will not be included");
			}
			Console.WriteLine();

			Console.WriteLine("Include lower letters? (y/n)");
			bool lcharb = false;
			char lcharyn = char.Parse(Console.ReadLine());

			if (lcharyn == 'y')
			{
				lcharb = true;
				Console.WriteLine("Lower letters will be included");
			}

			else
			{
				lcharb = false;
				Console.WriteLine("Lower letters will not be included");
			}
			Console.WriteLine();

			Console.WriteLine("Include symbols? (y/n)");
			bool symb = false;
			char symyn = char.Parse(Console.ReadLine());

			if (symyn == 'y')
			{
				symb = true;
				Console.WriteLine("Symbols will be included");
			}

			else
			{
				symb = false;
				Console.WriteLine("Symbols will not be included");
			}
			Console.WriteLine();*/

			////////////////////////////////////////////////////////////////////////////////////////////////////////////////
			////////////////////////////////////////////////////////////////////////////////////////////////////////////////
			//////////											PART 2											  //////////
			////////////////////////////////////////////////////////////////////////////////////////////////////////////////
			////////////////////////////////////////////////////////////////////////////////////////////////////////////////

			Random rnd = new Random();
			int[] valuebase = new int[231];

			for (int i = 0; i < valuebase.Length; i++)
			{
				valuebase[i] = rnd.Next(-500, 500);
			}

			////////////////////////////////////////////////////////////////////////////////////////////////////////////////
			//////////											SUBPART 1										  //////////
			////////////////////////////////////////////////////////////////////////////////////////////////////////////////

			if (numb == true && ucharb == true && lcharb == true && symb == true)
			{
				int uchar1counter = 0;
				int uchar2counter = 0;
				int lchar1counter = 0;
				int lchar2counter = 0;
				int sym1counter = 0;
				int sym2counter = 0;
				int num1counter = 0;
				int num2counter = 0;

				for (int i = 0; i < pwd.Length; i++)
				{
					pwd[i] = valuebase[i + 29];
				}

				for (int y = 0; y < pwd.Length; y++)
				{
					if (pwd[y] <= 125 && pwd[y] >= 0)
					{
						int[] uchar1rnd = new int[15];
						for (int a = 0; a < uchar1rnd.Length; a++)
						{
							uchar1rnd[a] = rnd.Next(0, 15);
						}
						pwdstr[y] = ucharab1[uchar1rnd[0 + uchar1counter]];
						uchar1counter++;
					}

					if (pwd[y] <= 250 && pwd[y] >= 126)
					{
						int[] sym2rnd = new int[13];
						for (int a = 0; a < sym2rnd.Length; a++)
						{
							sym2rnd[a] = rnd.Next(0, 13);
						}
						pwdstr[y] = symbolab2[sym2rnd[0 + sym2counter]];
						sym2counter++;
					}

					if (pwd[y] <= 375 && pwd[y] >= 251)
					{
						int[] uchar2rnd = new int[11];
						for (int a = 0; a < uchar2rnd.Length; a++)
						{
							uchar2rnd[a] = rnd.Next(0, 11);
						}
						pwdstr[y] = ucharab2[uchar2rnd[0 + uchar2counter]];
						uchar2counter++;
					}

					if (pwd[y] <= 500 && pwd[y] >= 376)
					{
						int[] sym1rnd = new int[17];
						for (int a = 0; a < sym1rnd.Length; a++)
						{
							sym1rnd[a] = rnd.Next(0, 17);
						}
						pwdstr[y] = ucharab1[sym1rnd[0] + sym1counter];
						sym1counter++;
					}

					if (pwd[y] <= -376 && pwd[y] >= -500)
					{
						int[] lchar2rnd = new int[15];
						for (int a = 0; a < lchar2rnd.Length; a++)
						{
							lchar2rnd[a] = rnd.Next(0, 15);
						}
						pwdstr[y] = lcharab2[lchar2rnd[0 + lchar2counter]];
						lchar2counter++;
					}

					if (pwd[y] <= -251 && pwd[y] >= -375)
					{
						int[] num1rnd = new int[10];
						for (int a = 0; a < num1rnd.Length; a++)
						{
							num1rnd[a] = rnd.Next(0, 10);
						}
						pwdstr[y] = numab1[num1rnd[0 + num1counter]].ToString();
						num1counter++;
					}

					if (pwd[y] <= -126 && pwd[y] >= -250)
					{
						int[] lchar1rnd = new int[10];
						for (int a = 0; a < lchar1rnd.Length; a++)
						{
							lchar1rnd[a] = rnd.Next(0, 10);
						}
						pwdstr[y] = lcharab1[lchar1rnd[0 + lchar1counter]];
						lchar1counter++;
					}

					if (pwd[y] <= -1 && pwd[y] >= -125)
					{
						int[] num2rnd = new int[10];
						for (int a = 0; a < num2rnd.Length; a++)
						{
							num2rnd[a] = rnd.Next(0, 10);
						}
						pwdstr[y] = numab2[num2rnd[0] + num2counter].ToString();
						num2counter++;
					}
				}
			}

			////////////////////////////////////////////////////////////////////////////////////////////////////////////////
			//////////											SUBPART 2										  //////////
			////////////////////////////////////////////////////////////////////////////////////////////////////////////////

			StreamWriter sw1 = new StreamWriter("E:/project16/pwd.txt");
			sw.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}", pwdstr[0], pwdstr[1], pwdstr[2], pwdstr[3], pwdstr[4], pwdstr[5], pwdstr[6], pwdstr[7], pwdstr[8], pwdstr[9], pwdstr[10], pwdstr[11], pwdstr[12], pwdstr[13], pwdstr[14], pwdstr[15]);
			sw.Close();

			StreamWriter sw2 = new StreamWriter("E:/project16/pwd2.txt");
			for (int i = 0; i < pwdstr.Length; i++)
			{
				sw2.Write("{0}", pwdstr[i]);
			}
			sw2.Close();

			Console.ReadKey();
		}
	}
}
