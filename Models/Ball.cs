using System.Threading;

namespace BlazorApp1.Models
{
    public class Ball
    {
        private readonly double _width;
        private readonly double _height;

        public Ball(string colour, double x, double y, double width, double height)
        {
            Colour = colour;
            _width = width;
            _height = height;
            X = x;
            Y = y;
        }

        public double X { get; private set; }
        public double Y { get; private set; }
        public string Colour { get; }

        private const double Velocity = 3.0;
        private const double StartingAngle = 70.0;
        public static double Radius = 10.0;

        private double _moveX = Math.Cos(Math.PI / 180 * StartingAngle) * Velocity;
        private double _moveY = Math.Sin(Math.PI / 180 * StartingAngle) * Velocity;

        public void Update()
        {
            if (this.X > _width - Radius || this.X < Radius) _moveX = -_moveX;
            if (this.Y > _height - Radius || this.Y < Radius) _moveY = -_moveY;
            this.X += _moveX;
            this.Y += _moveY;
        }
    }
}
