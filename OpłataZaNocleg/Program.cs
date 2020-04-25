using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Użytkownik podaje swój wiek i ile nocy spędzi w hotelu, a program wylicza, ile trzeba zapłacić.
 * Zasady są takie:- nieletni (poniżej 18 roku życia) płacą 100 zł za noc
- dorośli(ci, którzy mają przynajmniej 18 lat ale mniej niż 65 lat) płacą:
	- 200 zł za noc, jeśli nocują jedną noc
	- 180 zł za noc, jeśli nocują przynajmniej dwie ale mniej niż pięć nocy
	- 150 zł za noc, jeśli nocują pięć lub więcej nocy
- emeryci(ci, którzy mają przynajmniej 65 lat), płacą jak dorośli, ale z 10% zniżki

Przykładowo: jeśli użytkownik ma 70 lat i spędzi w hotelu dziesięć nocy, zapłaci 150 zł za noc 
z 10% zniżki, czyli 150-15 zł za noc, czyli 135 zł za noc, czyli 1350 zł.

*/

namespace OpłataZaNocleg
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Wiek gościa:        ");
                byte wiek = Convert.ToByte(Console.ReadLine());

                Console.Write("Ile noclegów:        ");
                byte noclegi = Convert.ToByte(Console.ReadLine());

                Console.WriteLine();

                double cena1noc = 200.00;
                double cenaDo5nocy = 180.00;
                double cenaPowyżej5nocy = 150.00;
                double zniżkaEmerytalna = 0.10;
                double cenaPobytu;

                if (wiek < 18)
                {
                    if (noclegi < 1)
                    {
                        cenaPobytu = 100.00;
                        Console.WriteLine("Cena za pobyt wynosi: " + cenaPobytu + " zł");
                    }

                    else if (noclegi >= 1)
                    {
                        cenaPobytu = noclegi * 100.00;
                        Console.WriteLine("Cena za pobyt wynosi: " + cenaPobytu + " zł");
                    }
                }

                else if (wiek < 65)
                {
                    if (noclegi <= 1)
                    {
                        cenaPobytu = cena1noc;
                        Console.WriteLine("Cena za pobyt wynosi: " + cenaPobytu + " zł");
                    }

                    else if (noclegi < 5)
                    {
                        cenaPobytu = noclegi * cenaDo5nocy;
                        Console.WriteLine("Cena za pobyt wynosi: " + cenaPobytu + " zł");
                    }

                    else if (noclegi >= 5)
                    {
                        cenaPobytu = noclegi * cenaPowyżej5nocy;
                        Console.WriteLine("Cena za pobyt wynosi: " + cenaPobytu + " zł");
                    }
                }

                else if (wiek >= 65)
                {
                    if (noclegi <= 1)
                    {
                        cenaPobytu = cena1noc * (1 - zniżkaEmerytalna);
                        Console.WriteLine("Cena za pobyt wynosi: " + cenaPobytu + " zł");
                    }

                    else if (noclegi < 5)
                    {
                        cenaPobytu = noclegi * cenaDo5nocy * (1 - zniżkaEmerytalna);
                        Console.WriteLine("Cena za pobyt wynosi: " + cenaPobytu + " zł");
                    }

                    else if (noclegi >= 5)
                    {
                        cenaPobytu = noclegi * cenaPowyżej5nocy * (1 - zniżkaEmerytalna);
                        Console.WriteLine("Cena za pobyt wynosi: " + cenaPobytu + " zł");
                    }
                }

                Console.WriteLine();

            }
        }
    }
}
