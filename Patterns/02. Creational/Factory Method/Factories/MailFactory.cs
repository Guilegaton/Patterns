using Patterns.Creational.Factory_Method.Interfaces;
using Patterns.Creational.Factory_Method.Models;

namespace Patterns.Creational.Factory_Method.Factories
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