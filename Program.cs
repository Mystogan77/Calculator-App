using System;
using System.Data.SqlTypes;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Kalkulator";

            char pilihan;
            Console.WriteLine("=================================");
            Console.WriteLine(" |   Calculator Console App    | ");
            Console.WriteLine("=================================");
            Console.WriteLine("\n");
            Console.WriteLine("=================================");
            Console.WriteLine(" |       Masukkan Pilihan      | ");
            Console.WriteLine("=================================");
            Console.WriteLine(" 					              ");
            Console.WriteLine(" |	(A) Tambah      (B) Kurang	   | ");
            Console.WriteLine(" |	(C) Kali        (D) Bagi	   | ");
            Console.WriteLine("    				               ");
            Console.WriteLine("=================================");
            Console.WriteLine(" Masukan Pilihan		: ");
            pilihan = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\n");


            if (pilihan == 'A' || pilihan == 'a')
            {
                Console.WriteLine(" ========================================");
                Console.WriteLine(" |	     Masukan Bilangan		");
                Console.WriteLine(" ========================================");
                Console.WriteLine(" |					");
                Console.WriteLine(" | Masukan Bilangan pertama : ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(" | Masukan Bilangan kedua : ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" |					");
                Console.WriteLine(" ========================================");
                Console.WriteLine(" | Hasilnya Adalah : " + Penambahan(a, b) + "   ");
                Console.WriteLine(" ========================================");

            }
            else if (pilihan == 'B' || pilihan == 'b')
            {
                Console.WriteLine(" ========================================");
                Console.WriteLine(" |	     Masukan Bilangan		");
                Console.WriteLine(" ========================================");
                Console.WriteLine(" |					");
                Console.WriteLine(" | Masukan Bilangan pertama : ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(" | Masukan Bilangan kedua : ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" |					");
                Console.WriteLine(" ========================================");
                Console.WriteLine(" | Hasilnya Adalah : " + Penambahan(a, b) + "   ");
                Console.WriteLine(" ========================================");

            }
            else if (pilihan == 'C' || pilihan == 'c')
            {
                Console.WriteLine(" ========================================");
                Console.WriteLine(" |	     Masukan Bilangan		");
                Console.WriteLine(" ========================================");
                Console.WriteLine(" |					");
                Console.WriteLine(" | Masukan Bilangan pertama : ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(" | Masukan Bilangan kedua : ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" |					");
                Console.WriteLine(" ========================================");
                Console.WriteLine(" | Hasilnya Adalah : " + Perkalian(a, b) + "   ");
                Console.WriteLine(" ========================================");
            }
            else if (pilihan == 'D' || pilihan == 'd')
            {
                Console.WriteLine(" ========================================");
                Console.WriteLine(" |	     Masukan Bilangan		");
                Console.WriteLine(" ========================================");
                Console.WriteLine(" |					");
                Console.WriteLine(" | Masukan Bilangan pertama : ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(" | Masukan Bilangan kedua : ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" |					");
                Console.WriteLine(" ========================================");
                Console.WriteLine(" | Hasilnya Adalah : " + Pembagian(a, b) + "   ");
                Console.WriteLine(" ========================================");
            }
            Console.WriteLine("\n");
            Console.WriteLine(" ========================================");
            Console.WriteLine(" | 17.11.1800 ARFIAN YOGA P P 		");
            Console.WriteLine(" ========================================");
            Console.WriteLine(" ");
        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian (int a, int b)
        {
            return a * b;
        }
        static int Pembagian (int a, int b)
        {
            return a / b;
        }
    }
}