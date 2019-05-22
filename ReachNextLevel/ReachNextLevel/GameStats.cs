using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReachNextLevel
{
    public class GameStats
    {
        private int _exp;
        private int _threshold;
        private int _reward;

        public int Exp { get => _exp; set => _exp = value; }
        public int Threshold { get => _threshold; set => _threshold = value; }
        public int Reward { get => _reward; set => _reward = value; }

        public GameStats(int xp, int toNextLevel, int reward)
        {
            this.Exp = xp;
            this.Threshold = toNextLevel;
            this.Reward = reward;
        }

        public bool ReachNextLevel(GameStats info)
        {
            if (this.Exp >= this.Threshold)
                return true;
            else
            {
                if (this.Exp + this.Reward >= this.Threshold)
                    return true;
            }
            return false;
        }
    }
}
