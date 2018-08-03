using System;

namespace UnitTest
{
    public class Class1 : IComparable<Class1>
    {
        public int val { get; set; }

        public Class1(int v)
        {
            val = v;
        }

        public int CompareTo(Class1 other)
        {
            if (val < other.val)
            {
                return -1;
            }
            else if (val > other.val)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
