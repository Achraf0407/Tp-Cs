using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierN
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Client cl1 = new Client("BENALI", "Saad", "Hay laymoune 113nr");
            Client cl2 = new Client("ALI", "Saadoui", "Hay manara 220 a");
        
            Comptes C = new Comptes(new MAD(5200), cl1, new MAD(2000));
            Comptes C2 = new Comptes(new MAD(6000) , cl2, new MAD(3200));

            C.Consulter();
            C2.Consulter();

            C.Verser(C2, new MAD(1000));
            Console.WriteLine("\n         Apres les virement:\n");
           
            C.Consulter();
            C2.Consulter();

            Console.ReadKey();

        }
    }
}
