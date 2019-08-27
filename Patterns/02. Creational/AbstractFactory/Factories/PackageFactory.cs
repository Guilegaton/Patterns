using Patterns.Creational.AbstractFactory.Interfaces;
using Patterns.Creational.AbstractFactory.Models;

namespace Patterns.Creational.AbstractFactory.Factories
{
    public class PackageFactory : IPostFactory
    {
        #region Public Methods

        public IPostProduct CreateProduct()
        {
            return new Package();
        }

        #endregion Public Methods
    }
}