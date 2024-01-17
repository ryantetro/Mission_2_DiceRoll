using System;
internal class Program
{
    static void Main(string[] args)
    {
        // Greeting message to the user 
        Console.WriteLine("Welcome to the Dice Throwing Simulator! ");


        int numberOfRolls;

        // Prompt the user for the number of dice rolls and validate the input
        do
        {
            Console.Write("How many Dice rolls would you like to simulate? ");
        }
        while (!int.TryParse(Console.ReadLine(), out numberOfRolls) || numberOfRolls <= 0);

        // initiate the DiceRoller Class
        DiceRoller diceRoller = new DiceRoller();

        // call the RollDice method and store the result
        int[] counts = diceRoller.RollDice(numberOfRolls);
        // Calculate the percentage for each dice sum
        int[] percentages = diceRoller.calculatePercentages(counts, numberOfRolls);

        // print the results header 
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \" * \" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total Number of rolls = {numberOfRolls}.");

        // loop to print of the histogram for each dice roll
        for (int i = 0; i < percentages.Length; i++)
        {
            Console.Write($"{i + 2}: ");
            Console.WriteLine(new string('*', percentages[i]));
        }

        // Closing message
        Console.WriteLine("Thank you for using the Dice Throwing Simulator. Goodbye! ");
    }
}