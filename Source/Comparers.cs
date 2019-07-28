﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatLists
{
    public class DoubleComparer : IComparer<double>
    {
        public int Compare(double a, double b)
        {
            return a.CompareTo(b);
        }
    }

    public class IntComparerer : IComparer<int>
    {
        public int Compare(int a, int b)
        {
            return a.CompareTo(b);
        }
    }
}
