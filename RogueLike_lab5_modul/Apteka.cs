using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLike_lab5_modul
{
    internal class Apteka
    {
        int _plus_hp;
        int _count_of_heal;
        Random _random = new Random();
        public Apteka(int CountHeal = 1)
        {
            _plus_hp = _random.Next(1, 5) * 5;
            _count_of_heal = CountHeal;

        }
        public int HealPoints
        {
            get
            {
                return _plus_hp;
            }
        }
        public int CountOfHeal
        {
            get
            {
                return _count_of_heal;
            }
            set
            {
                _count_of_heal = value;
            }
        }
    }
}
