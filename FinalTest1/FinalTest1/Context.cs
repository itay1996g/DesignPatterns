using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest1
{
    public class Context
    {
        IGameState state;
        public int level = 1;
        int hitsCount = 50;

        public Context(IGameState state)
        {
            this.state = state;
        }

        public void hitted()
        {
            hitsCount--;
            state = state.Hitted(hitsCount);
        }

        public void levelUp()
        {
            level++;
            state = state.LevelUp(level);
        }

        public override string ToString()
        {
            return $"state: {state.GetType().ToString()}, level: {level}. hitsCount: {hitsCount}";
        }
    }
}