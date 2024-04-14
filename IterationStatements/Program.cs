namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        private static void NumberCount()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        private static void CountByThrees()
        {
            for (int i = 3; i <= 999; i = i + 3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        private static void CheckEqual(int num1, int num2)
        {
            string equalCheck = (num1 == num2) ? $"Numbers are equal, {num1} = {num2}" : $"Numbers are not equal, {num1} != {num2}";
            Console.WriteLine(equalCheck);
        }

        //Write a method to check whether a given number is even or odd
        private static void OddOrEven(int num)
        {
            string oddEvenCheck = (num % 2 > 0) ? $"Number is odd: {num}" : $"Number is even: {num}";
            Console.WriteLine(oddEvenCheck);
        }

        //Write a method to check whether a given number is positive or negative
        private static void PosOrNeg(int num)
        {
            string posNegCheck = (num >= 0) ? $"Number is positive: {num}" : $"Number is negative: {num}";
            Console.WriteLine(posNegCheck);
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        private static void VoteAgeCheck(int num)
        {
            string age = (num >= 18) ? $"Yep, you can vote because you are {num} years old." : $"Nope, you cannot vote because you are only {num} years old.";
            Console.WriteLine(age);
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        private static void NumInRange(int num)
        {
            if (num >= -10 && num <= 10)
            {
                Console.WriteLine($"{num} is between -10 and 10");
            }
            else
            {
                Console.WriteLine($"{num} is NOT between -10 and 10");
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        private static void MultTable12(int num)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{num} * {i} = " + (num * i));
            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //NumberCount();
            //CountByThrees();
            //Console.WriteLine("Enter first number");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second number");
            //int num2 = int.Parse(Console.ReadLine());
            //CheckEqual(num1, num2);
            //Console.WriteLine("Enter number");
            //int num = int.Parse(Console.ReadLine());
            //OddOrEven(num);
            //PosOrNeg(age);
            //Console.WriteLine("Enter your age");
            //int result;
            //string age = Console.ReadLine();
            //bool success = int.TryParse(age, out result);
            //if (success)
            //{
            //    VoteAgeCheck(result);
            //}
            //else
            //{
            //    Console.WriteLine("sorry, an error occurred");
            //}
            //Console.WriteLine("enter a number");
            //int num = int.Parse(Console.ReadLine());
            //NumInRange(num);
            Console.WriteLine("enter a number and I will show you a multiplication table through 12");
            int num = int.Parse(Console.ReadLine());
            MultTable12(num);
        }

    }
}
