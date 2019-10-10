using Patterns._03._Structur.Bridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns._03._Structur.Bridge.Models
{
    public abstract class Shape
    { 
        protected IRenderer _renderer { get; private set; }

        public Shape(IRenderer renderer)
        {
            _renderer = renderer;
        }

        public abstract void Draw();
    }
}
