using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GeorgiaDavid_Interfaces
{
    internal class Program
    {
        static AggresiveMoveStrategy _aggresiveMoveStrategy;
        static PassiveMoveStrategy _passiveMoveStrategy;
        static RandomMoveStrategy _randomMoveStrategy;

        static bool isPlaying = true;

        static void Main(string[] args)
        {
            while (isPlaying)
            {
                Position playerPosition = new Position(10, 0);

                Position enemyPosition = new Position(0, 0);

                Player player = new Player(playerPosition, ConsoleColor.Blue);

                Enemy enemy = new Enemy(enemyPosition, ConsoleColor.Red);

                ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.I)
                {
                    enemy._moveStrategy = _aggresiveMoveStrategy;
                }

                else if (keyInfo.Key == ConsoleKey.O)
                {
                    enemy._moveStrategy = _passiveMoveStrategy;
                }

                else if (keyInfo.Key == ConsoleKey.P)
                {
                    enemy._moveStrategy = _randomMoveStrategy;
                }

                if (keyInfo.Key == ConsoleKey.M)
                {
                    enemy.PositionMove(enemyPosition);
                }
            }
        }
    }

    struct Position
    {
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }
}
