using Patterns.Creational.Factory_Method.Interfaces;
using Patterns.Creational.Factory_Method.Models;

namespace Patterns.Creational.Factory_Method.Factories
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