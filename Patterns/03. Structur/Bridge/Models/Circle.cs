using Patterns._03._Structur.Bridge.Interfaces;
using System.Collections.Generic;

namespace Patterns._03._Structur.Bridge.Models
{
    public class Circle : Shape
    {
        #region Public Constructors

        public Circle(IRenderer renderer, Point center, int radius) : base(renderer)
        {
            Center = center;
            Radius = radius;
        }

        #endregion Public Constructors

        #region Public Properties

        public Point Center { get; private set; }
        public int Radius { get; private set; }

        #endregion Public Properties

        #region Public Methods

        public override void Draw()
        {
            _renderer.Render("It's a circle", new Dictionary<string, string>() {
                { "Center", $"({Center.X},{Center.Y})" },
                { "Radius", Radius.ToString() }
            });
        }

        #endregion Public Methods
    }
}