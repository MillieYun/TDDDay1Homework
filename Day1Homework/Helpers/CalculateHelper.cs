using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day1Homework.Helpers
{
    public class CalculateHelper
    {
        public List<int> SumByGroup(List<int> numberList, int groupCount)
        {
            var result = new List<int>();
            int countLoop = Convert.ToInt32(Math.Ceiling((decimal)numberList.Count() / groupCount));

            for (int i = 0; i < countLoop; i++)
            {
                result.Add(numberList.Skip(i * groupCount).Take(groupCount).Sum());
            }

            return result;
        }
    }
}