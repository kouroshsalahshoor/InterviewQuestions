using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    internal class CombinationSum
    {
        public static void Run()
        {
            Console.WriteLine("Problem Statement\r\nGiven an array of distinct integers candidates and a target integer target, return all unique combinations of candidates where the chosen numbers sum to target. The same number may be chosen from candidates an unlimited number of times.");
            int[] candidates = { 2, 3, 6, 7 };
            int target = 7;
            var result = CombSum(candidates, target);

            foreach (var combination in result)
            {
                Console.WriteLine($"[{string.Join(", ", combination)}]");
            }
        }
        public static IList<IList<int>> CombSum(int[] candidates, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Array.Sort(candidates);
            Backtrack(result, new List<int>(), candidates, target, 0);
            return result;
        }

        private static void Backtrack(IList<IList<int>> result, List<int> tempList, int[] candidates, int remain, int start)
        {
            if (remain < 0)
            {
                return; // if remaining target is negative, stop
            }
            else if (remain == 0)
            {
                result.Add(new List<int>(tempList)); // found a combination
            }
            else
            {
                for (int i = start; i < candidates.Length; i++)
                {
                    tempList.Add(candidates[i]); // choose the candidate
                    Backtrack(result, tempList, candidates, remain - candidates[i], i); // not i + 1 because we can reuse the same element
                    tempList.RemoveAt(tempList.Count - 1); // un-choose the candidate
                }
            }
        }
    }
}
