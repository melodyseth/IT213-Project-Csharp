using System;

namespace Unit3ProjectLoweCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment 3 --- Section1
            //Initialize Variable
            int total;
            int gradeCounter;
            int grade;
            int average;
            total = 0;
            gradeCounter = 1;

            Console.WriteLine("***** Assignment 3: Section 1 -- While loops ***\n");

            //Processing and Display Results
            while (gradeCounter <= 10)
            {
                Console.WriteLine("Enter grade for number " + gradeCounter + " of the 10 grades to be entered: ");
                grade = Convert.ToInt32(Console.ReadLine());
                total = total + grade;
                gradeCounter = gradeCounter + 1;
            }
            average = total / 10;

            Console.WriteLine("\nTotal of all grades is {0}", total);
            Console.WriteLine("Class Average is " + average);

            //Assignment 3 --- Section 2
            Console.WriteLine("\n\n****** Assignment 3: Section 2 -- nested loops ***\n");
            for (int k = 5; k >= 1; k--)
            {
                for (int i = 0; i <= 10; i += 2)
                {
                    Console.WriteLine("k = {0} i = {1}", k, i);
                }
            }

            //Assignment 3 --- Section 3
            Console.WriteLine("\n\n****** Assignment 3: Section 3 -- While loop with Sentinel ***\n");
            int number = 0;
            int totalNumbers = 0;
            int counter = 1;

            while (number != -1)
            {
                Console.WriteLine("Enter a positive number for number " + counter + " to be added to the total or -1 to end");
                number = Convert.ToInt32(Console.ReadLine());
                if ( number != -1)
                {
                    totalNumbers = totalNumbers + number;
                    counter++;
                }
            }
            counter = counter - 1;
            Console.WriteLine("You entered " + counter + " numbers and the sum of all of the numbers entered is " + totalNumbers);
            Console.ReadLine();
        }
    }
}
