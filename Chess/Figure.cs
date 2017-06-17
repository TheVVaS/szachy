using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    abstract class Figure
    {

        public Position currentPosition;
        public string color;
        public string name;
        public abstract bool canMove(Position position);

        protected Figure(Position position, string color)
        {
            this.currentPosition = position;
            this.setColor(color);

            Program.board[this.currentPosition.getField()] = this;
            Logs.write(this.color + " " + this.name + " postawiony na pozycji (" + position.getField() + ")");
        }
        
        public void moveTo(Position position)
        {

            if (this.canMove(position))
            {
                Position oldPosition = this.currentPosition;
                this.currentPosition = position;
                Logs.write(this.name + " zmienił pozycję z (" + oldPosition.getField() + ") na (" + position.getField() + ")");
            }
            else
            {
                Position oldPosition = this.currentPosition;
                Logs.write(this.name + " nie może ruszyć się do (" + position.getField() + ") z pozycji (" + oldPosition.getField() + ")");
            }

        }

        private void setColor(string color)
        {
            if (color != "czarny" || color != "biały")
            {
                color = "czarny";
            }

            this.color = color;
        }
    }
}
