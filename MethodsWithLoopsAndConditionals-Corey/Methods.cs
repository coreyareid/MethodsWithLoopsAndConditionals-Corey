using System;
namespace MethodsWithLoopsAndConditionals_Corey
{
   internal  class Methods
    {
        // Exercise 3
        //LukeWarm Section:

        // Method that counts from 1000 to -1000.

       public static void CountFromNegative()
        {
            for (int startingNum = 1000; startingNum > -1000; startingNum--)
            {
                Console.WriteLine($"{startingNum}");
            }
        }
      
       // Method that counts to 1000 by increments of 3.

       public static void AddByThree()
        {
            for (int num = 3; num < 1000; num += 3)
            {
                Console.WriteLine($"{num}");
            }
        }

        // Method that checks if two integers are equal or not.

       public static bool AreTheyEqual(int A, int B)
        {
            if (A == B)
            {
                Console.WriteLine(" Is true");
                return true;
            }
            else
            {
                Console.WriteLine(" Is false");
                return false;
            }
        }

        // Method that checks if a number is even or odd.

       public static void EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($" {number}, is even");
            }
            else
            {
                Console.WriteLine($"{number}, is odd");
            }
        }

        // Method that checks if a number is negative or positive

       public static bool NegPos(int num)
        {
            if (num < 0)
            {
                Console.WriteLine($"{num}, is negative");
                return true;
            }
            else
            {
                Console.WriteLine($"{num}, is positive");
                return false;
            }
        }

        //Method that is used to check if the user is of age to vote.

        public static void IsOfAge()
        {
            Console.WriteLine("Enter you age to verify eligibilty to vote.");
            int yourAge = Convert.ToInt32(Console.ReadLine());

            if (yourAge > 18)
            {
                Console.WriteLine($" You are {yourAge}, and eligible to vote.");
            }
            else
            {
                Console.WriteLine($" You are {yourAge}, and cannot vote.");
            }
        }


        //Heatin Up Section:

        //Method to check if user input is in range of -10 to 10.

       public static void IsInRange()
        {
            bool inRange = true;
            Console.WriteLine("Enter a number to check if it\'s in range.");

            do
            {
                int theirNumber = Convert.ToInt32(Console.ReadLine());

                if (theirNumber > -10 && theirNumber < 10)
                {
                    Console.WriteLine($" The number you chose is {theirNumber} and IS in range.");
                    inRange = false;
                }
                else
                {
                    Console.WriteLine($" The number you chose is {theirNumber} and is NOT in range, try again.");
                }
            }
            while (inRange);
        }


        // Method that shows multiplication table when a number is put in by the user.

       public static void Table()
        {
            int x, y;
            Console.WriteLine("Input a number to see its multiplication table.");
            x = Convert.ToInt32(Console.ReadLine());

            for (y = 1; y <= 12; y++)
            {
                Console.WriteLine($" {x} x {y} = {x * y}");
            }

        }
    }
}

