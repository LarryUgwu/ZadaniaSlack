using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Proszę napisać metodę realizującą funkcjonalność prostego kalkulatora.
- Przyjmujemy z konsoli od użytkownika pierwszą wartość wyrażenia(jako liczba zmiennoprzecinkowa)
- Przyjmujemy z konsoli od użytkownika rodzaj operacji w postaci znaku + , - , * lub /
- Przyjmujemy z konsoli od użytkownika drugą wartość wyrażenia(jako liczba zmiennoprzecinkowa)
- Wyświetlamy wynikUwaga! Proszę użyć komendy switch do rozpoznania operacji, proszę zwrócić uwagę, 
    aby obsłużyć sytuację, gdy drugą wartością wyrażenia jest 0, a operacją dzielenie.*/

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Podaj pierwszą liczbę:     ");
                double liczba1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Podaj znak: +, -, *, /     ");
                char znak = Convert.ToChar(Console.ReadLine());

                Console.Write("Podaj drugą liczbę:        ");
                double liczba2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();

                double suma = liczba1 + liczba2;
                double różnica = liczba1 - liczba2;
                double iloczyn = liczba1 * liczba2;
                double iloraz = liczba1 / liczba2;

                switch (znak)
                {
                    case '+':
                        Console.WriteLine("Wynik: " + suma);
                        Console.ReadKey();
                        break;

                    case '-':
                        Console.WriteLine("Wynik: " + różnica);
                        Console.ReadKey();
                        break;

                    case '*':
                        Console.WriteLine("Wynik: " + iloczyn);
                        Console.ReadKey();
                        break;

                    case '/':
                        if (liczba2 == 0)
                        {
                            Console.WriteLine("Próbujesz dzielić przez zero!");
                        }
                        else
                            Console.WriteLine("Wynik: " + iloraz);
                            Console.ReadKey();
                            break;
                }
                Console.WriteLine();

            }
        }
    }
}
