using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike_lab5_modul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your character name:");
            string Name = Console.ReadLine();
            
            Player player = new Player(100, 20, Name);

            Battle battle = new Battle(player);

            while (player.Live())
            {
                battle.Start();
            }
        }
    }
}
