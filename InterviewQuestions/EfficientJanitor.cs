namespace InterviewQuestions
{
    internal static class EfficientJanitor
    {
//          The problem statement:
//         A janitor has to carry some bags of trash to the dumpster. Each bag has a specific weight, and the janitor can only carry up to a certain weight in one trip.
//         The goal is to determine the minimum number of trips required for the janitor to carry all the bags to the dumpster.

        public static void Run()
        {
            Console.WriteLine("The problem statement: A janitor has to carry some bags of trash to the dumpster. Each bag has a specific weight, and the janitor can only carry up to a certain weight in one trip. The goal is to determine the minimum number of trips required for the janitor to carry all the bags to the dumpster.");

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
