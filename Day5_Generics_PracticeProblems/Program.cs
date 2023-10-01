using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Generics_PracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics Problems.");
            Console.WriteLine("Please choose program to perform:");
            Console.WriteLine("1.Delete array element using generics or non generics\n2.Find Minimum of 3 integers\n" +
                "3.Find Minimum of 3 float values\n4.Find Minimum of 3 string values");
            int select = Convert.ToInt32(Console.ReadLine());

            switch (select)
            {
                case 1:

                    Console.WriteLine("Please select from Integer/Double/Char:");
                    Console.WriteLine("1.Integer Array\n2.Double Array\n3.Char Array");

                    int option = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the number of elements in the array:");
                    int n = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:

                            int[] intArray = new int[n];

                            Console.WriteLine("Enter the integer array:");
                            for (int i = 0; i < n; i++)
                            {
                                intArray[i] = int.Parse(Console.ReadLine());
                            }

                            Console.WriteLine("Enter the element to delete from integer array:");
                            int elementToDeleteInt = int.Parse(Console.ReadLine());
                            DeleteArray<int> intDeleteArray = new DeleteArray<int>();
                            int[] updatedIntArray = intDeleteArray.DeleteMethod(intArray, elementToDeleteInt);

                            Console.WriteLine("Updated Integer Array:");
                            foreach (var item in updatedIntArray)
                            {
                                Console.Write(item + " ");
                            }
                            break;

                        case 2:
                            double[] doubleArray = new double[n];
                            Console.WriteLine("Enter the double array:");
                            for (int i = 0; i < n; i++)
                            {
                                doubleArray[i] = double.Parse(Console.ReadLine());
                            }

                            Console.WriteLine("Enter the element to delete from double array:");
                            double elementToDeleteDouble = double.Parse(Console.ReadLine());
                            DeleteArray<double> doubleDeleteArray = new DeleteArray<double>();
                            double[] updatedDoubleArray = doubleDeleteArray.DeleteMethod(doubleArray, elementToDeleteDouble);

                            Console.WriteLine("\nUpdated Double Array:");
                            foreach (var item in updatedDoubleArray)
                            {
                                Console.Write(item + " ");
                            }
                            break;

                        case 3:
                            char[] charArray = new char[n];
                            Console.WriteLine("Enter the character array:");
                            for (int i = 0; i < n; i++)
                            {
                                charArray[i] = char.Parse(Console.ReadLine());
                            }

                            Console.WriteLine("Enter the element to delete from character array:");
                            char elementToDeleteChar = char.Parse(Console.ReadLine());
                            DeleteArray<char> charDeleteArray = new DeleteArray<char>();
                            char[] updatedCharArray = charDeleteArray.DeleteMethod(charArray, elementToDeleteChar);

                            Console.WriteLine("\nUpdated Character Array:");
                            foreach (var item in updatedCharArray)
                            {
                                Console.Write(item + " ");
                            }
                            break;
                    }
                    break;

                case 2:

                    Console.WriteLine("Enter three integers:");

                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    int num3 = int.Parse(Console.ReadLine());

                    FindMinOfThree minFinder = new FindMinOfThree();
                    int min = minFinder.FindMin(num1, num2, num3);

                    Console.WriteLine("The minimum number is: " + min);
                    break;

                case 3:
                    Console.WriteLine("Enter three floating-point numbers:");

                    float float1 = float.Parse(Console.ReadLine());
                    float float2 = float.Parse(Console.ReadLine());
                    float float3 = float.Parse(Console.ReadLine());

                    FindMinOfThree minFloatFinder = new FindMinOfThree();
                    float minF = minFloatFinder.FindMin(float1, float2, float3);

                    Console.WriteLine("The minimum number is: " + minF);
                    break;

                case 4:
                    Console.WriteLine("Enter three strings:");

                    string str1 = Console.ReadLine();
                    string str2 = Console.ReadLine();
                    string str3 = Console.ReadLine();

                    FindMinOfThree minStringFinder = new FindMinOfThree();
                    string minS = minStringFinder.FindMin(str1, str2, str3);

                    Console.WriteLine("The minimum string is: " + minS);
                    break;

            }
            Console.ReadLine();
        }
    }
}
