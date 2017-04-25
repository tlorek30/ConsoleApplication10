using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    public class Prostokat // Definicja klasy.
    {
        public int a, b;   // Czlonkowie klasy:
                              


        public int Metoda() // Metoda.

        {
            return a * b;
        }

        public Prostokat()     // Konstruktor.
        {
            a = 0;
            b = 0;
        
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Prostokat klocek = new Prostokat(); // Utworzenie obiektu
            
            klocek.a = 2;                       //Nadanie wartosci
            klocek.b = 3;
           

            int wynik = klocek.Metoda();   // wywolanie publicznej metody.
            Console.WriteLine(wynik);       //wyswietlenie wyniku metody
            Console.ReadLine();
        }
    }
}
