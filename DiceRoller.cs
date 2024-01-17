using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

    public class DiceRoller
    {
        // Random Number generator to simulate the dice rolls
        private Random random = new Random();

        // Method to simulate the rolling of two 6-sided dice
        public int[] RollDice(int numberOfRolls)
        {
            // array to store the count of each possible sum 
            int[] counts = new int[11];

            // for loop for the number of times the dice is to be rolled
            for (int i = 0; i < numberOfRolls; i++)
            {
                // generate two random numbers for the dice 
                int roll1 = random.Next(1, 7);
                int roll2 = random.Next(1, 7);
                int sum = roll1 + roll2;

                // calculate the sum of the two dice rolls
                counts[sum - 2]++;
            }
            // return the array of counts 
            return counts;
        }

        // Method to create the percentage of each sum 
        public int[] calculatePercentages(int[] counts ,int totalRolls) 
        { 
            // array to store the percentage of each sum 
            int[] percentages = new int[counts.Length];
            
            // loop through the counts array 
            for (int i = 0;  i < counts.Length; i++) 
            {
                // calculate the percentage and then round to the nearest integer 
                percentages[i] = (int)(((double)counts[i] / totalRolls) * 100);
            }
            // return the array of percentages 
            return percentages;
        }
    }
