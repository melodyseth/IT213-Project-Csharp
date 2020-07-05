using System;

namespace Unit1ProjectCsharpMLowe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Unit 1 project C#
            //Initalize variables and get user information
            String name = "John Smith";
            String address = "101 N. Main Street";
            String city = "Anytown";
            String state = "TX";
            String zipcode = "11111";
            String unitsTaken = "19";
            const double pricePerUnit = 100.50;
            const double discount = 150;

            //Processing
            int intUnitsTaken = Convert.ToInt32(unitsTaken);
            intUnitsTaken++;

            double tuition = pricePerUnit * intUnitsTaken;
            double afterDiscount = tuition - discount;

            double monthlyPayment = afterDiscount / 12;

            //Display results
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("City: " + city);
            Console.WriteLine("State: " + state);
            Console.WriteLine("Zip code: " + zipcode);

            Console.WriteLine("The number of units taken is: " + intUnitsTaken);
            Console.WriteLine(string.Format("The tuition before discount is: {0:C}", tuition));
            Console.WriteLine(string.Format("The tuition after discount is: {0:C}", afterDiscount));
            Console.WriteLine(string.Format("Your monthly payment is: {0:C}", monthlyPayment));

            Console.Read(); 



        }
    }
}
