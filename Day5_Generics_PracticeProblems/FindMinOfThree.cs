using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Generics_PracticeProblems
{
    class FindMinOfThree <T> where T : IComparable<T>
    {
        public T FindMin(T Value1, T Value2, T Value3)
        {
            if (Value1.CompareTo(Value2) <= 0)
            {
                if (Value1.CompareTo(Value3) <= 0)
                {
                    return Value1;
                }
                else
                {
                    return Value3;
                }
            }
            else
            {
                if (Value2.CompareTo(Value3) <= 0)
                {
                    return Value2;
                }
                else
                {
                    return Value3;
                }
            }
        }
    }
}
