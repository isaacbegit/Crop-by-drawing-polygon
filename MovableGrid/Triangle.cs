using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;


    public class Triangle : Polygon
    {
        public Triangle(Point p0, Point p1, Point p2)
        {
            Points = new Point[] { p0, p1, p2 };
        }
    }

