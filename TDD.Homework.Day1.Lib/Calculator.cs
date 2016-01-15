using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Homework.Day1.Lib
{
    public class Calculator
    {
        public static ICollection<int> CalNumber(ICollection<int> nums, int groupNumbers)
        {
            List<int> result = new List<int>();
            List<int> numslist = nums.ToList<int>();
            int sum = 0;

            for (int i = 0; i < numslist.Count; i++)
            {
                sum += numslist[i];
                if ((i + 1) % groupNumbers == 0 || (i + 1) == numslist.Count<int>())
                {
                    result.Add(sum);
                    sum = 0;
                }
            }

            return result;
        }
    }
}
