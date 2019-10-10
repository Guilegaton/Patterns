using Patterns._03._Structur.Bridge.Interfaces;
using System;
using System.Collections.Generic;

namespace Patterns._03._Structur.Bridge.Models
{
    public class BitmapRenderer : IRenderer
    {
        #region Public Methods

        public void Render(string shapeType, Dictionary<string, string> additionalParams)
        {
            Console.WriteLine("It's a bitmap picture!");
            Console.WriteLine(shapeType);
            foreach (var param in additionalParams)
            {
                Console.WriteLine($"{param.Key}: {param.Value}");
            }
        }

        #endregion Public Methods
    }
}