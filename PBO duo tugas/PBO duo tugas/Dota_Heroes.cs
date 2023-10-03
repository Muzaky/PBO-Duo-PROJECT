using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dota_Heroes
{
    abstract class Heroes
    {
        public string name, move;
        public int health, level, exp;

        public abstract void attack();

    }

    interface Skillusage
    {
        void skill();
    }

}