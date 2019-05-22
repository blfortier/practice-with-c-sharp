using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReachNextLevel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the experience level? ");
            int experience = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the threshold? ");
            int nextLevel = Convert.ToInt32(Console.ReadLine());

            Console.Write("What's the reward for killing the monster? ");
            int reward = Convert.ToInt32(Console.ReadLine());

            GameStats info = new GameStats(experience, nextLevel, reward);

            string message = (info.ReachNextLevel(info)) ? "You will advance to the next level!" :
                                "You will not advance to the next level.";

            Console.WriteLine(message);
        }
    }
}
