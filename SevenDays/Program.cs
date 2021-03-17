using System;

namespace ConsequtiveNumbers
{
    class Program
    {
        // https://edabit.com/challenge/TAZywz6R2hu9tDQWc
        // SOLVED
        // Awful performance wise - need to implement paralell looping

        static void Main(string[] args)
        {
            var x = new ConsequtiveCalc(new int[] { 5, 4, 3, 2, 1 });
            x.SortArray();
            x.CreateMockList();
            x.IsConsequtive();
        }
    }
}
