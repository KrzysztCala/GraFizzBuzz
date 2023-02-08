using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraFizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAM FizzBuzz\n");
            Console.WriteLine("Naciśnij w dowolnym momencie 't', aby zakończyć.\n\n");
            do
            {
                Console.Write("\nWpisz liczbę: ");
                try
                {
                    int number = GetIntInputOrExit();
                    FizzBuzz obj1 = new FizzBuzz(number);
                    Console.WriteLine($"{obj1.Process()}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Spróbuj ponownie!");
                    continue;
                }
            } while (true);


        }

        private static int GetIntInputOrExit()
        {
            var value = Console.ReadLine();
            if(value.ToLower() == "t")
            {
                Environment.Exit(0);
            }

            if (!int.TryParse(value, out int number))
            {
                throw new Exception("Podana wartość jest nieprawidłowa.");
            }
            return number;
        }


    }
}
