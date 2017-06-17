using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Figures
{
    class Knight : Figure
    {

        public string name = "Skoczek";

        public Knight(Position position, String color) : base(position, color) { }

        public override bool canMove(Position nextPosition)
        {

            if (nextPosition.getX() > 8 || nextPosition.getX() < 1 || nextPosition.getY() > 8 || nextPosition.getY() < 1)
            {
                return false;
            }

            if (
                (currentPosition.getX() + 1 == nextPosition.getX() && currentPosition.getY() + 2 == nextPosition.getY()) ||
                (currentPosition.getX() - 1 == nextPosition.getX() && currentPosition.getY() + 2 == nextPosition.getY()) ||

                (currentPosition.getX() - 2 == nextPosition.getX() && currentPosition.getY() + 1 == nextPosition.getY()) ||
                (currentPosition.getX() - 2 == nextPosition.getX() && currentPosition.getY() - 1 == nextPosition.getY()) ||

                (currentPosition.getX() + 2 == nextPosition.getX() && currentPosition.getY() + 1 == nextPosition.getY()) ||
                (currentPosition.getX() + 2 == nextPosition.getX() && currentPosition.getY() - 1 == nextPosition.getY()) ||

                (currentPosition.getX() + 1 == nextPosition.getX() && currentPosition.getY() - 2 == nextPosition.getY()) ||
                (currentPosition.getX() - 1 == nextPosition.getX() && currentPosition.getY() - 2 == nextPosition.getY()))
            {
                return true;
            }

            return false;
        }
    }
}
