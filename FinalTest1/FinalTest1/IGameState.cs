using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest1
{
    public interface IGameState
    {
        IGameState Hitted(int hitsCount);

        IGameState LevelUp(int level);
    }
}