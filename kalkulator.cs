using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    class kalkulator
    {
        static void Main(string[] args)
        {
            int bil1, bil2;
            int opsi;

            Console.WriteLine(" ----------------------------------- ");
            Console.WriteLine(" |       Kalkulator Sederhana      | ");
            Console.WriteLine(" ----------------------------------- ");
            Console.WriteLine(" |         1. Penjumlahan          | ");
            Console.WriteLine(" |         2. Pengurangan          | ");
            Console.WriteLine(" |         3. Perkalian            | ");
            Console.WriteLine(" |         4. Pembagian            | ");
            Console.WriteLine(" ----------------------------------- ");
            Console.Write(" Masukkan Pilihan = ");
            opsi = int.Parse(System.Console.In.ReadLine());

            switch (opsi)
            {

                case 1:

                    Console.Write(" Masukan angka pertama   : ");
                    bil1 = int.Parse(System.Console.In.ReadLine());
                    Console.Write(" Masukan angka kedua     : ");
                    bil2 = int.Parse(System.Console.In.ReadLine());
                    Console.Write(" Hasil dari penjumlahan  = ");
                    Console.WriteLine(bil1 + bil2);
                    break;

                case 2:

                    Console.Write(" Masukan angka pertama   : ");
                    bil1 = int.Parse(System.Console.In.ReadLine());
                    Console.Write(" Masukan angka kedua     : ");
                    bil2 = int.Parse(System.Console.In.ReadLine());
                    Console.Write(" Hasil dari pengurangan  = ");
                    Console.WriteLine(bil1 - bil2);
                    break;

                case 3:

                    Console.Write(" Masukan angka pertama   : ");
                    bil1 = int.Parse(System.Console.In.ReadLine());
                    Console.Write(" Masukan angka kedua     : ");
                    bil2 = int.Parse(System.Console.In.ReadLine());
                    Console.Write(" Hasil dari perkalian    = ");
                    Console.WriteLine(bil1 * bil2);
                    break;

                case 4:

                    Console.Write(" Masukan angka pertama   :");
                    bil1 = int.Parse(System.Console.In.ReadLine());
                    Console.Write(" Masukan angka kedua     :");
                    bil2 = int.Parse(System.Console.In.ReadLine());
                    Console.Write(" Hasil dari pembagian    = ");
                    Console.WriteLine(bil1 / bil2);
                    break;

                default:
                    Console.WriteLine(" Menu yang anda pilih tidak tersedia");
                    break;
            }

            Console.Write(" Hitung Lagi? ");
            Console.Write(" Y/N ");
            string ric;
            ric = Convert.ToString(System.Console.ReadLine());
            switch (ric)

            {

                case "Y":
                    Console.WriteLine(" Silahkan Menghitung lagi ");
                    Console.ReadKey();
                    break;

                case "N":
                    Console.WriteLine(" Tekan tombol apa saja untuk keluar ");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
