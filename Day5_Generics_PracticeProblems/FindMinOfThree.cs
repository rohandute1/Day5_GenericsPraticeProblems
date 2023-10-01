using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Generics_PracticeProblems
{
    class FindMinOfThree<T> where T : IComparable
    {
        public T var1;
        public T var2;
        public T var3;

        public FindMinOfThree(T var1, T var2, T var3)
        {
            this.var1 = var1;
            this.var2 = var2;
            this.var3 = var3;
        }

        public T FindMin()
        {
            return Minimum(var1, var2, var3);
        }

        public static T Minimum(T a, T b, T c)
        {
            if (a.CompareTo(b) <= 0)
            {
                if (a.CompareTo(c) <= 0)
                {
                    return a;
                }
                else
                {
                    return c;
                }
            }
            else
            {
                if (b.CompareTo(c) <= 0)
                {
                    return b;
                }
                else
                {
                    return c;
                }
            }
        }

        public void TestMinimum()
        {
            T min = Minimum(var1, var2, var3);
            Console.WriteLine("The minimum is: " + min);
        }
    }
}
