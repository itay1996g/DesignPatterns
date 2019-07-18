using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest1
{
    public abstract class GameBase : IGameState
    {
        protected Context ctx;

        protected GameBase(Context ctx)
        {
            this.ctx = ctx;
        }

        public abstract void Game();

        public IGameState Hitted(int hitsCount)
        {
            throw new NotImplementedException();
        }

        public IGameState LevelUp(int level)
        {
            throw new NotImplementedException();
        }
    }

}