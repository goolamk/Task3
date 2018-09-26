using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18015639_Goolam_Khan_Poe_rae9T
{
     abstract class Units
    {
        protected int posX;

        protected int posY;

        protected int hp;

        protected int speed;

        protected int atc;

        protected int atcRange;

        protected int team;

        protected int symb;

        abstract public int Unit();

        abstract public int newPosition();

        abstract public int Combat();

        abstract public int withinRange();

        abstract public int closestUntit();

        abstract public int handelDeath();

        abstract public int tooString();


    }
    
    
}
