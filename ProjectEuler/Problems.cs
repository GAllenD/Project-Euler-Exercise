using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    public class Problems
    {
        public object SolveProblem1()
        {
            const int number = 1000;
            var sum = 0;

            for (var i = 0; i < number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        public object SolveProblem2()
        {
            const int max = 4000000;
            var fibonacciNumbers = GetFibonacciNumber(max);

            return fibonacciNumbers.Where(number => number%2 == 0).Sum();
        }

        private List<int> GetFibonacciNumber(int max)
        {
            var startVal = 0;
            var endVal = 1;
            var result = new List<int>{0};
            var maxReached = false;

            while (!maxReached)
            {
                var newFib = startVal + endVal;
                startVal = endVal;
                endVal = newFib;
                if (newFib >= max)
                    maxReached = true;
                else
                    result.Add(newFib);
            }

            return result;
        }
    }
}
