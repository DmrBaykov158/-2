using System;

namespace Lib_1
{
    public static class Zad2
    {
        // Находит сумму чисел в массиве, больших 5
        public static int FindSumGreaterThan5(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                if (num > 5)
                {
                    sum += num;
                }
            }
            return sum;
        }
    }
}
