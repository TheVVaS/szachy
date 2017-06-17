using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Board
    {
        public Figure[,] Figures = new Figure[9,9];
        public Figure this[string position]
        {
            get
            {
                int x = Encoding.ASCII.GetBytes(position)[0] - 64;
                int y = Encoding.ASCII.GetBytes(position)[1] - 48;

                return this.Figures[x,y];
            }

            set
            {
                int x = Encoding.ASCII.GetBytes(position)[0] - 64;
                int y = Encoding.ASCII.GetBytes(position)[1] - 48;

                this.Figures[x, y] = value;
            }

        }
    }
}
