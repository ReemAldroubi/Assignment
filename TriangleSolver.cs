using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle_Assignment_1
{
    public static class TriangleSolver
    {
        public static string Analyze(int a, int b, int c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
                return "Not Triangle";
            else
            {
                if (a == b && b == c)
                {
                    /* If all sides are equal */
                    return "Equilateral triangle";
                }
                else if (a == b || a == c || b == c)
                {
                    /* If any two sides are equal */
                    return "Isosceles triangle";
                }
                else
                {
                    /* If none sides are equal */
                    return "Scalene triangle";
                }
            }
        }
    }
}
