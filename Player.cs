using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeorgiaDavid_Interfaces
{
    class Player
    {
        Position _playerPosition;
        ConsoleColor _color;

        public Player(Position playerPosition, ConsoleColor color)
        {
            _playerPosition = playerPosition;
            _color = color;
        }
    }
}
