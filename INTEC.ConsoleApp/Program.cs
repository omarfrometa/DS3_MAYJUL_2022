using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTEC.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NOMBRE DE LOS DOCTORES");
            Console.WriteLine("");

            Console.ReadLine();
            for (int i = 1; i < 10; i++)
            {
                Random rnd = new Random();
                Console.WriteLine($"{i}. - {GenerateName(rnd.Next(4, 15))} {GenerateName(rnd.Next(4, 15))}");

                Console.ReadLine();
            }

            Console.ReadLine();
        }

        private static void DollarConverter()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("******* CONVERSOR DE MONEDAS *******");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("");

            double tasaDelDia = Convert.ToDouble(System.Configuration.ConfigurationSettings.AppSettings["TasaDelDia"]);

            Console.WriteLine("Digita los Dolares:");
            double dolares = double.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine($"Pesos Dominicanos: RD$ {string.Format("{0:C}", (dolares * tasaDelDia))}");
            Console.ReadLine();
        }

        private static string GenerateName(int len)
        { 
            string name = string.Empty;

            Random rnd = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "y", "z" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae",  "y" };

            name += consonants[rnd.Next(consonants.Length)].ToUpper();
            name += vowels[rnd.Next(vowels.Length)];

            int b = 2;
            while (b < len)
            {
                name += consonants[rnd.Next(consonants.Length)];
                b++;

                name += vowels[rnd.Next(vowels.Length)];
                b++;
            }

            return name;
        }
    }
}
