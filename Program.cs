using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CumledenHarfSilme
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder metin = new StringBuilder(" Kodlab yayınevi bünyesinde birçok kitap bulunmaktadır.");
            metin = metin.Remove(0, 10);
            Console.Write(metin);
            Console.ReadKey();
        }
    }
}
