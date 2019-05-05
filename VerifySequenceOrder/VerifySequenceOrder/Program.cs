using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerifySequenceOrder
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public bool launchSequenceChecker(string[] systemNames, int[] stepNumbers)
        {
            List<int> nums = new List<int>();
            List<string> names = new List<string>();
            
            for (int i = 0; i < systemNames.Length; i++)
            {
                names.Add(systemNames[i]);

                for (int j = 0; j < stepNumbers.Length; j++)
                {
                    if (names.Contains(systemNames[i]))
                    {                        
                        nums.Add(stepNumbers[j]);
                    }
                }
            }



            return false;
        }

    }
}
