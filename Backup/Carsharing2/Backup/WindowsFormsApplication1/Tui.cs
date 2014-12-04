using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsharing
{
    class Tui : IUi
    {
        public void show()
        {
            string returnvalue;
            Carsharing carsharing = new Carsharing(1, "Autohaus Möller", "Wiener Straße 3");

            Console.WriteLine("*************************************");
            Console.WriteLine("Autovermietung");
            Console.WriteLine("*************************************");
            Console.WriteLine("");
            Console.WriteLine("Mieter anlegen  (a)");
            Console.WriteLine("Mieter anzeigen (b)");
            Console.WriteLine("Mieter löschen  (c)");
            Console.WriteLine("");
            Console.WriteLine("*************************************");
            Console.WriteLine("");
            Console.WriteLine("Auto anlegen    (d)");
            Console.WriteLine("Auto anzeigen   (e)");
            Console.WriteLine("Auto löschen    (f)");
            Console.WriteLine("");
            Console.WriteLine("*************************************");
            Console.WriteLine("");
            Console.WriteLine("Auto Ausleihen  (g)");
            Console.WriteLine("Auto zurückgeben(h)");
            returnvalue = Console.ReadLine();

            if (returnvalue == "a")
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Alter: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Adresse: ");
                string adress = Console.ReadLine();
                
                carsharing.createLender(name, age, adress);
                Console.ReadLine();
            }

            
            carsharing.loadData();
            Console.ReadLine();
            
        }
    }
}
