using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    public class Prostokat // Definicja klasy.
    {
        public int a, b;   // Czlonkowie klasy, dł bokow:
        public int[,] tab = new int [2,2];           


        public int Metoda() // Metoda.

        {
           return  tab[1, 0] = a;
           

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
            klocek.tab[0, 0] = 4;
           

            int wynik = klocek.Metoda();   // wywolanie publicznej metody.
            Console.WriteLine(wynik);       //wyswietlenie wyniku metody
            Console.WriteLine(klocek.tab[0, 0]);
            Console.ReadLine();
        }
    }
}
