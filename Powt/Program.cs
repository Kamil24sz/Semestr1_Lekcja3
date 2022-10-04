using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powt
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Powtórka z wypisywania danych
            string gra = "Counter Strike";
            string postac = "Anty-Terrorysta";
            string wiek = "nieznany";
            float wzorst = 1.80f;
            char plec = 'm';
            bool czyPotrafiStrzelac = true;

            Console.WriteLine($"Moja postać pochodzi z gry {gra}");
            Console.WriteLine($"Postać: {postac}");
            Console.WriteLine($"Wiek: {wiek}");
            Console.WriteLine($"Wzrost: {wzorst}");
            Console.WriteLine($"Płeć: {plec}");
            Console.WriteLine($"Czy potrafi strzelać: {czyPotrafiStrzelac}");

            Console.ReadLine();

        }
    }
}
