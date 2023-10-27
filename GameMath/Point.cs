
namespace GameMath.Core
{
    struct Point
    {
        private readonly int _x;
        private readonly int _y;
        public int X { get { return _x; } }
        public int Y { get { return _y; } }

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public static Point operator *(Point p, float t) => new Point((int)(p._x * t), (int)(p._y * t));
        public static Point operator *(float t, Point p) => new Point((int)(p._x * t), (int)(p._y * t));
        public static Point operator /(float t, Point p) => new Point((int)(p._x / t), (int)(p._y / t));
        public static Point operator /(Point p, float t) => new Point((int)(p._x / t), (int)(p._y / t));
        public static Point operator *(Point p, double t) => new Point((int)(p._x * t), (int)(p._y * t));
        public static Point operator *(double t, Point p) => new Point((int)(p._x * t), (int)(p._y * t));
        public static Point operator /(double t, Point p) => new Point((int)(p._x / t), (int)(p._y / t));
        public static Point operator /(Point p, double t) => new Point((int)(p._x / t), (int)(p._y / t));
        public static Point operator +(Point p1, Point p2) => new Point(p1._x + p2._x, p1._y + p2._y);
        public static Point operator -(Point p1, Point p2) => new Point(p1._x - p2._x, p1._y - p2._y);
    }
}