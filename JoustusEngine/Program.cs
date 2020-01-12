using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoustusEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            BoardSpace[,] board = new BoardSpace[5,5];

            for (int i = 0; i < 5; i++) {
                for (int j = 0; j < 5; j++) {
                    bool extremeI = (i == 0 || i == 4);
                    bool extremeJ = (j == 0 || j == 4);
                    bool isCorner = extremeI && extremeJ;
                    bool isSide = (extremeI && !extremeJ) || (!extremeI && extremeJ);
                    if (isCorner) {
                        board[i, j] = new BoardSpace(SpaceType.Closed);
                    }
                    else if (isSide)
                    {
                        board[i, j] = new BoardSpace(SpaceType.Grave);
                    }
                    else 
                    {
                        board[i, j] = new BoardSpace(SpaceType.Open, (i + j) % 3 == 0);
                    }
                }
            }

            for (int i = 0; i < 21; i++) {
                if (i % 4 == 0) {
                    Console.WriteLine("+---+---+---+---+---+");
                }
                else {
                    string row = "|";
                    for (int j = 0; j < 5; j++) {
                        row += $"{board[(i - 1) / 4, j].RenderRow((i % 4) - 1)}|";
                    }
                    Console.WriteLine(row);
                }
            }
            Console.ReadKey();
        }
    }
}
