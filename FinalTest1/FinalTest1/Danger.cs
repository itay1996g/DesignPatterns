using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest1
{
    public class Danger : IGameState
    {
        public IGameState Hitted(int hitsCount)
        {
            if (hitsCount == 0)
            {
                return new GameOverLose();
            }
            return this;
        }

        public IGameState LevelUp(int level)
        {
            if (level == 4)
            {
                return new GameOverWin();
            }
            else
            {
                return this;
            }
        }
    }
}
