using Chess.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{

    class Program
    {

        public static Board board = new Board();

        static void Main(string[] args)
        {
            createFigure("Pawn", "B1", "czarny");
            createFigure("Pawn", "B2", "czarny");
            createFigure("Pawn", "B3", "czarny");
            createFigure("Pawn", "B4", "czarny");
            createFigure("Pawn", "B5", "czarny");
            createFigure("Pawn", "B6", "czarny");
            createFigure("Pawn", "B7", "czarny");
            createFigure("Pawn", "B8", "czarny");

            Console.ReadKey();
        }

        static void createFigure(String figure, String position, String color)
        {
            switch (figure)
            {
                case "Bishop":
                    new Bishop(new Position(position), color);
                    break;

                case "Knight":
                    new Knight(new Position(position), color);
                    break;

                case "Pawn":
                    new Pawn(new Position(position), color);
                    break;

                case "Rook":
                    new Rook(new Position(position), color);
                    break;
            }
        }
    }
}
