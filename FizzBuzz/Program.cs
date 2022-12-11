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
            Console.WriteLine("----------FizzBuzz----------\n");
            Console.WriteLine("Zasady gry:\n\n-Jeżeli liczba użytkownika będzie podzielna przez 3 bez reszty, to powinien zostać zwrócony wynik „Fizz”.\n-Jeżeli liczba użytkownika będzie podzielna przez 5 bez reszty, to powinien zostać zwrócony wynik „Buzz”.\n-Jeżeli liczba użytkownika będzie podzielna przez 3 i przez 5 jednocześnie bez reszty, to powinien zostać\n zwrócony wynik „FizzBuzz”.\n-Jeżeli liczba użytkownika nie będzie podzielna przez 3 ani przez 5 bez reszty, to wtedy zwracasz podaną liczbę.\n");

            Console.WriteLine("Podaj liczbę: ");
            var score = FizzBuzz();
            Console.WriteLine(score);
            Console.ReadLine();
        }
        private static string FizzBuzz()
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 3 == 0 && number % 5 == 0 && number % 10 != 0)
                {
                    return "FizzBuzz";
                }
                else if (number % 3 == 0 && number % 5 != 0)
                {
                    return "Fizz";
                }
                else if (number % 5 == 0 && number % 3 != 0)
                {
                    return "Buzz";
                }

                return $"Liczba {number} nie jest podzielna ani przez 3, ani przez 5.";
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return " ";
        }
    }
}
