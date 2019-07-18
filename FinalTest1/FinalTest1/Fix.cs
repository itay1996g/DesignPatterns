using System;

namespace FinalTest1
{
    public class Fix : IGameState
    {
        public IGameState Hitted(int hitsCount)
        {
            if (hitsCount < 10)
            {
                return new Danger();
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