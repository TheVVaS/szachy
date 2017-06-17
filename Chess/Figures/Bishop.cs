using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Figures
{
    class Bishop : Figure
    {

        public string name = "Goniec";

        public Bishop(Position position, String color) : base(position, color){ }

        public override bool canMove(Position nextPosition)
        {

            if (nextPosition.getX() > 8 || nextPosition.getX() < 1 || nextPosition.getY() > 8 || nextPosition.getY() < 1)
            {
                return false;
            }

            try
            {
                if (currentPosition == null)
                {
                    return true;
                } else 
                if ((Math.Abs(Math.Abs(nextPosition.getX() - currentPosition.getX()) / Math.Abs(nextPosition.getY() - currentPosition.getY())) == 1))
                {
                    return true;
                }

            }
            catch (DivideByZeroException){}

            return false;
        }
    }
}
