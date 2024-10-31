using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_Console
{
    internal class Kisi
    {

        public void KisiBilgileri(string name, string surname, int age)
        {
            Console.WriteLine(name + " " + surname.ToUpper() + " " + age);
        }
    }
}
