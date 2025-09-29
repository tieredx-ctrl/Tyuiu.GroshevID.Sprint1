﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GroshevID.Sprint1.Task3.V11.Lib
{
    public class DataService : ISprint1Task3V11
    {
        public double TriangleArea(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            return 0.5 * Math.Abs(x1*(y2-y3) + x2*(y3-y1) + x3*(y1-y2));
        }
    }
}
