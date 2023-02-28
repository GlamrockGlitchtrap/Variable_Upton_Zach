 using System;

namespace Variable_Upton_Zach
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declares an integer to store a favorite number
            int favoriteNumber;
            // Booleans ininialized to false for jumping and running
            bool isJumpig = false, isRunning = false;
            // Declared random float variable
            float myFloat;
            // Assigning the favoriteNumber to 6
            favoriteNumber = 6;
            // Assigning myFloat to 54.65
            myFloat = 54.64f;
            // Initializing constant finalGrade to 90
            const double finalGrade = 90.0;

            // Prints all variables to console
            Console.WriteLine(favoriteNumber);
            Console.WriteLine(isJumpig);
            Console.WriteLine(isRunning);
            Console.WriteLine(myFloat);
            Console.WriteLine(finalGrade);
        }
    }
}
