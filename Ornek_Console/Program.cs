using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, surname;
            int age;

            Console.Write("İsim  : ");
            name = Console.ReadLine();
            Console.Write("Soyadı: ");
            surname = Console.ReadLine();
            Console.Write("Yaş   : ");
            age = int.Parse(Console.ReadLine());

            Kisi kisi = new Kisi();
            kisi.KisiBilgileri(name, surname, age);
            Console.WriteLine("------------------");

            Ogrenci ogr = new Ogrenci();
            Console.WriteLine("------------------");

            Kimlik kimlik = new Kimlik();
            Console.WriteLine(kimlik.Ad);

            Console.Read();
        }
    }
}
