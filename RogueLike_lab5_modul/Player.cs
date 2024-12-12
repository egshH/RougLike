using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike_lab5_modul
{
    internal class Player
    {
        int _hp;
        int _dmg;
        int _max_hp;
        string _name;

        Apteka apt = new Apteka();

        Weapon weapon = new Weapon(0, 1, 0);

        Random rnd = new Random();
        public int Hp
        {
            get
            {
                return _hp;
            }
            set
            {
                _hp = value;
            }
        }

        public int MaxHp
        {
            get
            {
                return _max_hp;
            }
            set
            {
                _max_hp = value;
            }

        }

        public int Dmg
        {
            get
            {
                return _dmg;
            }
            set
            {
                _dmg = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int amountHeals
        {
            get
            {
                return apt.CountOfHeal;
            }
            set
            {
                apt.CountOfHeal = value;
            }
        }
        public Player(int HP, int DMG, string NAME = "Player")
        {

            if (HP <= 0)
            {
                _hp = 100;
            }
            else
            {
                _hp = HP;
            }
            if (DMG <= 0)
            {
                _dmg = 100;
            }
            else
            {
                _dmg = DMG;
            }

            _max_hp = _hp;

            _name = NAME;

        }
        public bool Live()
        {
            if (_hp <= 0)
            {
                return false;
            }
            else 
            {
                return true; 
            }
        }
        public void UseApt()
        {
            apt.CountOfHeal -= 1;
            if ((_max_hp - _hp) < apt.HealPoints)
            {
                _hp = _max_hp;
            }
            else
            {
                _hp += apt.HealPoints;
            }
        }

        public void NewWeapon()
        {
            weapon = new Weapon(rnd.Next(1,5) * 5, rnd.Next(1, 4) * 10, rnd.Next(0, 3));
        }

        public void DMG_Weapon(int damage)
        {
            weapon.Durability -= damage;
            if (weapon.Durability == 0)
            {
                NewWeapon();
            }
        }

        public bool BrokenWeapon
        {
            get
            {
                return weapon.BrokenItem();
            }
        }

        public int DAMAGE_Weapon
        {
            get
            {
                return weapon.Dmg;
            }
        }
    }
}
