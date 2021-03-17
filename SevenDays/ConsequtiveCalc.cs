using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsequtiveNumbers
{
    public class ConsequtiveCalc
    {
        private readonly int[] _conseqIntsA;
        private readonly List<int> tempList = new List<int>();

        public ConsequtiveCalc(int[] conseqInts)
        {
            _conseqIntsA = conseqInts;
        }

        public void SortArray()
        {
            Array.Sort(_conseqIntsA);
        }

        public void CreateMockList()
        {
            int x = _conseqIntsA[0];
            tempList.Add(x);
            int y = x - 1;
            foreach (var i in _conseqIntsA)
            {
                ++y;
                tempList.Add(y);
            }
            tempList.RemoveAt(1);
        }

        public void IsConsequtive()
        {
            if (Enumerable.SequenceEqual(tempList, _conseqIntsA)) Console.WriteLine("Yay");
            else Console.WriteLine("Nay");
        }
    }
}
