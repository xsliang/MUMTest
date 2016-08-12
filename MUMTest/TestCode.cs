using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMTest
{
    public class TestCode
    {

        //1. Write a function that accepts an array of non-negative integers and returns the second largest integer in the array.Return -1 if there is no second largest.
        //The signature of the function is
        //int f(int[] a)
        //Examples:
        //if the input array is 	return
        //{1, 2, 3, 4} 	3
        //{{4, 1, 2, 3}} 	3
        //{1, 1, 2, 2} 	1
        //{1, 1} 	-1
        //{1} 	-1
        //{} 	-1
        public int f1(int[] a)
        {
            if (a.Length < 2)
            {
                return -1;
            }
            else
            {
                int first = a[0];
                int second = a[1];
                for (int i = 2; i < a.Length; i++)
                {
                    int temp = a[i];
                    if (temp == first || temp == second)
                    {
                        continue;
                    }
                    if (first >= second)
                    {
                        if (second < temp)
                        {
                            second = temp;
                        }
                    }
                    else
                    {
                        if (first < temp)
                        {
                            first = temp;
                        }
                    }
                }

                if (first == second)
                {
                    return -1;
                }
                return first > second ? second : first;
            }
        }

        //2. Write a function that takes an array of integers as an argument and returns a value based on the sums of the even and odd numbers in the array.Let X = the sum of the odd numbers in the array and let Y = the sum of the even numbers.The function should return X - Y

        //The signature of the function is:
        //int f(int[] a)
        //Examples
        //if input array is 	return
        //{1} 	1
        //{1, 2} 	-1
        //{1, 2, 3} 	2
        //{1, 2, 3, 4} 	-2
        //{3, 3, 4, 4} 	-2
        //{3, 2, 3, 4} 	0
        //{4, 1, 2, 3} 	-2
        //{1, 1} 	2
        //{} 	0
        public int f2(int[] a)
        {
            int x = 0;
            int y = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    y = y + a[i];
                }
                else
                {
                    x = x + a[i];
                }
            }

            return x - y;
        }

        //3. Write a function that accepts a character array, a zero-based start position and a length.It should return a character array containing containing length characters starting with the start character of the input array. The function should do error checking on the start position and the length and return null if the either value is not legal.
        //The function signature is:
        //char[] f(char[] a, int start, int len)
        //Examples
        //if input parameters are 	return
        //{'a', 'b', 'c'}, 0, 4 	null
        //{'a', 'b', 'c'}, 0, 3 	{'a', 'b', 'c'}
        //{'a', 'b', 'c'}, 0, 2 	{'a', 'b'}
        //{'a', 'b', 'c'}, 0, 1 	{'a'}
        //{'a', 'b', 'c'}, 1, 3 	null
        //{'a', 'b', 'c'}, 1, 2 	{'b', 'c'}
        //{'a', 'b', 'c'}, 1, 1 	{'b'}
        //{'a', 'b', 'c'}, 2, 2 	null
        //{'a', 'b', 'c'}, 2, 1 	{'c'}
        //{'a', 'b', 'c'}, 3, 1 	null
        //{'a', 'b', 'c'}, 1, 0 	{}
        //{'a', 'b', 'c'}, -1, 2 	null
        //{'a', 'b', 'c'}, -1, -2 	null
        //{}, 0, 1 	null
        public char[] f3(char[] a, int start, int len)
        {
            if (start < 0 || len < 0)
            {
                return null;
            }

            char[] temp = new char[len];
            int j = 0;
            for (int i = start; i < len + start; i++)
            {
                if (i >= a.Length)
                {
                    return null;
                }
                else
                {
                    temp[j] = a[i];
                    j++;
                }
            }

            return temp;
        }
    }
}
