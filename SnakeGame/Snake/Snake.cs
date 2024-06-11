using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnakeGame;
using SnakeGame;

namespace SnakeGame.Snake
{
    public class Snake
    {
        Queue<(int, int)> snake { get; set; }
        Direction? direction { get; set; }

        public Snake()
        {
            Queue<(int, int)> snake = new Queue<(int, int)>();
            direction = null;
        }

    }
}
