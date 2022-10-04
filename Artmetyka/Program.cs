using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artmetyka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operacje Arytmetyczne
            int a = 10;
            int b = 7;
            int wynik;

            //Dodawanie
            Console.WriteLine("Dodawanie:");
            wynik = a + b;
            Console.WriteLine($"{a} + {b} = {wynik}");

            //Odjemownaie
            Console.WriteLine("Odejmowanie:");
            wynik = b - a;
            Console.WriteLine($"{b} - {a} = {wynik}");

            //Mnożenie
            Console.WriteLine("Mnożenie:");
            wynik = a * b;
            Console.WriteLine($"{a} * {b} = {wynik}");

            //Dzielenie całkowite
            Console.WriteLine("Dzielenie:");
            wynik = a / b;
            Console.WriteLine($"{a} / {b} = {wynik}");

            //Reszta z dzielenia - modulo
            Console.WriteLine("Reszta z dzielenia");
            wynik = a % b;
            Console.WriteLine($"{a} % {b} = {wynik}");

            //Precyzja podczas wykonywania działań
            Console.WriteLine("Precyzja");
            double a2 = 10;
            double b2 = 7;
            Console.WriteLine($"{a2} / {b2} = {a2 / b2}");


            Console.WriteLine("Wprowadź liczbę:");
            //Wprowadzanie danych przez użytkownika
            //dane od użytkownika zawsze są w formacie string!!!
            string daneOdUżytkownika;
            daneOdUżytkownika = Console.ReadLine();

            //Konwersja ze string na int - można użyć już przypisanej zmiennej string lub użyć Console.ReadLine()
            int liczbaOdUżytkownika = int.Parse(daneOdUżytkownika);

            int liczba = 10;
            //jeśli konwersja się uda uzyskujemy winik dodawnia 
            Console.WriteLine($"Liczba uzytkownika + {liczba} = {liczbaOdUżytkownika + liczba}");

            //Zadanie po przerwie:
            //Piszemy program, który obliczy pole trapezu!!!
            //P = (a +b) * h / 2

            //pusta linijka
            Console.WriteLine();

            Console.WriteLine("Program obliczajacy pole trapezu");

            Console.WriteLine("Podaj długość krawędzi a");
            double a3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj długość krawędzi b");
            double b3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj długość wysokości h");
            double h = double.Parse(Console.ReadLine());

            double p = (a3 + b3) * h / 2;
            Console.WriteLine("Pole trapezu wynosi " + p);

            //Klasa Math
            //Math.Pow - Potęgownie Math.Pow(podstawa,potęga)
            Console.WriteLine("2 do potęgi 10");
            Console.WriteLine(Math.Pow(2, 10));
            


            Console.ReadLine();
        }
    }
}
