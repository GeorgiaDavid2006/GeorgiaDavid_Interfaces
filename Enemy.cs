using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GeorgiaDavid_Interfaces
{
    class Enemy : IMoveStrategy
    {
        Position _enemyPosition;
        ConsoleColor _color;

        public IMoveStrategy _moveStrategy;

        public Enemy(Position enemyPosition, ConsoleColor color)
        {
            _enemyPosition = enemyPosition;
            _color = color;
        }

        public void PositionMove(Position position)
        {
            Console.SetCursorPosition(position.X, position.Y);
            Console.WriteLine("X");
        }
    }

    interface IMoveStrategy
    {
        void PositionMove(Position position);
    }

    class AggresiveMoveStrategy : IMoveStrategy
    {
        void IMoveStrategy.PositionMove(Position position)
        {
            Console.SetCursorPosition(position.X + 1, position.Y);
            Console.WriteLine("X");
        }
    }

    class PassiveMoveStrategy : IMoveStrategy
    {
        void IMoveStrategy.PositionMove(Position position)
        {
            Console.SetCursorPosition(position.X - 1, position.Y);
            Console.WriteLine("X");
        }
    }

    class RandomMoveStrategy : IMoveStrategy
    {
        void IMoveStrategy.PositionMove(Position position)
        {
            Random random = new Random();
            int randomInt = random.Next(10);

            Console.SetCursorPosition(position.X + randomInt, position.Y + randomInt);
            Console.WriteLine("X");
        }
    }
}
