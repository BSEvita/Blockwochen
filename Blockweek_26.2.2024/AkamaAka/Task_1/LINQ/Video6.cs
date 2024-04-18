using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Video6
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 10, 12, 4, 15, 8 };
            var result = numbers;

            Console.WriteLine(result);

            var resultMax = numbers.Max();

            Console.WriteLine(resultMax);

            var resultMin = numbers.Min();

            Console.WriteLine(resultMin);


            var res = numbers.Where(number => number > 10).Min();

            Console.WriteLine(res);


            var resultAverse = numbers.Average();

            Console.WriteLine(resultAverse); ;

            var resultSum = numbers.Sum();
            Console.WriteLine(resultSum);

            var resultCount = numbers.Count();
            Console.WriteLine(resultCount);

            numbers = new int[] { 10,12,4,8};
            var res2 = numbers.Where(number => number > 10).Count();

            Console.WriteLine(res2);

            var resultAgg = numbers.Aggregate((sum, val) => sum + val);

            Console.WriteLine(resultAgg);

            string[] names = new string[] { "Johnson", "Claudia", "Sabrina", "Peter" };

            var res4 = names;
            Console.WriteLine(result);

            var resultCon = names.Aggregate((concat, name) => concat + ", " + name);

            Console.WriteLine(resultCon);


            Console.ReadLine();
        }
    }
}
