using System.Formats.Asn1;

namespace Assignment_1_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double squareLength = 5.5;
            double result = SquareArea(squareLength);
            Console.WriteLine(result);

            double rectHeight = 5.5;
            double rectBase = 2;
            result = RectangleArea(rectHeight, rectBase);
            Console.WriteLine(result);
        }

        static double SquareArea(double length)
        {
            return length * length;
        }

        static double RectangleArea(double height,double length)
        {
            return length * height;
        }

        static double TriangleArea(double height, double length)
        {
            return 0.5 * length * height;
        }



    }
}
