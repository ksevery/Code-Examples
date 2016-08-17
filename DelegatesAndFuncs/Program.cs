using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndFuncs
{
    public class Program
    {
        static void Main(string[] args)
        {
            var nums = new List<int>() { 20, 3, 44, 1, 2, 16, 5 };
            
            var numsLowerThan10 = GetNumsLowerThan(10, nums);

            Console.WriteLine(string.Join(", ", numsLowerThan10));
        }

        public static IEnumerable<int> GetNumsLowerThan(int lowerThan, IEnumerable<int> collection)
        {
            return collection.Where(num => num <= lowerThan);
        }
    }
}
