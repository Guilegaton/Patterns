using Patterns.Creational.AbstractFactory.Interfaces;
using Patterns.Creational.AbstractFactory.Models;

namespace Patterns.Creational.AbstractFactory.Factories
{
    public class MailFactory : IPostFactory
    {
        #region Public Methods

        public IPostProduct CreateProduct()
        {
            return new Mail();
        }

        #endregion Public Methods
    }
}