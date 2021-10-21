using System;


namespace Playground
{

    class Program
    {

        public static void AValidNumber()
        {
            int userAns;


            try
            {
                Console.WriteLine("Please enter in a number between 1 to 10");
                userAns = Int32.Parse(Console.ReadLine());

                if (userAns >= 1 && userAns <= 10)
                {
                    Console.WriteLine("The number is valid");
                }
                else
                {
                    Console.WriteLine("You did not enter a valid number");
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Sorry but you did not enter in a digit number. Please try again");
            }


        }

        public static void MaxiumNumbers2Ints()
        {
            int userAn1;
            int userAn2;

            try
            {
                Console.WriteLine("Please enter in your first digit: ");
                userAn1 = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Please enter in your second digit: ");
                userAn2 = Int32.Parse(Console.ReadLine());

                if (userAn1 > userAn2)
                {
                    Console.WriteLine($" The maxium number of the two variables you selected is: {userAn1}");
                }
                else
                {
                    Console.WriteLine($"The maxium number of the two Variables are: {userAn2}");
                }

            }
            catch (Exception)
            {
                Console.WriteLine("You did not enter in a digit number");
            }
            
        }

        public static void HeightAndWidth()
        {
            double height;
            double width;

            try
            {
                Console.WriteLine("Please enter in the height of the photo in cm");
                height = Double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter in the width of the photo in cm");
                width = Double.Parse(Console.ReadLine());

                if (height > width)
                {
                    Console.WriteLine("The photo is a portrait");
                }
                else
                {
                    Console.WriteLine("The photo is landscrape");
                }

            }
            catch (Exception)
            {
                Console.WriteLine("You did not enter in numerical data");
            }
        }

        public static void SpeedLimitChecker()
        {

            const int ZERO = 0;      
            const int POINTADDEDFORUMULA = 5;
            const int LICENSESUSPENDED = 12;
            int legalLimit;
            int userInput;
            int overLimit;
            int ansForPoints;
            


            try
            {

                Console.WriteLine("What is the legal speeding limit in MPH?");
                legalLimit = Int32.Parse(Console.ReadLine());

                Console.WriteLine("What speed was the car going? ");
                userInput = Int32.Parse(Console.ReadLine());

                if (userInput < ZERO || legalLimit < ZERO)
                {
                    Console.WriteLine("Not a valid speeding limit \n");
                }
                else if (userInput < legalLimit)
                {
                    Console.WriteLine("Legally fine");
                }
                else if (userInput > legalLimit)
                {

                    overLimit = (userInput - legalLimit);
                    ansForPoints = (overLimit / POINTADDEDFORUMULA);

                    if (ansForPoints > LICENSESUSPENDED)
                    {
                        Console.WriteLine("SUSPEND USERS LICENCE");
                    }
                    else
                    {
                        Console.WriteLine($"The points awarded is: ***{ansForPoints}");
                    }






                }
            }
            catch (Exception)
            {
                Console.WriteLine("You did not enter a valid numerical speeding limit");
            }
            


        }

        static void Main(string[] args)
        {

            //Exercise 1
            AValidNumber();

            //Exercise 2
            MaxiumNumbers2Ints();

            //Exercise 3
            HeightAndWidth();

            //Exercise 4
            SpeedLimitChecker();





        }
    }
}
