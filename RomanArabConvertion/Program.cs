using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Napisać program realizujący konwersję liczb arabskich na rzymskie i liczb rzymskich na liczby arabskie.
 * Algorytmu najlepiej poszukać w necie.
- zdefiniować dwie metody: ArabskieNaRzymskie() , RzymskieNaArabskie()
- metody mają zwracać przekonwertowane wartości
- parametrem wywołania ww.metod jest liczba: odpowiednio arabska (np. 1988) lub rzymska(np.MMII)
- zweryfikować poprawność wprowadzanych danych z konsoli od użytkownika
- ograniczyć zakres wprowadzonej wartości w przypadku funkcji ArabskieNaRzymskie() do 
zakresu od 1 do 3999 (włącznie)*/

namespace RomanArabConvertion
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Co chcesz zrobić: ");
            Console.WriteLine("Zamienić liczbę arabską na rzymską? = wciśnij 1");
            Console.WriteLine("Zamienić liczbę rzymską na arabską? = wcisnij 2");

            int wybor = Convert.ToInt32(Console.ReadLine());

            if (wybor == 1)
            {
                while (true)
                {
                    Console.Write("Podaj liczbę arabską od 1 do 3999: ");
                    int arabska = Convert.ToInt32(Console.ReadLine());

                    if (arabska > 0 && arabska <= 3999)
                    {
                        tRoman(arabska);

                        Console.ReadKey();
                    }

                    else

                    {
                        Console.WriteLine("Liczba poza przedziałem!");
                    }
                }
            }
            else if (wybor == 2)
            {
                while (true)
                {
                    Console.Write("Podaj liczbę rzymską od I do MMMCMXCIX: ");
                    string rzymska = Console.ReadLine();

                    toArab(rzymska);
                    Console.ReadKey();
                }
            }
        

            return;
        }




            static string tRoman(int a)
            {
                string signsc = "MDCLXVI";
                int[] signsv = { 1000, 500, 100, 50, 10, 5, 1 };
                string w = "";

                for (int i = 0; i < signsc.Length; i++)
                {
                    while (a >= signsv[i])
                    {
                        w += signsc[i];
                        a -= signsv[i];
                    }

                    int j = (i % 2 == 0) ? 2 : 1;

                    while (i + 1 < signsc.Length && a >= signsv[i] - signsv[i + j])
                    {
                        w += signsc[i + j];
                        w += signsc[i];
                        a -= (signsv[i] - signsv[i + j]);
                    }
                }

                Console.WriteLine(w);

                return w;


            }

        static int toArab(string b)
        {
            string signsc = "MDCLXVI";
            int[] signsv = { 1000, 500, 100, 50, 10, 5, 1 };
            int w = 0, t = 0;
            for (int i = 0; i < signsc.Length; i++)
            {
                while ((t = b.IndexOf(signsc[i])) != -1)
                {
                    w += signsv[signsc.IndexOf(b[t])];
                    for (int j = 0; j < t; j++)
                    {
                        w -= signsv[signsc.IndexOf(b[j])];
                    }
                    b = b.Substring(t + 1, b.Length - 1);
                }
            }
            Console.WriteLine(w);
            return w;
        }
    }


    }

