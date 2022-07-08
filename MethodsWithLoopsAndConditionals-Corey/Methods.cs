using System;
namespace MethodsWithLoopsAndConditionals_Corey
{
   internal  class Methods
    {

        // Exercise 1
        public static void WriteForLoops()
        {
            // 1st time
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}");
            }

            // 2nd time
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine($"{i}");
            }

            // 3rd time
            for (int i = 100; i > 0; i--)
            {
                Console.WriteLine($"{i}");
            }

            //4th time
            for (int g = 1; g < 10; g++)
            {
                Console.WriteLine($"{g}");
            }

            // 5th time
            for (int x = 0; x < 100; x++)
            {
                Console.WriteLine($"{x}");
            }

            // 6th time
            for (int x = 100; x > 0; x--)
            {
                Console.WriteLine($"{x}");
            }

            // 7th time
            for (int num = 5; num < 25; num++)
            {
                Console.WriteLine($"{num}");
            }

            // 8th time
            for (int corey = 30; corey < 70; corey++)
            {
                Console.WriteLine($"{corey}");
            }

            // 9th time
            for (int subtract = 50; subtract > 0; subtract--)
            {
                Console.WriteLine($"{subtract}");
            }

            // 10 time
            for (int add = 0; add < 50; add++)
            {
                Console.WriteLine($"{add}");
            }

            // 11th time
            for (int satan = 10; satan < 20; satan++)
            {
                Console.WriteLine($"{satan}");
            }

            // 12th time
            for (int y = 20; y > 10; y--)
            {
                Console.WriteLine($"{y}");
            }

            // 13th time
            for (int dog = 7; dog < 30; dog++)
            {
                Console.WriteLine($"{dog}");
            }

            // 14th time
            for (int gotTheHangOfThis = 0; gotTheHangOfThis < 5; gotTheHangOfThis++)
            {
                Console.WriteLine($"{gotTheHangOfThis}");
            }

            // 15th and final time
            for (int finished = 10; finished > 0; finished--)
            {
                Console.WriteLine($"{finished}, and I\'m finally finished");
            }
        }


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

            while(inRange)
            {
                int theirNumber = Convert.ToInt32(Console.ReadLine());

                if (theirNumber > -10 && theirNumber < 10)
                {
                    Console.WriteLine($" The number you chose is {theirNumber} and IS in range.");
                    inRange = false;
                    break;
                }
                else
                {
                    Console.WriteLine($" The number you chose is {theirNumber} and is NOT in range, try again.");
                }
            }
            
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

        //Challange myself section.
        // Method to enter password.

        public static void InputPassword()
        {
            string userName = "Corey Reid";
            string password = "Coreyislearning";
            bool correct = false;
            string userInput = "";

            Console.WriteLine("Please enter your password");
            
            while (userInput != password)
            {
                 userInput = Console.ReadLine();

                if (userInput == password)
                {
                    Console.WriteLine($"Welcome {userName}");
                    correct = true;
                    break;
                } else
                {
                    Console.WriteLine("The password is not correct. Try again.");
                }

            }

        }

        //Method to Guess a large number
        public static void LargeNumbersGuess()
        {
            // var x = new Random();
            // var myNumber = x.Next(1, 1000);
            int myNumber = 777;
          
            bool numberChosen = false;
            int userInput = 0;
            Console.WriteLine("Guess what my number is from 1 to 1000");

            while (userInput != myNumber)
            {
                userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == myNumber)
                {
                    Console.WriteLine("You guessed my number correctly!");
                    numberChosen = true;
                    break;
                }
                else if (userInput > myNumber)
                {
                    Console.WriteLine("Too high, try again!");
                }
                else if (userInput < myNumber)
                {
                    Console.WriteLine("Too low, try again!");
                }
            }

        }
        
    }
}

