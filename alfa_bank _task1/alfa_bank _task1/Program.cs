using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace alfa_bank__task1
{
    class Program
    {
        public int bsearch(int[] massive, int X)
        {
            // Так как массив упорядоченный то поиск можно осуществить с помощью дихотомии за O(log(massive.Length)) операций 

            if (massive[massive.Length - 1] >= X)
                /* Если самый маленький элемент массива не меньше X, 
                то функция вернёт -1, это означает, что нет искомого элемента в данном массиве*/
                return -1;
            int firstIndex = 0;
            int lastIndex = massive.Length-1;
            int averageIndex = (firstIndex + lastIndex) / 2;
            while (lastIndex - firstIndex > 0)
            {              
                if (X > massive[averageIndex])
                {                   
                    if (averageIndex - 1 >= 0 && massive[averageIndex - 1] == X)
                        return averageIndex;
                    lastIndex = averageIndex;
                }
                else
                {
                    if (averageIndex + 1 < massive.Length && X == massive[averageIndex] && X > massive[averageIndex + 1])
                        return averageIndex + 1;
                    firstIndex = averageIndex + 1;
                }
                averageIndex = (firstIndex + lastIndex) / 2;
            }
            return averageIndex;
        }
        static void Main(string[] args)
        {
            int[] massive = {5, 4, 3, 2, 1};
            int X = 4;
            Console.WriteLine((new Program()).bsearch(massive, X));
            Console.ReadKey();
        }
    }
}
