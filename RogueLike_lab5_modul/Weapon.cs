using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike_lab5_modul
{
    internal class Weapon
    {
        int _dmg;
        int _dura;
        Type_of_weapon _type;



        enum Type_of_weapon
        {
            Pistol = 0,
            Tank,
            Oreshnik
        }

        public int Dmg
        {
            get
            {
                return _dmg;
            }
        }

        public int Durability
        {
            get
            {
                return _dura;
            }
            set
            {
                _dura = value;
            }
        }

        public string Type
        {
            get
            {
                return Convert.ToString(_type);
            }
        }

        public Weapon(int DMG, int DURA, int TYPE)
        {
            _dmg = DMG;
            _dura = DURA;
            _type = (Type_of_weapon)TYPE;
        }

        public bool BrokenItem()
        {
            if (_dura > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
