using System.Collections.Generic;

namespace Patterns._03._Structur.Bridge.Interfaces
{
    public interface IRenderer
    {
        #region Public Methods

        void Render(string shapeType, Dictionary<string, string> additionalParams);

        #endregion Public Methods
    }
}