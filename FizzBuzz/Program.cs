using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opis gry
            Console.WriteLine("Podaj liczbę: ");
            var score = FizzBuzz();
            Console.WriteLine(score);
        }
        private static string FizzBuzz()
        {
            //dodać try, catch(debilo-odporność)<3
            int number = int.Parse(Console.ReadLine());
            if (number % 3 == 0 && number % 5 == 0 && number % 10 != 0)
            {
                return "FizzBuzz";
            }
            else if(number % 3 == 0 && number % 5 != 0)
            {
                return "Fizz";
            }
            else if(number % 5 == 0 && number % 3 != 0)
            {
               return "Buzz";
            }

            return $"Liczba {number} nie jest podzielna ani przez 3, ani przez 5.";
        }
    }
}
