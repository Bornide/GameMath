﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Core.Extensions
{
    public static class CastExtensions
    {
        public static short ToShort(this decimal value) => Convert.ToInt16(value);
        public static int ToInt(this decimal value) => Convert.ToInt32(value);
        public static long ToLong(this decimal value) => Convert.ToInt64(value);
        public static float ToFloat(this decimal value) => (float)value;
        public static double ToDouble(this decimal value) => Convert.ToDouble(value);


        public static Point2D<short> ToShort(this Point2D<decimal> point2D) => new Point2D<short> { X = Convert.ToInt16(point2D.X), Y = Convert.ToInt16(point2D.Y) };
        public static Point2D<int> ToInt(this Point2D<decimal> point2D) => new Point2D<int> { X = Convert.ToInt32(point2D.X), Y = Convert.ToInt32(point2D.Y) };
        public static System.Drawing.Point ToPoint(this Point2D<decimal> point2D) => new System.Drawing.Point { X = Convert.ToInt32(point2D.X), Y = Convert.ToInt32(point2D.Y) };
        public static Point2D<long> ToLong(this Point2D<decimal> point2D) => new Point2D<long> { X = Convert.ToInt64(point2D.X), Y = Convert.ToInt64(point2D.Y) };
        public static Point2D<float> ToFloat(this Point2D<decimal> point2D) => new Point2D<float> { X = (float)point2D.X, Y = (float)point2D.Y };
        public static System.Drawing.PointF ToPointF(this Point2D<decimal> point2D) => new System.Drawing.PointF { X = (float)point2D.X, Y = (float)point2D.Y };
        public static Point2D<double> ToDouble(this Point2D<decimal> point2D) => new Point2D<double> { X = Convert.ToDouble(point2D.X), Y = Convert.ToDouble(point2D.Y) };

        public static Point3D<short> ToShort(this Point3D<decimal> point3D) 
            => new Point3D<short> { X = Convert.ToInt16(point3D.X), Y = Convert.ToInt16(point3D.Y), Z = Convert.ToInt16(point3D.Z) };
        public static Point3D<int> ToInt(this Point3D<decimal> point3D)
            => new Point3D<int> { X = Convert.ToInt32(point3D.X), Y = Convert.ToInt32(point3D.Y), Z = Convert.ToInt32(point3D.Z) };
        public static Point3D<long> ToLong(this Point3D<decimal> point3D) 
            => new Point3D<long> { X = Convert.ToInt64(point3D.X), Y = Convert.ToInt64(point3D.Y), Z = Convert.ToInt64(point3D.Z) };
        public static Point3D<float> ToFloat(this Point3D<decimal> point3D)
            => new Point3D<float> { X = (float)(point3D.X), Y = (float)(point3D.Y), Z = (float)(point3D.Z) };
        public static Point3D<double> ToDouble(this Point3D<decimal> point3D)
            => new Point3D<double> { X = Convert.ToDouble(point3D.X), Y = Convert.ToDouble(point3D.Y), Z = Convert.ToDouble(point3D.Z) };

        public static decimal[] ToDecimal(this short[] array)
        {
            var doubleArray = new decimal[array.Length];
            for (int i = 0; i < array.Length; i++) doubleArray[i] = array[i];
            return doubleArray;
        }

        public static decimal[] ToDecimal(this int[] array)
        {
            var doubleArray = new decimal[array.Length];
            for (int i = 0; i < array.Length; i++) doubleArray[i] = array[i];
            return doubleArray;
        }

        public static decimal[] ToDecimal(this long[] array)
        {
            var doubleArray = new decimal[array.Length];
            for (int i = 0; i < array.Length; i++) doubleArray[i] = array[i];
            return doubleArray;
        }

        public static decimal[] ToDecimal(this float[] array)
        {
            var doubleArray = new decimal[array.Length];
            for (int i = 0; i < array.Length; i++) doubleArray[i] = Convert.ToDecimal(array[i]);
            return doubleArray;
        }

        public static decimal[] ToDecimal(this double[] array)
        {
            var doubleArray = new decimal[array.Length];
            for (int i = 0; i < array.Length; i++) doubleArray[i] = Convert.ToDecimal(array[i]);
            return doubleArray;
        }
    }
}