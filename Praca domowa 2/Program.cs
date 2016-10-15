//zadeklarowac zmienna carName i przypisac jej wartosc "Moj samochod"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgObiekt002
{
    class Program
    {
        static void Main(string[] args)
        {
            string carName = "Mój samochód\n";

            Console.WriteLine(carName);

            Car car1 = new Car();
            car1.marka = "Ford";
            car1.rok = 2001;
            Car car2 = new Car();
            car2.marka = "Opel";
            car2.rok = 1999;
            Console.WriteLine("Marka: {0} Rok: {1}\n", car1.marka, car1.rok);
            Console.WriteLine("Marka: {0} Rok: {1}\n", car2.marka, car2.rok);

            car1 = car2;
            Console.WriteLine("Marka: {0} Rok: {1}\n", car1.marka, car1.rok);
            Console.WriteLine("Marka: {0} Rok: {1}\n", car2.marka, car2.rok);

            //Car car3 = new Car();
            //Console.Write("Podaj marke: "); car3.marka = Console.ReadLine();
            ////pytanie:
            ////    Console.Write("Podaj rok produkcji: ");
            ////    car3.rok = Int32.Parse(Console.ReadLine());
            ////    if (car3.rok < 1885 || car3.rok > 2016)
            ////    {
            ////        Console.WriteLine("Zły rok !");
            ////        goto pytanie;
            ////    }
            //do
            //{
            //    Console.Write("Podaj rok produkcji: ");
            //    car3.rok = Int32.Parse(Console.ReadLine());
            //    if (car3.rok < 1885 || car3.rok > 2016)
            //        Console.WriteLine("Zły rok !");
            //} while (car3.rok < 1885 || car3.rok > 2016);
            //Console.WriteLine("\nMarka: {0} Rok: {1}\n", car3.marka, car3.rok);



            //1.Utworzyc prywatne pola classy Car i narysowac dla klasy Car diagram UML
            //2.kolejne czynnosci uzupelniac na diagramie
            //3. Utworzyc wlasciwosci dostepowe dla wszystkich pol klasy Car
            //4. Utworzyc w klasie Car private static int iloscSamochodow i przypisac mu wartosc 0



            //utworzyc private metode o nazwie ObliczSpalanie zwracajacej double i przyjmujacej parametr
            //dlugoscTrasy typu double
            //metoda ta ma obliczac spalanie samochodu na podstawie podanej wartosci
            //dlugosciTrasy i wartosci pola srednieSpalanie
            //wg wzoru spalanie = (srednieSpalanie * dlugoscTrasy)/100;


            //utworzyc public metode ObliczKosztPrzejazdu zwracajaca wartosc typu double
            // i przyjm parametry double dlugoscTrasy i double cenaPaliwa
            //metoda ta ma obliczac koszt przejazdu na trasie o podanej dlugosci zakladajac
            //podana cene paliwa za litr
            //metoda ta ma wykorzystywac private metode ObliczSpalanie
            //koszt przejazdu obliczamy wg wzoru
            //kosztPrzejazdu = spalanie * cenaPaliwa

            Car car4 = new Car();
            car4.marka = "Opel";
            car4.rok = 2005;
            car4.srednieSpalanie = 8.0;
            Console.WriteLine(car4.obliczKosztPrzejazdu(100.0, 5.0));

            // NOWY PROJEKT
            //utworzyc static metode OpiszTyp ktora bedzie przeciazona i bedzie zwracala
            //przykladowe wartosci typow w zaleznosci od rodzaju i liczby argumentow

            //konto na github.com i umiescic dowolny kod
            //i wyslac maila z linkiem
            // kolev@matman.uwm.edu.pl
            Console.ReadKey();
        }
    }
}