using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

    public class DiceRoller
    {
        private Random random = new Random();

        public int[] RollDice(int numberOfRolls)
        {
            int[] counts = new int[11];

            for (int i = 0; i < numberOfRolls; i++)
            {
                int roll1 = random.Next(1, 7);
                int roll2 = random.Next(1, 7);
                int sum = roll1 + roll2;

                counts[sum - 2]++;
            }

            return counts;
        }

        public int[] calculatePercentages(int[] counts ,int totalRolls) 
        { 
            int[] percentages = new int[counts.Length];
            

            for (int i = 0;  i < counts.Length; i++) 
            {
                percentages[i] = (int)(((double)counts[i] / totalRolls) * 100);
            }

            return percentages;
        }
    }
