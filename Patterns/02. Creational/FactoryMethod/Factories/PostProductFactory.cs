using Patterns._02._Creational.FactoryMethod.Models;

namespace Patterns._02._Creational.FactoryMethod.Factories
{
    public class PostProductFactory
    {
        #region Public Methods

        public virtual PostProduct CreateProduct(string from, string to)
        {
            return new PostProduct
            {
                From = from,
                To = to
            };
        }

        #endregion Public Methods
    }
}