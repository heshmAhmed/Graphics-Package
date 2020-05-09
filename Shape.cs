using System;
using System.Collections.Generic;
using System.Text;

namespace Graphics_Package
{
    class Shape
    {
        private static Shape instance = null;
        private Shape() { }
        public static Shape CreateShape()
        {
            if (instance == null)
                instance = new Shape();
            return instance;
        }
        /**
        * author hesham ahmed 
        * rx, ry
        * xc = position of ellipse at x 
        * yc = position of ellipse at y
        */
        public List<Tuple<double, double>> MidPoinEllipseAlgo(double rx, double ry, double xc, double yc)
        {
            //f(x,y) = (ry^2*x^2) + (rx^2*y^2) - (rx^2*ry^2) = ellipse equation 
            double dx, dy, p1, p2, x, y;
            var pixels = new List<Tuple<double, double>>();

            //(0,ry)
            x = 0;
            y = ry;

            // Initial decision parameter of region 1
            // p= ry^2 - rx^2ry + .25rx^2
            p1 = (ry * ry) - (rx * rx * ry) + (0.25f * rx * rx);

            // dx = 2ry^2x
            // dy = 2rx^2y
            //slope = dx / dy;
            dx = 2 * ry * ry * x;
            dy = 2 * rx * rx * y;


            // For region 1 
            while (dx < dy)
            {

                // Add points to list based on 4-way symmetry 
                pixels.Add(new Tuple<double, double>((x + xc), (y + yc)));
                pixels.Add(new Tuple<double, double>((-x + xc), (y + yc)));
                pixels.Add(new Tuple<double, double>((x + xc), (-y + yc)));
                pixels.Add(new Tuple<double, double>((-x + xc), (-y + yc)));

                if (p1 < 0)
                {
                    dx = dx + (2 * ry * ry);
                    p1 = p1 + dx + (ry * ry);
                }
                else
                {
                    y--;
                    dx = dx + (2 * ry * ry);
                    dy = dy - (2 * rx * rx);
                    p1 = p1 + dx - dy + (ry * ry);
                }
                x++;
            }

            // Decision parameter of region 2 
            p2 = ((ry * ry) * ((x + 0.5f) * (x + 0.5f))) + ((rx * rx) * ((y - 1) * (y - 1))) - (rx * rx * ry * ry);
            // Plotting points of region 2 
            while (y >= 0)
            {

                // Add points to list based on 4-way symmetry 
                pixels.Add(new Tuple<double, double>((x + xc), (y + yc)));
                pixels.Add(new Tuple<double, double>((-x + xc), (y + yc)));
                pixels.Add(new Tuple<double, double>((x + xc), (-y + yc)));
                pixels.Add(new Tuple<double, double>((-x + xc), (-y + yc)));

                // Checking and updating parameter 
                // value based on algorithm 
                if (p2 > 0)
                {
                    dy = dy - (2 * rx * rx);
                    p2 = p2 + (rx * rx) - dy;
                }
                else
                {
                    x++;
                    dx = dx + (2 * ry * ry);
                    dy = dy - (2 * rx * rx);
                    p2 = p2 + dx - dy + (rx * rx);
                }
                y--;
            }
            return pixels;
        }

        // function for line generation 
        // author mahmoud gad
        public List<Tuple<double, double>> bresenham(double x1, double y1, double x2, double y2)
        {

            double m_new = 2 * (y2 - y1);
            double slope_error_new = m_new - (x2 - x1);

            List<Tuple<double, double>> list = new List<Tuple<double, double>>();


            for (double x = x1, y = y1; x <= x2; x++)
            {


                list.Add(new Tuple<double, double>(x, y));

                slope_error_new += m_new;



                if (slope_error_new >= 0.0)
                {
                    y++;
                    slope_error_new -= 2.0 * (x2 - x1);
                }
            }

            return list;
        }

        // Implementing Mid-Point Circle 

        public List<Tuple<double, double>> midPointCircleDraw(double x_centre, double y_centre, double r)
        {

            double x = r, y = 0;

            List<Tuple<double, double>> list = new List<Tuple<double, double>>();



            Console.Write("(" + (x + x_centre) + ", " + (y + y_centre) + ")");

            list.Add(new Tuple<double, double>(x + x_centre, y + y_centre));


            if (r > 0)
            {

                list.Add(new Tuple<double, double>(x + x_centre, -y + y_centre));


                list.Add(new Tuple<double, double>(y + x_centre, x + y_centre));


                list.Add(new Tuple<double, double>(-y + x_centre, x + y_centre));

            }

            double P = 1 - r;
            while (x > y)
            {

                y++;

                if (P <= 0)
                    P = P + 2 * y + 1;

                else
                {
                    x--;
                    P = P + 2 * y - 2 * x + 1;
                }


                if (x < y)
                    break;


                list.Add(new Tuple<double, double>(x + x_centre, y + y_centre));

                list.Add(new Tuple<double, double>(-x + x_centre, y + y_centre));


                list.Add(new Tuple<double, double>(x + x_centre, -y + y_centre));


                list.Add(new Tuple<double, double>(-x + x_centre, -y + y_centre));


                if (x != y)
                {

                    list.Add(new Tuple<double, double>(y + x_centre, x + y_centre));

                    list.Add(new Tuple<double, double>(-y + x_centre, x + y_centre));


                    list.Add(new Tuple<double, double>(y + x_centre, -x + y_centre));


                    list.Add(new Tuple<double, double>(-y + x_centre, -x + y_centre));

                }
            }
            return list;

        }
    }
}
