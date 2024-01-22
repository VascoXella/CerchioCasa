using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CerchioCasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cerchio c = new Cerchio();
            Console.WriteLine("Inserisci il raggio:");
            c.Raggio = double.Parse(Console.ReadLine());

            Console.WriteLine("Il perimetro è:{0}, l'area è:{1}", c.Calcolap(), c.Calcolaa());

            Console.ReadLine();
        }
    }
}
