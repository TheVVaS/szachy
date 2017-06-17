using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Position
    {

        private int x;
        private int y;

        public Position(string position)
        {
            this.x = Encoding.ASCII.GetBytes(position)[0] - 64;
            this.y = Encoding.ASCII.GetBytes(position)[1] - 48;
        }

        public int getX()
        {
            return this.x;
        }

        public int getY()
        {
            return this.y;
        }

        public string getField()
        {

            char fieldX = Convert.ToChar(64 + this.x);
            string fieldY = this.y.ToString();

            return fieldX + fieldY;
        }

    }
}
