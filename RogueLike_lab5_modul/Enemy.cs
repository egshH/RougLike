using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike_lab5_modul
{
    internal class Enemy
    {
        int _hp;
        int _dmg;
        int _max_hp;
        Type_Of_Monsters _type; //DRAGON, UGABUGA, IvanVinogradov, Lilya, Liza
        enum Type_Of_Monsters
        {
            DRAGON = 0,
            UGABUGA,
            IvanVinogradov,
            Lilya,
            Liza
        }

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

        public string Type
        {
            get
            {
                return Convert.ToString(_type);
            }
            //set
            //{
            //    _type = value;
            //}
        }

        public Enemy(int HP, int DMG, int Type)
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

            _type = (Type_Of_Monsters)Type;

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
    }
}
