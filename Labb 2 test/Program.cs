using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();

        }

        public static double Run ()
        { 
            Console.WriteLine("Hur många resenärer reser i sällskapet, mellan åldrarna 5-100?");
            string antalResenärer = Console.ReadLine();
            double antalResenärer2 = double.Parse(antalResenärer);
            int i;
            double sum = 0;


            for (i = 0; i < antalResenärer2; i = i + 1)


            {
                Console.WriteLine("Skriv in resenärens namn:");
                string namn = Console.ReadLine();
                double a = Ålder();
                double b = Zon();
                double c = Pris(b);
                double d = Förändringsfaktor(a);
                double e = Kostnad(c, d);
                sum += e;
                Console.WriteLine("Kostnaden för" + " " + namn + "s" + " " + "resa" + " " + "är:" + " " + e + " " + "kronor");
                Console.ReadLine();

            }


            Console.WriteLine("Den totala kostnaden för sällskapet är:" + " " + sum);
            Console.WriteLine();
            return sum;


        }
        public static double Ålder()
        {
            double low = 5;
            double high = 100;
            double result = 0;

            do
            {

                Console.WriteLine("Skriv in resenärens ålder" + " " + "mellan" + " " + low + " " + "och" + " " + high + ":");
                string åldern = (Console.ReadLine());
                result = double.Parse(åldern);
            }
            while ((result < low) || (result > high));
            return (result);
        }

        public static double Zon()
        {

            double low = 1;
            double high = 3;
            double antalzoner = 0;


            do
            {

                Console.WriteLine("Hur många zoner önskar resenären resa, mellan" + " " + low + " " + "och" + " " + high);
                string zoner = (Console.ReadLine());
                antalzoner = double.Parse(zoner);

            }
            while ((antalzoner < low) || (antalzoner > high));
            return (antalzoner);
        }
        public static double Pris(double Zon)
        {
            if (Zon == 1)
            {
                double pris = 100;
                return pris;
            }

            else if (Zon == 2)
            {
                double pris = 150;
                return pris;
            }

            else if (Zon == 3)
            {
                double pris = 200;
                return pris;
            }
            double fel = 4;
            return fel;
        }

        public static double Förändringsfaktor(double ålder)
        {

            if (ålder < 25 || ålder > 60)
            {
                double rabatteratPris = 0.8;
                return rabatteratPris;
            }

            else
            {
                double normaltPris = 1;
                return normaltPris;
            }
        }

        public static double Kostnad(double Pris, double Förändringsfaktor)
        {
            double finalCost = (Pris * Förändringsfaktor);
            Console.WriteLine(finalCost);
            return finalCost;
        }

    }

}
      
