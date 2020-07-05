using System;

namespace Unit7ProjectCsharpLowe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize variables
            double temp1 = 35.5;
            double temp2 = 30.5;
            double temp3 = 22.2;
            double temp4 = 16.1;
            double temp5 = 7.3;
            double temp6 = -1;
            int tempF = 0;

            string advisory = " ";

            //Processing & Display Results
            Console.WriteLine("Assignment 7 -- Functions and Type Conversions\n\n");
            tempF = fahrenheit(temp1);
            advisory = weatherStatement(tempF);
            Console.Write("The temperature is " + temp1 + "C or " + tempF + "F." + advisory + "\n");

            tempF = fahrenheit(temp2);
            advisory = weatherStatement(tempF);
            Console.Write("The temperature is " + temp2 + "C or " + tempF + "F." + advisory + "\n");

            tempF = fahrenheit(temp3);
            advisory = weatherStatement(tempF);
            Console.Write("The temperature is " + temp3 + "C or " + tempF + "F." + advisory + "\n");

            tempF = fahrenheit(temp4);
            advisory = weatherStatement(tempF);
            Console.Write("The temperature is " + temp4 + "C or " + tempF + "F." + advisory + "\n");

            tempF = fahrenheit(temp5);
            advisory = weatherStatement(tempF);
            Console.Write("The temperature is " + temp5 + "C or " + tempF + "F." + advisory + "\n");

            tempF = fahrenheit(temp6);
            advisory = weatherStatement(tempF);
            Console.Write("The temperature is " + temp6 + "C or " + tempF + "F." + advisory + "\n");

            Console.Read();
        }

        //FUnction to convert Celsuis to Fehrenheit
        public static int fahrenheit(double myTemp)
        {
            int intTemp = (int)(myTemp * 9.0 / 5.0 + 32 + .5);
            return intTemp;
        }

        //Function to provide the weather advisory
        public static string weatherStatement(int tempF)
        {
            if (tempF >=95)
            {
                return "A heat advisory has been issued";
            }
            else if (tempF >=85)
            {
                return "Pleasant but warm";
            }
            else if (tempF >=70)
            {
                return "Very pleasant weather today";
            }
            else if (tempF >=50)
            {
                return "Pleasant but cool";
            }
            else if (tempF >=33)
            {
                return "Cold weather";
            }
            else
            {
                return "A freeze warning has been issued";
            }
        }
    }
}
