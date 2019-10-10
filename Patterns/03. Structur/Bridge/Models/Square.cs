using Patterns._03._Structur.Bridge.Interfaces;
using System;
using System.Linq;

namespace Patterns._03._Structur.Bridge.Models
{
    public class Square : Shape
    {
        #region Public Constructors

        public Square(IRenderer renderer, Point p1, Point p2, Point p3, Point p4) : base(renderer)
        {
            Points = new Point[]
            {
                p1,
                p2,
                p3,
                p4
            };
        }

        #endregion Public Constructors

        #region Public Properties

        public Point[] Points { get; set; }

        #endregion Public Properties

        #region Public Methods

        public override void Draw()
        {
            _renderer.Render("It's a square", Points.ToDictionary(point => $"Point {(Array.IndexOf(Points, point) + 1)}", point => $"{point.X}; {point.Y}"));
        }

        #endregion Public Methods
    }
}