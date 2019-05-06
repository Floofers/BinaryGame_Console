using System;

namespace BinaryGame
{
    class Game
    {
        /// <summary>
        /// Generates random numbers for the player to change to binary
        /// </summary>
        static Random rnd = new Random();
        /// <summary>
        /// How many bits the generated number should have
        /// </summary>
        const int bits = 4;

        static void Main(string[] args)
        {
            // Calculate the largest possible number to generate
            int maxSize = (int) Math.Pow(2,bits);

            do
            {
                // Clear the console
                Console.Clear();

                // Generate the number to change to binary
                int number = rnd.Next(maxSize);

                // Get the number in binary
                string binaryString = Convert.ToString(number, 2);

                // Pad the number so it has all of the bits desired
                binaryString = binaryString.PadLeft(bits, '0');
                
                // Get the user input
                Console.WriteLine("Write " + number.ToString() + $" in binary. (Format: {string.Empty.PadLeft(bits, '0')}");
                string input = Console.ReadLine();

                // Show the user the result
                Console.WriteLine();
                if (input.Equals(binaryString))
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Wrong. The correct answer is:\n" + binaryString);
                }

                // Temporary exit option
                Console.WriteLine("\nEnter \"stop\" to stop.");
            }
            while (!Console.ReadLine().ToUpper().Contains("STOP"));
        }
    }
}
