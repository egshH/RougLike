using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike_lab5_modul
{
    internal class Battle
    {
        Player player;
        Random rnd = new Random();
        
        public Battle(Player user)
        {
            player = user;
        }

        public void Start()
        {

            Enemy enemy = new Enemy(100, rnd.Next(1,5) * 5, rnd.Next(0,5));

            while (enemy.Live() && player.Live())
            {
                Console.WriteLine($"Appeared in front of you:\n{enemy.Type}\nHis hp:\n{enemy.Hp}/{enemy.MaxHp}\nHis damage:\n{enemy.Dmg}\n");
                Console.WriteLine($"Your live status:\nalive\nYour hp:\n{player.Hp}/{player.MaxHp})\nYour damage:\n{player.Dmg} + {player.DAMAGE_Weapon}");
                Console.WriteLine($"Here's what you can do:\n1.Battle\n2.Use your heal({player.amountHeals} left)");

                string choise = Console.ReadLine();

                Console.Clear();

                switch (choise)
                {
                    case "1":
                        player.Hp -= enemy.Dmg;
                        enemy.Hp -= player.Dmg + player.DAMAGE_Weapon;
                        player.DMG_Weapon(1);
                        break;
                    case "2":
                        if (player.amountHeals > 0)
                        {
                            player.UseApt();
                        }
                        else
                        {
                            Console.WriteLine("You havent heals!\n\n\n\n\n\n");
                        }
                        break;
                    default: Console.WriteLine("Error: you can't use the non-existent action\n\n\n\n\n\n");
                        break;
                }
            }
            if (player.BrokenWeapon)
            {
                player.NewWeapon();
            }
            else
            {
                player.amountHeals += 1;
            }
        }

    }
}
