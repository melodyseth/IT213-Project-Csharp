using System;

namespace Unit8ProjectCSharpLowe_1_
    {
        class Program
        {
            static void Main(string[] args)
            {
                //Initialize Variables
                int[] numberArray = { 56, 77, 23, 12, 88, 59, 97, 33, 38, 64 };
                String[] stringArray = new String[10];

                //Processing

                int maxNumIndex = findMax(numberArray, numberArray.Length);
                evenOrOdd(numberArray, stringArray, numberArray.Length);

                //Display results
                Console.WriteLine("***** Assignment 8 -- Array *****\n\n");
                Console.WriteLine("The largest value in the array is " + numberArray[maxNumIndex] + " located at array index " + maxNumIndex);
                Console.WriteLine(" the numbers were:");
                for (int i = 0; i < numberArray.Length; i++)
                    Console.WriteLine(numberArray[i] + " is " + stringArray[i]);

                Console.Read();

            }

            //findMax Function
            public static int findMax(int[] numArray, int length)
            {
                int maxValue = numArray[0];
                int maxValuePosition = 0;

                for (int i = 0; i < length; i++)
                {
                    if (numArray[i] > maxValue)
                    {
                        maxValue = numArray[i];
                        maxValuePosition = i;
                    }
                }
                return maxValuePosition;
            }

            //Even Or Odd Function
            public static void evenOrOdd(int[] numArray, String[] strArray, int length)

            {
                for (int i = 0; i < length; i++)
                {
                    if (numArray[i] % 2 == 0)
                    {
                        strArray[i] = "even";
                    }
                    else
                    {
                        strArray[i] = "odd";
                    }
                }
            }
        }
    }
