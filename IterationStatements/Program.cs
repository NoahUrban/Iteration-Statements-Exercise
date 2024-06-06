namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below

        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintThroughOneThousand()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void IncrementByThree()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static string IntegerCheck(int num1, int num2)
        {
            var equalCheck = (num1 == num2) ? "Both numbers are equal" : $"{num1} and {num2} Not Equal";

            Console.WriteLine(equalCheck);
            return equalCheck;
        }

        //Write a method to check whether a given number is even or odd
        public static string EvenOrOdd(int num1)
        {
            var evenOddCheck = (num1 % 2 == 0) ? $"{num1} is an Even Number" : $"{num1} is an Odd Number";

            Console.WriteLine(evenOddCheck);
            return evenOddCheck;
        }

        //Write a method to check whether a given number is positive or negative
        public static string PositiveOrNegative(int num1)
        {
            var positiveCheck = (num1 > 0) ? $"{num1} is positive" : $"{num1} is negative";

            Console.WriteLine(positiveCheck);
            return positiveCheck;
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static string AgeCheck()
        {
            Console.WriteLine("Please enter your age");

            int age = int.Parse(Console.ReadLine());

            var votingCheck = (age >= 18) ? "You are old enough to vote" : "You are too young to vote";

            Console.WriteLine(votingCheck);
            return votingCheck;
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static string RangeCheck()
        {
            Console.WriteLine("Enter any number...");

            int userInput = int.Parse(Console.ReadLine());

            var inputCheck = (userInput >= -10 && userInput <= 10) ? $"{userInput} is between -10 and 10" : $"{userInput} is outside the range of -10 to 10";

            Console.WriteLine(inputCheck);
            return inputCheck;
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultTable()
        {

            for (int i = 1; i <= 12; i++)
            {
                for (int j = 1; j <= 12; j++)
                {
                    if (i > 0) Console.Write(i * j + "\t");
                    else Console.Write(j + "\t");
                }
                Console.Write(" \n");
            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            
        }
    }
}
