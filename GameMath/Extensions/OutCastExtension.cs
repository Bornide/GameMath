using GameMath.Core.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Core.Extensions
{
    public static class OutCastExtension
    {
        public static void OutputTo(this decimal value, ref short result) { result = Convert.ToInt16(value); }
        public static void OutputTo(this decimal value, ref int result) { result = Convert.ToInt32(value); }
        public static void OutputTo(this decimal value, ref long result) { result = Convert.ToInt64(value); }
        public static void OutputTo(this decimal value, ref float result) { result = (float)value; }
        public static void OutputTo(this decimal value, ref double result) { result = Convert.ToDouble(value); }

        public static void OutputTo(this Point2D<decimal> point2D, ref Point2D<short> result) 
        {
            result.X = Convert.ToInt16(point2D.X);
            result.Y = Convert.ToInt16(point2D.Y);
        }
        public static void OutputTo(this Point2D<decimal> point2D, ref Point2D<int> result)
        {
            result.X = Convert.ToInt32(point2D.X);
            result.Y = Convert.ToInt32(point2D.Y);
        }
        public static void OutputTo(this Point2D<decimal> point2D, ref System.Drawing.Point result)
        {
            result.X = Convert.ToInt32(point2D.X);
            result.Y = Convert.ToInt32(point2D.Y);
        }
        public static void OutputTo(this Point2D<decimal> point2D, ref Microsoft.Xna.Framework.Point result)
        {
            result.X = Convert.ToInt32(point2D.X);
            result.Y = Convert.ToInt32(point2D.Y);
        }
        public static void OutputTo(this Point2D<decimal> point2D, ref Point2D<long> result)
        {
            result.X = Convert.ToInt64(point2D.X);
            result.Y = Convert.ToInt64(point2D.Y);
        }
        public static void OutputTo(this Point2D<decimal> point2D, ref Point2D<float> result)
        {
            result.X = (float)point2D.X;
            result.Y = (float)point2D.Y;
        }
        public static void OutputTo(this Point2D<decimal> point2D, ref System.Drawing.PointF result)
        {
            result.X = (float)point2D.X;
            result.Y = (float)point2D.Y;
        }
        public static void OutputTo(this Point2D<decimal> point2D, ref Point2D<double> result)
        {
            result.X = Convert.ToDouble(point2D.X);
            result.Y = Convert.ToDouble(point2D.Y);
        }

        public static void OutputTo(this Point3D<decimal> point2D, ref Point3D<short> result)
        {
            result.X = Convert.ToInt16(point2D.X);
            result.Y = Convert.ToInt16(point2D.Y);
            result.Z = Convert.ToInt16(point2D.Z);
        }
        public static void OutputTo(this Point3D<decimal> point2D, ref Point3D<int> result)
        {
            result.X = Convert.ToInt32(point2D.X);
            result.Y = Convert.ToInt32(point2D.Y);
            result.Z = Convert.ToInt32(point2D.Z);
        }
        public static void OutputTo(this Point3D<decimal> point2D, ref Point3D<long> result)
        {
            result.X = Convert.ToInt64(point2D.X);
            result.Y = Convert.ToInt64(point2D.Y);
            result.Z = Convert.ToInt64(point2D.Z);
        }
        public static void OutputTo(this Point3D<decimal> point2D, ref Point3D<float> result)
        {
            result.X = (float)point2D.X;
            result.Y = (float)point2D.Y;
            result.Z = (float)point2D.Z;
        }
        public static void OutputTo(this Point3D<decimal> point2D, ref Point3D<double> result)
        {
            result.X = Convert.ToDouble(point2D.X);
            result.Y = Convert.ToDouble(point2D.Y);
            result.Z = Convert.ToDouble(point2D.Z);
        }
    }
}
