using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Dice Throwing Simulator! ");


        int numberOfRolls;

        do
        {
            Console.Write("How many Dice rolls would you like to simulate? ");
        }
        while (!int.TryParse(Console.ReadLine(), out numberOfRolls) || numberOfRolls <= 0);

        DiceRoller diceRoller = new DiceRoller();

        int[] counts = diceRoller.RollDice(numberOfRolls);
        int[] percentages = diceRoller.calculatePercentages(counts, numberOfRolls);

        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \" * \" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total Number of rolls = {numberOfRolls}.");

        for (int i = 0; i < percentages.Length; i++)
        {
            Console.Write($"{i + 2}: ");
            Console.WriteLine(new string('*', percentages[i]));
        }

        Console.WriteLine("Thank you for using the Dice Throwing Simulator. Goodbye! ");
    }
}