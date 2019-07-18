using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest1
{
    public class GameOverLose : IGameState
    {
        public IGameState Hitted(int hitsCount)
        {
            return this;
        }

        public IGameState LevelUp(int level)
        {
            return this;
        }
    }
}