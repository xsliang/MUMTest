using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUMTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCode a = new TestCode();
            a.f1(new int[] { 1, 2, 3, 4 });
            a.f1(new int[] { 4, 1, 2, 3 });
            a.f1(new int[] { 1, 1, 2, 2 });
            a.f1(new int[] { 1, 1 });
            a.f1(new int[] { 1 });
            a.f1(new int[] { });

            a.f2(new int[] { 1 });
            a.f2(new int[] { 1, 2 });
            a.f2(new int[] { 1, 2, 3 });
            a.f2(new int[] { 1, 2, 3, 4 });
            a.f2(new int[] { 3, 3, 4, 4 });
            a.f2(new int[] { 3, 2, 3, 4 });
            a.f2(new int[] { 4, 1, 2, 3 });
            a.f2(new int[] { 1, 1 });
            a.f2(new int[] { });

            a.f3(new char[] { 'a', 'b', 'c' }, 0, 4);
            a.f3(new char[] { 'a', 'b', 'c' }, 0, 3);
            a.f3(new char[] { 'a', 'b', 'c' }, 0, 2);
            a.f3(new char[] { 'a', 'b', 'c' }, 0, 1);
            a.f3(new char[] { 'a', 'b', 'c' }, 1, 3);
            a.f3(new char[] { 'a', 'b', 'c' }, 1, 2);
            a.f3(new char[] { 'a', 'b', 'c' }, 1, 1);
            a.f3(new char[] { 'a', 'b', 'c' }, 2, 2);
            a.f3(new char[] { 'a', 'b', 'c' }, 2, 1);
            a.f3(new char[] { 'a', 'b', 'c' }, 3, 1);
            a.f3(new char[] { 'a', 'b', 'c' }, 1, 0);
            a.f3(new char[] { 'a', 'b', 'c' }, -1, 2);
            a.f3(new char[] { 'a', 'b', 'c' }, -1, -2);
            a.f3(new char[] { }, 0, 1);
        }
    }
}
