using Patterns._03._Structur.Bridge.Models;
using Patterns.Interfaces;

namespace Patterns._03._Structur.Bridge
{
    public class BridgeProcess : IExampleService
    {
        #region Public Methods

        public void StartExample()
        {
            PixelRenderer pixelRenderer = new PixelRenderer();
            BitmapRenderer bitmapRenderer = new BitmapRenderer();

            Shape circle = new Circle(pixelRenderer, new Point(10, 15), 20);
            Shape square = new Square(bitmapRenderer,
                new Point(0, 0),
                new Point(10, 0),
                new Point(10, 10),
                new Point(0, 10));

            circle.Draw();
            square.Draw();
        }

        #endregion Public Methods
    }
}