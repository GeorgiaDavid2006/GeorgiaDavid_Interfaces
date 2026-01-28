using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeorgiaDavid_Interfaces
{
    class Enemy
    {
        Position _enemyPosition;
        ConsoleColor _color;

        public Enemy(Position enemyPosition, ConsoleColor color)
        {
            _enemyPosition = enemyPosition;
            _color = color;
        }
    }
}
