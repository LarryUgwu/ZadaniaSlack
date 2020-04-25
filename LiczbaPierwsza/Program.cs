using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Napisać metodę do sprawdzania czy podana liczba przez użytkownika jest liczbą pierwszą
 * (https://pl.wikipedia.org/wiki/Liczba_pierwsza).
 * Wartość ma być pobierana z klawiatury.
 * Opis algorytmu/ów można znaleźć na -> 
 * https://eduinf.waw.pl/inf/alg/001_search/0010.phpPodpowiedź: 
 * przydatne będzie znalezienie pierwiastka kwadratowego badanej liczby. 
 * Do tego celu należy użyć metody Math.Sqrt() -> 
 * https://docs.microsoft.com/pl-pl/dotnet/api/system.math. */

namespace LiczbaPierwsza
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Podaj liczbę:        ");
                double liczba = Convert.ToDouble(Console.ReadLine());

                double pierwiastek = Math.Sqrt(liczba);

                //Console.Write(pierwiastek);
                //Console.ReadKey();

                if (liczba > 2 && liczba % 2 == 0)
                {
                    Console.WriteLine(liczba + " nie jest liczba pierwszą");
                }

                else if (liczba > 3 && liczba % 3 == 0)
                {
                    Console.WriteLine(liczba + " nie jest liczba pierwszą");
                }

                else if (liczba % pierwiastek == 0)
                {
                    Console.WriteLine(liczba + " nie jest liczba pierwszą");
                }

                else
                {
                    Console.WriteLine(liczba + " jest liczba pierwszą");
                }
                Console.ReadKey();
            }
        }
    }
}
