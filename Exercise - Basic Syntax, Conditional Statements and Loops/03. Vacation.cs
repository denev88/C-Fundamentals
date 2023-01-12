using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int people = int.Parse(Console.ReadLine());
            string group = Console.ReadLine();
            string weekDay = Console.ReadLine();
            double price = 0;


            if (group == "Students")
            {

                if (weekDay == "Friday")
                {
                    price = 8.45 * people;
                }
                else if (weekDay == "Saturday")
                {
                    price = 9.80 * people;
                }
                else if (weekDay == "Sunday")
                {
                    price = 10.46 * people;
                }


                if (people >= 30)
                {
                    price -= price * 15 / 100;

                }
            }
          else  if (group == "Business")
            {

                if (weekDay == "Friday")
                {
                    price = 10.90 * people;
                }
                else if (weekDay == "Saturday")
                {
                    price = 15.60 * people;
                }
                else if (weekDay == "Sunday")
                {
                    price = 16 * people;
                }



                if (people >= 100)
                {
                    price -= price / people * 10;

                }
            }
            else if (group == "Regular")
            {

                if (weekDay == "Friday")
                {
                    price = 15 * people;
                }
                else if (weekDay == "Saturday")
                {
                    price = 20 * people;
                }
                else if (weekDay == "Sunday")
                {
                    price = 22.50 * people;
                }

                if (people >= 10 && people <= 20)
                {
                    price -= price * 0.05;

                }

            }  
            Console.WriteLine($"Total price: {price:F2}");
        }
    }
}

