using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCreator
{
    public class weapons
    {
        public string name, damage;
        public int atkBonus;

        public weapons (string _name, int _atkBonus, string _damage )
        {
            name = _name;
            atkBonus = _atkBonus;
            damage = _damage;
        }
    }
}
