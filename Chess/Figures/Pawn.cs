using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Figures
{
    class Pawn : Figure
    {

        public string name = "Pionek";

        public Pawn(Position position, String color) : base(position, color) { }

        public override bool canMove(Position nextPosition)
        {
            if (nextPosition.getX() > 8 || nextPosition.getX() < 1 || nextPosition.getY() > 8 || nextPosition.getY() < 1)
            {
                return false;
            }

            if (currentPosition.getX() == nextPosition.getX() && currentPosition.getY() + 1 == nextPosition.getY())
            {
                return true;
            }

            return false;
        }
    }
}
