using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Starship Serenity = new Starship("Serenity", "Firefly", "404-E-132-4FE274A", 9);
            Console.WriteLine("Added ship");
            Serenity.AddCrew("Captain", "Malcolm Reynolds");
            Console.WriteLine("Added 1");
            Serenity.AddCrew("FirstMate", "Zoe Washburne");
            Console.WriteLine("Added 2");
            Serenity.AddCrew("Pilot", "Hoban Washburne");
            Console.WriteLine("Added 3");
            Serenity.AddCrew("Engineer", "Kaywinnet Lee Frye");
            Console.WriteLine("Added 4");
            Serenity.AddCrew("PublicRelations", "Jayne Cobb");
            Console.WriteLine("Added 5");
            Serenity.AddCrew("Ambassador", "Inara Serra");
            Console.WriteLine("Added 6");
            Serenity.AddCrew("Shepherd", "Derrial Book");
            Console.WriteLine("Added 7");
            Serenity.AddCrew("Medic", "Simon Tam");
            Console.WriteLine("Added 8");
            Serenity.AddCrew("Crew", "River Tam");
            Console.WriteLine("Added 9");
            Serenity.AddCrew("Crew", "TTOMMy Tam");

            Serenity.Print();
            Serenity.PrintRoster();
            Console.ReadLine();
        }
    }
}
