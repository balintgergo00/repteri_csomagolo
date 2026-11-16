using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repteri_csomagolo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<double> S = new List<double>();
            List<double> M = new List<double>();
            List<double> L = new List<double>();

            while (true)
            {
                Console.Write("Adja meg a csomag súlyát (vagy 0-t a kilépéshez): ");
                double suly = double.Parse(Console.ReadLine());

               
                if (suly == 0)
                {
                    break;
                }
                else if (suly < 0 || suly > 30)
                {
                    Console.WriteLine("Nem lehetséges a csomagolás (érvénytelen súly vagy túl nehéz)");
                }
                else if (suly <= 5)
                {
                    S.Add(suly);
                }
                else if (suly <= 15) 
                {
                    M.Add(suly);
                }
                else 
                {
                    L.Add(suly);
                }

                Console.WriteLine($"S: {S.Count}");
                Console.WriteLine($"M: {M.Count}");
                Console.WriteLine($"L: {L.Count}");
                Console.WriteLine();
            }
        }
    }
}
