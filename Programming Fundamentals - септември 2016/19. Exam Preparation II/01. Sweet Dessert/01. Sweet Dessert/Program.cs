using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal userCash = decimal.Parse(Console.ReadLine());
            int guestNumber = int.Parse(Console.ReadLine());
            decimal priceBan = decimal.Parse(Console.ReadLine());
            decimal priceEgg = decimal.Parse(Console.ReadLine());
            decimal priceBer = decimal.Parse(Console.ReadLine());
            int portionsNeeded = 0;

            if (guestNumber % 6 == 0)
            {
                portionsNeeded = (guestNumber / 6);
            }
            else
            {
                int firstNumber = guestNumber / 6;
                portionsNeeded = (firstNumber * 6 + 6) / 6;
            }

            decimal sum = portionsNeeded * (2 * priceBan) + portionsNeeded * (4 * priceEgg) + portionsNeeded * (0.2m * priceBer);

            if (sum <= userCash)
            {
                
                Console.WriteLine("Ivancho has enough money - it would cost {0:F2}lv.", sum);
            }
            else
            {
                decimal razlika = sum - userCash;
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:F2}lv more.", razlika);
            }
        }
    }
}
