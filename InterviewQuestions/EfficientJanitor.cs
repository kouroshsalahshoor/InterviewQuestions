using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    internal static class EfficientJanitor
    {
        public static void Run()
        {
            double[] bags = { 1.01, 1.99, 2.5, 1.5, 1.01, 1.01 };
            double maxWeight = 3.0;
            Console.WriteLine("EfficientJanitor - Nbr of trips: " + GetTrips(bags, maxWeight)); // Output: 4
        }
        public static int GetTrips(double[] bags, double maxWeight)
        {
            Array.Sort(bags);
            int left = 0, right = bags.Length - 1;
            int trips = 0;

            while (left <= right)
            {
                if (left == right)
                {
                    trips++;
                    break;
                }
                if (bags[left] + bags[right] <= maxWeight)
                {
                    left++;
                }
                right--;
                trips++;
            }

            return trips;
        }
    }
}
