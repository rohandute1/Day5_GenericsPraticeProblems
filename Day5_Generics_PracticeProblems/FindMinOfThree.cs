using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Generics_PracticeProblems
{
    class FindMinOfThree
    {
        public int FindMin(int num1, int num2, int num3)
        {
            if (num1.CompareTo(num2) <= 0)
            {
                if (num1.CompareTo(num3) <= 0)
                {
                    return num1;
                }
                else
                {
                    return num3;
                }
            }
            else
            {
                if (num2.CompareTo(num3) <= 0)
                {
                    return num2;
                }
                else
                {
                    return num3;
                }
            }
        }
        public float FindMin(float num1, float num2, float num3)
        {
            if (num1.CompareTo(num2) <= 0)
            {
                if (num1.CompareTo(num3) <= 0)
                {
                    return num1;
                }
                else
                {
                    return num3;
                }
            }
            else
            {
                if (num2.CompareTo(num3) <= 0)
                {
                    return num2;
                }
                else
                {
                    return num3;
                }
            }
        }

        public string FindMin(string str1, string str2, string str3)
        {
            if (str1.CompareTo(str2) <= 0)
            {
                if (str1.CompareTo(str3) <= 0)
                {
                    return str1;
                }
                else
                {
                    return str3;
                }
            }
            else
            {
                if (str2.CompareTo(str3) <= 0)
                {
                    return str2;
                }
                else
                {
                    return str3;
                }
            }
        }

    }
}
