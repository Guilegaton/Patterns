namespace Patterns._03._Structur.Bridge.Models
{
    public struct Point
    {
        #region Public Constructors

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        #endregion Public Constructors

        #region Public Properties

        public int X { get; set; }
        public int Y { get; set; }

        #endregion Public Properties
    }
}