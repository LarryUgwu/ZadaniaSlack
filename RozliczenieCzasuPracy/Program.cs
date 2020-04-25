using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Zaimplementuj klasę `Employee` umożliwiającą rejestrowanie czasu pracy oraz
wypłacanie pensji na podstawie zadanej stawki godzinowej.Jeżeli pracownik
będzie pracował więcej niż 8 godzin (podczas pojedynczej rejestracji czasu) to
kolejne godziny policz jako nadgodziny(z podwójną stawką godzinową).Konstruktor 
klasy niech przyjmuje imię, nazwisko i stawkę godzinową.*/

namespace RozliczenieCzasuPracy
{
    class Program
    {
        static void Main(string[] args)
        {
            
                       
            Console.Write("Imię pracownika: ");
            string imie = Console.ReadLine();

            Console.Write("Nazwisko pracownika: ");
            string nazwisko = Console.ReadLine();

            Console.Write("Stawka godzinowa: ");
            double rate = Convert.ToDouble(Console.ReadLine());



            PaySalary paySalary = new PaySalary(imie, nazwisko, rate);

            double wyplata = paySalary.Wyplata();
            Console.WriteLine("wyplata pracownika " + imie + " " + nazwisko + 
                "po przepracowaniu " + paySalary.czasPracy + " godzin wynosi: {0} ", wyplata);
            Console.ReadKey();
        }
    }
}
