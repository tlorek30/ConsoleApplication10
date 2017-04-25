using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    public class prostokat // definicja klasy.
    {
        public int a, b;   // czlonkowie klasy:
        public int[] tabprost;             

        public int punkty() // Metoda.

        {
            return 0;
  
        }

        public prostokat()     // konstruktor.
        {
            a = 0;
            b = 0;
            tabprost[2]=0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            prostokat figura = new prostokat(); // utworzenie obiektu.
            
            figura.a = 2; //nadanie wartosci
            figura.b = 3;
            figura.tabprost = 0;

            int wynik = prostokat.punkty();   // wywolanie publicznej metody
            Console.WriteLine(wynik);       //wyswietlenie wyniku
            Console.ReadLine();
        }
    }
}
