using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihanmethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int hasil;

            Calculator calculator = new Calculator();

            hasil = calculator.Penjumlahan(10, 2);
            CetakHasil("hasil penjumlahan :" + hasil);


            hasil = calculator.Penjumlahan(10, 2, 3);
            CetakHasil("hasil penjumlahan overload :" + hasil);


            hasil = calculator.Pengurangan(7, 2);
            CetakHasil("hasil pengurangan :" + hasil);


            hasil = Calculator.Perkalian(5, 2);
            CetakHasil("hasil perkalian :" + hasil);

            Console.ReadKey();

            
        }
        static void CetakHasil(string hasil)
        {
            Console.WriteLine(hasil);
        }
    }
}
