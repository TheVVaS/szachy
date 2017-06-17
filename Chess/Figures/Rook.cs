using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Figures
{
    class Rook : Figure
    {

        public string name = "Wieża";

        public Rook(Position position, String color) : base(position, color) { }

        public override bool canMove(Position nextPosition)
        {

            if (nextPosition.getX() > 8 || nextPosition.getX() < 1 || nextPosition.getY() > 8 || nextPosition.getY() < 1)
            {
                return false;
            }

            if ((nextPosition.getX() != currentPosition.getX() && nextPosition.getY() == currentPosition.getY()) ||
                (nextPosition.getX() == currentPosition.getX() && nextPosition.getY() != currentPosition.getY()))
            {
                return true;
            }

            return false;
        }
    }
}
