using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindegy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("szia hogy hivnak ?");
            var nev = Console.ReadLine();
            Console.WriteLine($"Oh, milyen szép név az{nev}");
            Console.WriteLine("Szeretsz programozni?");
            var valasz = Console.ReadLine();
            if (valasz.ToLower() == "igen")
            {
                Console.WriteLine("akkor mi nagyon jo barátok leszünk !");
            }
            else
            {
                Console.WriteLine(":(");
                Console.WriteLine("Akkor visszlát :(");
            }
            

            Console.ReadKey();
        }

    }
}
